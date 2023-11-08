using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RssReader {
    public partial class Form1 : Form {
        //取得用データ
        List<ItemData> ItemDatas = new List<ItemData>();

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
                                            ,Link = (string)x.Element("link")
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
                statusDisp
                    //("登録するURlを入力してください。");
            }
            if (tbNameRegistration.Text.Equals("")) {
                Console.WriteLine("登録するURLの名前を入力してください。");
            }
            setcbRegistration(tbUrlRegistration.Text);
        }

        //コンボボックス登録処理
        private void setcbRegistration(string url) {
            if (!cbRegistration.Items.Contains(url)) {
                cbRegistration.Items.Add(url);
            }
        }
        
        //コンボボックスのURLを取得
        private void cbRegistration_SelectedIndexChanged(object sender, EventArgs e) {
            tbUrl.Text = cbRegistration.Text;
            tbUrl.Refresh();//更新処理
        }

        
    }
}
