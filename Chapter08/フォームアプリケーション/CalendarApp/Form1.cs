using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e) {
            var now = DateTime.Now;
            var tpday = dateTimePicker1.Value;
            textBox1.Text = "入力した日にちから" + (now - tpday).Days + "日経過";
        }

        private void btold_Click(object sender, EventArgs e) {
            var age =GetAge(dateTimePicker1.Value, DateTime.Now);
            textBox1.Text = "貴方の年齢は" + age + "歳です";
        }
        public static int GetAge(DateTime birtDay,DateTime targetDay) {
            var age = targetDay.Year - birtDay.Year;
            if (targetDay <birtDay.AddYears(age)) {
                age--;
            }
            return age;
        }
        //タイマーイベントハンドラー
        private void tbnowtime_TextChanged(object sender, EventArgs e) {
            tbnowtime.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd)HH時mm分ss秒");
        }

        private void Form1_Load(object sender, EventArgs e) {
            tbnowtime.Text = DateTime.Now.ToString("yyyy年MM月dd日(dddd)HH時mm分ss秒");
            
        }
    }
}
