using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //ステータスラベルのテキスト表示・非表示
        private void statasLabelDisp(string msg = "") {
            tsInfoText.Text = msg;
        }

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {
            statasLabelDisp();//ステータスラベルのテキスト非表示
            if (cbAuthor.Text == "") {
                statasLabelDisp("記録者を入力してください。");
                return;
            } else if (cbCarName.Text == "") {
                statasLabelDisp("車名を入力してください。");
                return;
            } 

            var CarReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCerImage.Image,
            };
            CarReports.Add(CarReport);
            btModify.Enabled = true;//マスク解除
            btDelete.Enabled = true;//マスク解除
            dgvCarReports.CurrentCell = null;//選択の解除

            //コンボボックスに重複がない場合追加
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);//コンボボックスに追加
            }
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);//コンボボックスに追加
            }
        }

        //ラジオボタンで選択されているメーカーを返却
        private CarReport.MakerGroup getSelectedMaker() {
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                      return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return CarReport.MakerGroup.その他;
        }

        //指定したメーカーのラジオボタンをセット
        private void setSelectedMaker(CarReport.MakerGroup makerGroup) {
            switch (makerGroup) {
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.スズキ:
                    rbSuzuki.Checked = true;
                    break;
                case CarReport.MakerGroup.ダイハツ:
                    rbDaihatsu.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImported.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
        }

        //画像を開くのイベントハンドラ
        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFilOpen.ShowDialog();
            pbCerImage.Image = Image.FromFile(ofdImageFilOpen.FileName);
        }

        //削除ボタンのイベントハンドラ
        private void btDelete_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                    dgvCarReports.Rows.Remove(item);
            }

            if (dgvCarReports.ColumnCount == 0) {
                btModify.Enabled = false;//マスクする
                btDelete.Enabled = false;//マスクする
            }
        }

        //レコードの選択時
        private void dgvCarReports_CellContentClick(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
            cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
            setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
            cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
            tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
            pbCerImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
            btModify.Enabled = false;//マスクする
            btDelete.Enabled = false;//マスクする
            tsInfoText.Text = "ここにメッセージを表示できます";
        }

        //修正ボタンイベントハンドラ
        private void btModify_Click(object sender, EventArgs e) {
            CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
            CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
            CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
            CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
            dgvCarReports.Refresh();//一覧更新
        }

        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void cbAuthor_SelectionChangeCommitted(object sender, EventArgs e) {
           
        }
    }
}
