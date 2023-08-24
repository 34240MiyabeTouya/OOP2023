using CarReportSystem.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public partial class Form1 : Form {
        //管理用データ
        BindingList<CarReport> CarReports = new BindingList<CarReport>();
        private int mode;
        public Form1() {
            InitializeComponent();
            dgvCarReports.DataSource = CarReports;
        }

        //設定情報保存用オブジェクト
        Settings settings = new Settings();

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
            editItemsClear();//各項目の選択解除

            //コンボボックスに重複がない場合追加
            if (!cbAuthor.Items.Contains(cbAuthor.Text)) {
                cbAuthor.Items.Add(cbAuthor.Text);//コンボボックスに追加
            }
            if (!cbCarName.Items.Contains(cbCarName.Text)) {
                cbCarName.Items.Add(cbCarName.Text);//コンボボックスに追加
            }
        }

        //修正ボタンイベントハンドラ
        private void btModify_Click(object sender, EventArgs e) {
            if (dgvCarReports.Rows.Count != 0) {
                CarReports[dgvCarReports.CurrentRow.Index].Date = dtpDate.Value;
                CarReports[dgvCarReports.CurrentRow.Index].Author = cbAuthor.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Maker = getSelectedMaker();
                CarReports[dgvCarReports.CurrentRow.Index].CarName = cbCarName.Text;
                CarReports[dgvCarReports.CurrentRow.Index].Report = tbReport.Text;
                dgvCarReports.Refresh();//一覧更新
            }
        }

        //削除ボタンのイベントハンドラ
        private void btDelete_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                dgvCarReports.Rows.Remove(item);
            }

            if (dgvCarReports.Rows.Count == 0) {
                btModify.Enabled = false;//マスクする
                btDelete.Enabled = false;//マスクする
            }
        }

        //各項目をクリア
        private void editItemsClear() {
            cbAuthor.Text = "";
            setSelectedMaker(CarReport.MakerGroup.トヨタ);
            cbCarName.Text = "";
            tbReport.Text = null;
            pbCerImage.Image = null;
            dgvCarReports.CurrentCell = null;//選択の解除
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
            if (ofdImageFilOpen.ShowDialog() == DialogResult.OK) {
                pbCerImage.Image = Image.FromFile(ofdImageFilOpen.FileName);
            }
        }

        //画像削除のイベントハンドラ
        private void btImageDelete_Click(object sender, EventArgs e) {
            pbCerImage.Image = null;
        }

        //レコードの選択時
        private void dgvCarReports_CellContentClick(object sender, EventArgs e) {
            if (dgvCarReports.RowCount != 0) {
                dtpDate.Value = (DateTime)dgvCarReports.CurrentRow.Cells[0].Value;
                cbAuthor.Text = dgvCarReports.CurrentRow.Cells[1].Value.ToString();
                setSelectedMaker((CarReport.MakerGroup)dgvCarReports.CurrentRow.Cells[2].Value);
                cbCarName.Text = dgvCarReports.CurrentRow.Cells[3].Value.ToString();
                tbReport.Text = dgvCarReports.CurrentRow.Cells[4].Value.ToString();
                pbCerImage.Image = (Image)dgvCarReports.CurrentRow.Cells[5].Value;
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            tsInfoText.Text = "";

            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
            btModify.Enabled = false;//マスクする
            btDelete.Enabled = false;//マスクする

            //設定ファイルを逆シリアル化して背景に設定
            //using (var reader = XmlReader.Create("settings.xml")) {
            //    var serializer = new XmlSerializer(typeof(Settings));
            //    var sttings = serializer.Deserialize(reader) as Settings;
            //    if (settings.MainFormColor != 0) {
            //        BackColor = Color.FromArgb(settings.MainFormColor);
            //    }
            //}

        }

        //終了メニュー選択時のイベントハンドラ
        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        //バージョン情報メニュー選択時のイベントハンドラ
        private void バージョン情報ToolStripMenuItem_Click(object sender, EventArgs e) {
            var vf = new VersionForm();
            vf.ShowDialog();
        }

        //色設定メニュー選択時のイベントハンドラ
        private void 色設定ToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cdColor.ShowDialog() == DialogResult.OK) {
                BackColor = cdColor.Color;
                settings.MainFormColor = cdColor.Color.ToArgb();
            }
        }

        //★ボタン(サイズ変更)のイベントハンドラ
        private void btScaleChange_Click(object sender, EventArgs e) {
            mode = mode < 4 ? (mode == 1) ? 3 : ++mode : 0;//AutoSize(2)を除外
            pbCerImage.SizeMode = (PictureBoxSizeMode)mode;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            //設定ファイルのシリアル化
            using (var writer = XmlWriter.Create("settings.xml")) {
                var serializer = new XmlSerializer(settings.GetType());
                serializer.Serialize(writer, settings);
            }
        }

        private void tmTimerUpdate_Tick(object sender, EventArgs e) {

            tsInfoText.Text = "";
            //tstimedisp.text = DateTime.Now.ToString("yyyy年MM月dd日 HH時ss分");
            tmTimerUpdate.Start();
        }
    }
}
