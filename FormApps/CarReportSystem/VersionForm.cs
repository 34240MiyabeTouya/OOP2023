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
    public partial class VersionForm : Form {
        public VersionForm() {
            InitializeComponent();
        }

        //OKボタンのイベントハンドラ
        private void btOk_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void VersionForm_Load(object sender, EventArgs e) {
            tbVersion.Text = "1.0.0";
        }

       
    }
}
