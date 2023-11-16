using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得用データ
        List<ItemData> ItemDatas = new List<ItemData>();
        Dictionary<string, string> UrlDate = new Dictionary<string, string>();

        public Form1() {
            InitializeComponent();
            webBrowser.ScriptErrorsSuppressed = true;
        }

        public void btGet_Click(object sender, EventArgs e) {
            if (tbUrl.Text == "")
                return;

            lbRssTitle.Items.Clear();

            using (var wc = new WebClient()) {

                var url = wc.OpenRead(tbUrl.Text);
                XDocument xdoc = XDocument.Load(url);

                ItemDatas = xdoc.Root.Descendants("item")
                                        .Select(x => new ItemData {
                                            Title = (string)x.Element("title")
                                            ,
                                            Link = (string)x.Element("link")
                                        }).ToList();

                foreach (var node in ItemDatas) {
                    lbRssTitle.Items.Add(node.Title);
                }
            }
        }

        private void lbRssTitle_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbRssTitle.SelectedIndex == -1)
                return;

            webBrowser.Navigate(ItemDatas[lbRssTitle.SelectedIndex].Link);
        }

        private void rb主要_CheckedChanged_1(object sender, EventArgs e) {
            tbUrl.Text = @"https://news.yahoo.co.jp/rss/topics/top-picks.xml";

        }

        private void rb国内_CheckedChanged_1(object sender, EventArgs e) {
            tbUrl.Text = @"https://news.yahoo.co.jp/rss/topics/domestic.xml";

        }

        private void rb経済_CheckedChanged_1(object sender, EventArgs e) {
            tbUrl.Text = @"https://news.yahoo.co.jp/rss/topics/business.xml";

        }

        private void rbIT_CheckedChanged_1(object sender, EventArgs e) {
            tbUrl.Text = @"https://news.yahoo.co.jp/rss/topics/it.xml";

        }

        //登録ボタンのイベントハンドラ
        private void btRegistration_Click(object sender, EventArgs e) {
            if (tbUrlRegistration.Text.Equals("")) {
                tsLabel.Text = "登録するURlを入力してください。";
                return;
            } else if (tbNameRegistration.Text.Equals("")) {
                tsLabel.Text = "登録するURlの名前を入力してください。";
                return;
            }

            setUrldate(tbUrlRegistration.Text,tbNameRegistration.Text);
            //UrlDate.Add(tbUrlRegistration.Text, tbNameRegistration.Text);
            //cbRegistration.Items.Add(tbNameRegistration.Text);
        }

        //Dictionaryの登録処理
        private void setUrldate(string url,string name) {
            if (!UrlDate.ContainsKey(url)) {
                if (!UrlDate.ContainsValue(name)) {
                    UrlDate.Add(url,name);
                    setRegistration(name);
                } else {
                    tsLabel.Text = "URLの名前が登録されています";
                }
            } else {
                tsLabel.Text = "URLが登録されています";
            }

        }

        //コンボボックスの登録処理
        private void setRegistration(string text) {
            if (!cbRegistration.Items.Contains(text)) {
                cbRegistration.Items.Add(text);
            }
        }

        //コンボボックスのURLを取得
        private void cbRegistration_SelectedIndexChanged(object sender, EventArgs e) {
            //コンボボックスで選択した名前と同じディクショナリのValueをtbUrlに表示
            var key = UrlDate.FirstOrDefault(x => x.Value.Equals(cbRegistration.Text)).Key;
            tbUrl.Text = key;
            tbUrl.Refresh();//更新処理
        }

        private void 保存StripMenuItem_Click(object sender, EventArgs e) {
            if (sfdRssDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //バイナリ形式でシリアル化
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdRssDialog.FileName, FileMode.Create)) {
                        bf.Serialize(fs, UrlDate);
                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void 開くtoolStripMenuItem_Click(object sender, EventArgs e) {
            if (sfdRssDialog.ShowDialog() == DialogResult.OK) {
                try {
                    //逆シリアル化でバイナリ形式を取り込む
                    var bf = new BinaryFormatter();
                    using (FileStream fs = File.Open(sfdRssDialog.FileName, FileMode.Open, FileAccess.Read)) {



                    }
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
