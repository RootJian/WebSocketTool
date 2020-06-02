namespace WebSocketTool
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabs = new System.Windows.Forms.TabControl();
            this.test = new System.Windows.Forms.TabPage();
            this.wordwrap = new System.Windows.Forms.CheckBox();
            this.ServerJson = new System.Windows.Forms.CheckBox();
            this.getDataClear = new System.Windows.Forms.Button();
            this.ResponeTextBox = new System.Windows.Forms.TextBox();
            this.JSONparseLabel = new System.Windows.Forms.CheckBox();
            this.sendDataforServerlabel = new System.Windows.Forms.Label();
            this.aboutLink = new System.Windows.Forms.LinkLabel();
            this.aboutLinkTitle = new System.Windows.Forms.Label();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.sendData = new System.Windows.Forms.Button();
            this.sendDataText = new System.Windows.Forms.TextBox();
            this.unConnect = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.testTips = new System.Windows.Forms.Label();
            this.setting = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.HeaderPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.TabPage();
            this.version = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabs.SuspendLayout();
            this.test.SuspendLayout();
            this.setting.SuspendLayout();
            this.about.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.CausesValidation = false;
            this.tabs.Controls.Add(this.test);
            this.tabs.Controls.Add(this.setting);
            this.tabs.Controls.Add(this.about);
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabStop = false;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // test
            // 
            this.test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.test.CausesValidation = false;
            this.test.Controls.Add(this.wordwrap);
            this.test.Controls.Add(this.ServerJson);
            this.test.Controls.Add(this.getDataClear);
            this.test.Controls.Add(this.ResponeTextBox);
            this.test.Controls.Add(this.JSONparseLabel);
            this.test.Controls.Add(this.sendDataforServerlabel);
            this.test.Controls.Add(this.aboutLink);
            this.test.Controls.Add(this.aboutLinkTitle);
            this.test.Controls.Add(this.aboutLabel);
            this.test.Controls.Add(this.sendData);
            this.test.Controls.Add(this.sendDataText);
            this.test.Controls.Add(this.unConnect);
            this.test.Controls.Add(this.connect);
            this.test.Controls.Add(this.path);
            this.test.Controls.Add(this.testTips);
            resources.ApplyResources(this.test, "test");
            this.test.Name = "test";
            this.test.UseVisualStyleBackColor = true;
            // 
            // wordwrap
            // 
            resources.ApplyResources(this.wordwrap, "wordwrap");
            this.wordwrap.Name = "wordwrap";
            this.wordwrap.UseVisualStyleBackColor = true;
            this.wordwrap.CheckedChanged += new System.EventHandler(this.wordwrap_CheckedChanged);
            // 
            // ServerJson
            // 
            resources.ApplyResources(this.ServerJson, "ServerJson");
            this.ServerJson.Name = "ServerJson";
            this.ServerJson.UseVisualStyleBackColor = true;
            // 
            // getDataClear
            // 
            resources.ApplyResources(this.getDataClear, "getDataClear");
            this.getDataClear.Name = "getDataClear";
            this.getDataClear.UseVisualStyleBackColor = true;
            this.getDataClear.Click += new System.EventHandler(this.getDataClear_Click);
            // 
            // ResponeTextBox
            // 
            resources.ApplyResources(this.ResponeTextBox, "ResponeTextBox");
            this.ResponeTextBox.Name = "ResponeTextBox";
            this.ResponeTextBox.ReadOnly = true;
            // 
            // JSONparseLabel
            // 
            resources.ApplyResources(this.JSONparseLabel, "JSONparseLabel");
            this.JSONparseLabel.Checked = true;
            this.JSONparseLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JSONparseLabel.Name = "JSONparseLabel";
            this.JSONparseLabel.Tag = "";
            this.JSONparseLabel.UseVisualStyleBackColor = true;
            // 
            // sendDataforServerlabel
            // 
            resources.ApplyResources(this.sendDataforServerlabel, "sendDataforServerlabel");
            this.sendDataforServerlabel.Name = "sendDataforServerlabel";
            // 
            // aboutLink
            // 
            resources.ApplyResources(this.aboutLink, "aboutLink");
            this.aboutLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.aboutLink.Name = "aboutLink";
            this.aboutLink.TabStop = true;
            this.aboutLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutLink_LinkClicked);
            // 
            // aboutLinkTitle
            // 
            resources.ApplyResources(this.aboutLinkTitle, "aboutLinkTitle");
            this.aboutLinkTitle.Name = "aboutLinkTitle";
            // 
            // aboutLabel
            // 
            resources.ApplyResources(this.aboutLabel, "aboutLabel");
            this.aboutLabel.Name = "aboutLabel";
            // 
            // sendData
            // 
            resources.ApplyResources(this.sendData, "sendData");
            this.sendData.Name = "sendData";
            this.sendData.UseVisualStyleBackColor = true;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // sendDataText
            // 
            resources.ApplyResources(this.sendDataText, "sendDataText");
            this.sendDataText.Name = "sendDataText";
            // 
            // unConnect
            // 
            resources.ApplyResources(this.unConnect, "unConnect");
            this.unConnect.Name = "unConnect";
            this.unConnect.UseVisualStyleBackColor = true;
            this.unConnect.Click += new System.EventHandler(this.unConnect_Click);
            // 
            // connect
            // 
            resources.ApplyResources(this.connect, "connect");
            this.connect.Name = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // path
            // 
            resources.ApplyResources(this.path, "path");
            this.path.Name = "path";
            // 
            // testTips
            // 
            resources.ApplyResources(this.testTips, "testTips");
            this.testTips.Name = "testTips";
            // 
            // setting
            // 
            this.setting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.setting.CausesValidation = false;
            this.setting.Controls.Add(this.label2);
            this.setting.Controls.Add(this.saveConfig);
            this.setting.Controls.Add(this.HeaderPath);
            this.setting.Controls.Add(this.label1);
            resources.ApplyResources(this.setting, "setting");
            this.setting.Name = "setting";
            this.setting.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // saveConfig
            // 
            resources.ApplyResources(this.saveConfig, "saveConfig");
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // HeaderPath
            // 
            resources.ApplyResources(this.HeaderPath, "HeaderPath");
            this.HeaderPath.Name = "HeaderPath";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // about
            // 
            this.about.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(11)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.about.CausesValidation = false;
            this.about.Controls.Add(this.version);
            this.about.Controls.Add(this.label5);
            this.about.Controls.Add(this.linkLabel1);
            this.about.Controls.Add(this.label4);
            this.about.Controls.Add(this.label3);
            this.about.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.about, "about");
            this.about.Name = "about";
            this.about.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            resources.ApplyResources(this.version, "version");
            this.version.Name = "version";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::WebSocketTool.Properties.Resources.logo1;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabs.ResumeLayout(false);
            this.test.ResumeLayout(false);
            this.test.PerformLayout();
            this.setting.ResumeLayout(false);
            this.setting.PerformLayout();
            this.about.ResumeLayout(false);
            this.about.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage test;
        private System.Windows.Forms.TabPage setting;
        private System.Windows.Forms.TabPage about;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Label testTips;
        private System.Windows.Forms.Button unConnect;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button sendData;
        private System.Windows.Forms.TextBox sendDataText;
        private System.Windows.Forms.LinkLabel aboutLink;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.Label aboutLinkTitle;
        private System.Windows.Forms.Label sendDataforServerlabel;
        private System.Windows.Forms.CheckBox JSONparseLabel;
        private System.Windows.Forms.Button getDataClear;
        private System.Windows.Forms.TextBox ResponeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.TextBox HeaderPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ServerJson;
        private System.Windows.Forms.CheckBox wordwrap;
    }
}

