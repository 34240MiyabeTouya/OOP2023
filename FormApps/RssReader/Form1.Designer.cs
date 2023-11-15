
namespace RssReader {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.lbRssTitle = new System.Windows.Forms.ListBox();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.rb主要 = new System.Windows.Forms.RadioButton();
            this.rb国内 = new System.Windows.Forms.RadioButton();
            this.rb経済 = new System.Windows.Forms.RadioButton();
            this.rbIT = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegistration = new System.Windows.Forms.Button();
            this.cbRegistration = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUrlRegistration = new System.Windows.Forms.TextBox();
            this.tbNameRegistration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusDisp = new System.Windows.Forms.StatusStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.開くtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sfdRssDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusDisp.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUrl
            // 
            this.tbUrl.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbUrl.Location = new System.Drawing.Point(27, 28);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(540, 31);
            this.tbUrl.TabIndex = 0;
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(578, 28);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(75, 31);
            this.btGet.TabIndex = 1;
            this.btGet.Text = "取得";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // lbRssTitle
            // 
            this.lbRssTitle.FormattingEnabled = true;
            this.lbRssTitle.ItemHeight = 12;
            this.lbRssTitle.Location = new System.Drawing.Point(28, 77);
            this.lbRssTitle.Name = "lbRssTitle";
            this.lbRssTitle.Size = new System.Drawing.Size(295, 196);
            this.lbRssTitle.TabIndex = 2;
            this.lbRssTitle.SelectedIndexChanged += new System.EventHandler(this.lbRssTitle_SelectedIndexChanged);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(330, 77);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(868, 589);
            this.webBrowser.TabIndex = 3;
            // 
            // rb主要
            // 
            this.rb主要.AutoSize = true;
            this.rb主要.Location = new System.Drawing.Point(13, 295);
            this.rb主要.Name = "rb主要";
            this.rb主要.Size = new System.Drawing.Size(81, 16);
            this.rb主要.TabIndex = 4;
            this.rb主要.TabStop = true;
            this.rb主要.Text = "Yahoo!主要";
            this.rb主要.UseVisualStyleBackColor = true;
            this.rb主要.CheckedChanged += new System.EventHandler(this.rb主要_CheckedChanged_1);
            // 
            // rb国内
            // 
            this.rb国内.AutoSize = true;
            this.rb国内.Location = new System.Drawing.Point(13, 317);
            this.rb国内.Name = "rb国内";
            this.rb国内.Size = new System.Drawing.Size(81, 16);
            this.rb国内.TabIndex = 5;
            this.rb国内.TabStop = true;
            this.rb国内.Text = "Yahoo!国内";
            this.rb国内.UseVisualStyleBackColor = true;
            this.rb国内.CheckedChanged += new System.EventHandler(this.rb国内_CheckedChanged_1);
            // 
            // rb経済
            // 
            this.rb経済.AutoSize = true;
            this.rb経済.Location = new System.Drawing.Point(13, 339);
            this.rb経済.Name = "rb経済";
            this.rb経済.Size = new System.Drawing.Size(81, 16);
            this.rb経済.TabIndex = 6;
            this.rb経済.TabStop = true;
            this.rb経済.Text = "Yahoo!経済";
            this.rb経済.UseVisualStyleBackColor = true;
            this.rb経済.CheckedChanged += new System.EventHandler(this.rb経済_CheckedChanged_1);
            // 
            // rbIT
            // 
            this.rbIT.AutoSize = true;
            this.rbIT.Location = new System.Drawing.Point(13, 361);
            this.rbIT.Name = "rbIT";
            this.rbIT.Size = new System.Drawing.Size(67, 16);
            this.rbIT.TabIndex = 7;
            this.rbIT.TabStop = true;
            this.rbIT.Text = "Yahoo!IT";
            this.rbIT.UseVisualStyleBackColor = true;
            this.rbIT.CheckedChanged += new System.EventHandler(this.rbIT_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "お気に入り";
            // 
            // btRegistration
            // 
            this.btRegistration.Location = new System.Drawing.Point(248, 635);
            this.btRegistration.Name = "btRegistration";
            this.btRegistration.Size = new System.Drawing.Size(75, 31);
            this.btRegistration.TabIndex = 9;
            this.btRegistration.Text = "登録";
            this.btRegistration.UseVisualStyleBackColor = true;
            this.btRegistration.Click += new System.EventHandler(this.btRegistration_Click);
            // 
            // cbRegistration
            // 
            this.cbRegistration.FormattingEnabled = true;
            this.cbRegistration.Location = new System.Drawing.Point(33, 405);
            this.cbRegistration.Name = "cbRegistration";
            this.cbRegistration.Size = new System.Drawing.Size(295, 20);
            this.cbRegistration.TabIndex = 11;
            this.cbRegistration.SelectedIndexChanged += new System.EventHandler(this.cbRegistration_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "お気に入り登録　　※その他に登録されます";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "その他";
            // 
            // tbUrlRegistration
            // 
            this.tbUrlRegistration.Location = new System.Drawing.Point(27, 529);
            this.tbUrlRegistration.Name = "tbUrlRegistration";
            this.tbUrlRegistration.Size = new System.Drawing.Size(296, 19);
            this.tbUrlRegistration.TabIndex = 14;
            // 
            // tbNameRegistration
            // 
            this.tbNameRegistration.Location = new System.Drawing.Point(27, 588);
            this.tbNameRegistration.Name = "tbNameRegistration";
            this.tbNameRegistration.Size = new System.Drawing.Size(296, 19);
            this.tbNameRegistration.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "登録名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "URL";
            // 
            // statusDisp
            // 
            this.statusDisp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel});
            this.statusDisp.Location = new System.Drawing.Point(0, 669);
            this.statusDisp.Name = "statusDisp";
            this.statusDisp.Size = new System.Drawing.Size(1198, 22);
            this.statusDisp.TabIndex = 18;
            this.statusDisp.Text = "statusStrip1";
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(82, 17);
            this.tsLabel.Text = "インフォメーション";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1198, 25);
            this.toolStrip1.TabIndex = 19;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くtoolStripMenuItem,
            this.toolStripSeparator1,
            this.保存StripMenuItem,
            this.toolStripSeparator2,
            this.終了toolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(68, 22);
            this.toolStripDropDownButton1.Text = "ファイル(&F)";
            // 
            // 開くtoolStripMenuItem
            // 
            this.開くtoolStripMenuItem.Name = "開くtoolStripMenuItem";
            this.開くtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開くtoolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.開くtoolStripMenuItem.Text = "開く(&O)...";
            this.開くtoolStripMenuItem.Click += new System.EventHandler(this.開くtoolStripMenuItem_Click);
            // 
            // 保存StripMenuItem
            // 
            this.保存StripMenuItem.Name = "保存StripMenuItem";
            this.保存StripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存StripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.保存StripMenuItem.Text = "保存(&S)...";
            // 
            // 終了toolStripMenuItem
            // 
            this.終了toolStripMenuItem.Name = "終了toolStripMenuItem";
            this.終了toolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了toolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.終了toolStripMenuItem.Text = "終了(&X)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 691);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusDisp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNameRegistration);
            this.Controls.Add(this.tbUrlRegistration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbRegistration);
            this.Controls.Add(this.btRegistration);
            this.Controls.Add(this.rbIT);
            this.Controls.Add(this.rb国内);
            this.Controls.Add(this.rb経済);
            this.Controls.Add(this.rb主要);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lbRssTitle);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusDisp.ResumeLayout(false);
            this.statusDisp.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.ListBox lbRssTitle;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.RadioButton rb主要;
        private System.Windows.Forms.RadioButton rb国内;
        private System.Windows.Forms.RadioButton rb経済;
        private System.Windows.Forms.RadioButton rbIT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btRegistration;
        private System.Windows.Forms.ComboBox cbRegistration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUrlRegistration;
        private System.Windows.Forms.TextBox tbNameRegistration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusDisp;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem 開くtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了toolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.SaveFileDialog sfdRssDialog;
    }
}

