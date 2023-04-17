using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btButton_Click(object sender, EventArgs e) {
            //int ans = int.Parse(tbNum1.Text) + int.Parse(tbNum2.Text);
            //tbAns.Text = ans.ToString();
            int num1 = int.Parse(tbNum1.Text);
            int num2 = int.Parse(tbNum1.Text);
            int sum = num1 + num2;
            tbAns.Text = sum.ToString();

        }
        private void button2_Click(object sender, EventArgs e) {
            double result = Math.Pow((double)nud1.Value, (double)nud2.Value);
            tbans2.Text = result.ToString();
            //一行で書く場合
            //tbans2.Text = (Math.Pow((double)nud1.Value, (double)nud2.Value)).ToString();
        }
    }
}
