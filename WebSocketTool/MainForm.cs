using System;
using System.Diagnostics;
using System.Windows.Forms;
using WebSocketSharp;
using System.Reflection;
using System.Resources;

namespace WebSocketTool
{
    public partial class MainForm : Form
    {
        WebSocket ws;
        public MainForm()
        {
            InitializeComponent();
        }
        delegate void SetTextCallback(MessageEventArgs e);
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ws = new WebSocket(AddressTextBox.Text);
                ws.OnMessage += (senders, es) =>
                {
                    GetMessage(es);
                };
                ws.Connect();
                ws.Send("(RootJian)开发：https://github.com/RootJian");
                ConnectButton.Enabled = false;
                DisconnectButton.Enabled = true;
            }
            catch
            {
                ResponeTextBox.AppendText("测试工具:连接失败，请检查链接或服务器！ \r\n");
            }
        }
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                ws.Close();
                ConnectButton.Enabled = true;
                DisconnectButton.Enabled = false;
            }
            catch
            {
                ResponeTextBox.AppendText("测试工具:关闭异常，请检查是否已连接！ \r\n");
            }
            
        }
        private void CleanMsgButton_Click(object sender, EventArgs e)
        {
            ResponeTextBox.Text = null;
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            try
            {
                ws.Send(SendMsgTextBox.Text);
                ResponeTextBox.AppendText("发送:"+ SendMsgTextBox.Text + "\r\n");
            }
            catch
            {
                ResponeTextBox.AppendText("测试工具:发送失败，请检网络或查服务器是否连接！ \r\n");
            }
        }
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://github.com/RootJian");
        }
        public void GetMessage(MessageEventArgs e)
        {
            if (this.ResponeTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(GetMessage);
                this.Invoke(d, new object[] { e });
            }else
            {
                ResponeTextBox.AppendText("服务器:" + e.Data + " \r\n");
            }
        }
    }
}