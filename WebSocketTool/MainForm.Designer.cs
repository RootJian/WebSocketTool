namespace WebSocketTool
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CleanMsgButton = new System.Windows.Forms.Button();
            this.ResponeTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendMsgTextBox = new System.Windows.Forms.TextBox();
            this.SendMsgLabel = new System.Windows.Forms.Label();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // CleanMsgButton
            // 
            this.CleanMsgButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CleanMsgButton.Location = new System.Drawing.Point(760, 369);
            this.CleanMsgButton.Name = "CleanMsgButton";
            this.CleanMsgButton.Size = new System.Drawing.Size(108, 32);
            this.CleanMsgButton.TabIndex = 19;
            this.CleanMsgButton.Text = "清空屏幕";
            this.CleanMsgButton.UseVisualStyleBackColor = true;
            this.CleanMsgButton.Click += new System.EventHandler(this.CleanMsgButton_Click);
            // 
            // ResponeTextBox
            // 
            this.ResponeTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ResponeTextBox.Location = new System.Drawing.Point(408, 11);
            this.ResponeTextBox.Multiline = true;
            this.ResponeTextBox.Name = "ResponeTextBox";
            this.ResponeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResponeTextBox.Size = new System.Drawing.Size(460, 352);
            this.ResponeTextBox.TabIndex = 18;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendButton.Location = new System.Drawing.Point(269, 331);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(108, 32);
            this.SendButton.TabIndex = 17;
            this.SendButton.Text = "发送数据";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendMsgTextBox
            // 
            this.SendMsgTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMsgTextBox.Location = new System.Drawing.Point(9, 141);
            this.SendMsgTextBox.Multiline = true;
            this.SendMsgTextBox.Name = "SendMsgTextBox";
            this.SendMsgTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SendMsgTextBox.Size = new System.Drawing.Size(368, 184);
            this.SendMsgTextBox.TabIndex = 16;
            // 
            // SendMsgLabel
            // 
            this.SendMsgLabel.AutoSize = true;
            this.SendMsgLabel.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendMsgLabel.Location = new System.Drawing.Point(8, 124);
            this.SendMsgLabel.Name = "SendMsgLabel";
            this.SendMsgLabel.Size = new System.Drawing.Size(161, 14);
            this.SendMsgLabel.TabIndex = 14;
            this.SendMsgLabel.Text = "请输入需要发送的内容：";
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Enabled = false;
            this.DisconnectButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DisconnectButton.Location = new System.Drawing.Point(216, 59);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(161, 43);
            this.DisconnectButton.TabIndex = 13;
            this.DisconnectButton.Text = "断开";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectButton.Location = new System.Drawing.Point(8, 59);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(161, 43);
            this.ConnectButton.TabIndex = 12;
            this.ConnectButton.Text = "连接";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TypeLabel.Location = new System.Drawing.Point(7, 11);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(371, 12);
            this.TypeLabel.TabIndex = 11;
            this.TypeLabel.Text = "服务器地址:（支持本地&远程WS和WSS，类似：ws://localhost:8888）";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddressTextBox.Location = new System.Drawing.Point(9, 30);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(368, 26);
            this.AddressTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "开发：RootJian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "Github：";
            // 
            // linkLabel
            // 
            this.linkLabel.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel.Location = new System.Drawing.Point(57, 379);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(167, 12);
            this.linkLabel.TabIndex = 22;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "https://Github.com/RootJian";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(878, 408);
            this.Controls.Add(this.linkLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CleanMsgButton);
            this.Controls.Add(this.ResponeTextBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendMsgTextBox);
            this.Controls.Add(this.SendMsgLabel);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Websocket测试工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CleanMsgButton;
        private System.Windows.Forms.TextBox ResponeTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox SendMsgTextBox;
        private System.Windows.Forms.Label SendMsgLabel;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel;
    }
}

