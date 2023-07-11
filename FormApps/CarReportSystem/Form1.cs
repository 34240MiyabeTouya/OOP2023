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

        //追加ボタンがクリックされた時のイベントハンドラー
        private void btAdd_Click(object sender, EventArgs e) {
            var CarReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = getSelectedMaker().ToString(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                CarImage = pbCerImage.Image,
            };
            CarReports.Add(CarReport);
        }

        private CarReport.MakerGroup getSelectedMaker() {
            int tag = 0;
            foreach (var item in gbMaker.Controls) {
                if (((RadioButton)item).Checked) {
                      return (CarReport.MakerGroup)int.Parse(((RadioButton)item).Tag.ToString());
                }
            }
            return (CarReport.MakerGroup)tag;
        }

        private void btImageOpen_Click(object sender, EventArgs e) {
            ofdImageFilOpen.ShowDialog();
            pbCerImage.Image = Image.FromFile(ofdImageFilOpen.FileName);
        }

        private void btDelete_Click(object sender, EventArgs e) {
            foreach (DataGridViewRow item in dgvCarReports.SelectedRows) {
                    dgvCarReports.Rows.Remove(item);
            }
        }

        private void dgvCarReports_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            dtpDate = dgvCarReports.Rows[e.RowIndex];
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReports.Columns[5].Visible = false;//画像項目非表示
        }
    }
}
