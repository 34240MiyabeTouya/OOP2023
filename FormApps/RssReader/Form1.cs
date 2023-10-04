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
            //"https://news.yahoo.co.jp/rss/topics/domestic.xml"
        }
    }
}
