using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btRunNotepad_Click(object sender, EventArgs e) {
            var path = @"%SystemRoot%\system32\notepad.exe";
            var fullpath = Environment.ExpandEnvironmentVariables(path);

            var startinfo = new ProcessStartInfo {
                FileName = fullpath,
                Arguments = @"C:\temp\Sample.txt",
                WindowStyle = ProcessWindowStyle.Maximized
            };


            Process.Start(startinfo);
        }

        private void btRunAndWaitNotepad_Click(object sender, EventArgs e) {
            RanAndWaitNotepad();
            MessageBox.Show("終了");
        }

        private static int RanAndWaitNotepad() {
            var path = @"%SystemRoot%\system32\notepad.exe";
            var fullpath = Environment.ExpandEnvironmentVariables(path);
            using (var process = Process.Start(fullpath)) {
                if (process.WaitForExit(10000)) 
                    return process.ExitCode;
                    throw new TimeoutException();
                
            }
        }
    }
}
