using System;
using System.Drawing;
using System.Windows.Forms;
using WebSocketTool.Properties;
using WebSocketSharp;
using Newtonsoft.Json;

namespace WebSocketTool
{
    public partial class Main : Form
    {
        WebSocket ws;
        public Main()
        {
            InitializeComponent();
            Button.CheckForIllegalCrossThreadCalls = false;
        }
        delegate void SetTextCallback(MessageEventArgs e);
        private void Main_Load(object sender, EventArgs e)
        {
            path.Focus();
            HeaderPath.Text = Settings.Default.path;
            path.Text = Settings.Default.mainpath;
            version.Text = Resources.version;
            unConnect.ForeColor = Color.FromName("#000000");
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabs.TabPages[tabs.SelectedIndex].Focus();
        }

        private void aboutLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RootJian");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/RootJian/WebSocketTool");
        }

        private void saveConfig_Click(object sender, EventArgs e)
        {
            Settings.Default.path = HeaderPath.Text;
            Settings.Default.Save();
            MessageBox.Show("保存成功","设置");
        }

        private void connect_Click(object sender, EventArgs e)
        {
            connect.Enabled = false;
            string allPath = Settings.Default.path + path.Text;
            try
            {
                ws = new WebSocket(allPath);
                ws.OnMessage += (senders, es) =>
                {
                    GetMessage(es);
                };
                ws.OnClose += (senders, es) =>
                {
                    if (es.Code == 1006)
                    {
                        connect.Enabled = true;
                        unConnect.Enabled = false;
                        sendData.Enabled = false;
                        ResponeTextBox.AppendText("测试工具：连接被断开！\r\n\r\n测试工具：请检查网络和服务器运行状态\r\n\r\n");
                    }
                    else if(es.Code!=1005)
                    {
                        ResponeTextBox.AppendText("测试工具：连接被断开！\r\n\r\n测试工具：错误代码：" + es.Code + "\r\n\r\n" + "断开原因：" + es.Reason + "\r\n\r\n");
                    }
                };
                ws.Connect();
                ws.Send("(RootJian)开发：https://github.com/RootJian");
                unConnect.Enabled = true;
                sendData.Enabled = true;
                Settings.Default.mainpath = path.Text;
                Settings.Default.Save();
            }
            catch
            {
                connect.Enabled = true;
                ResponeTextBox.AppendText("测试工具：请检查链接或服务器！\r\n\r\n测试工具：当前试图连接地址为：" + allPath+ "\r\n\r\n");
            }
        }

        private void unConnect_Click(object sender, EventArgs e)
        {
            try
            {
                ws.Close();
                connect.Enabled = true;
                unConnect.Enabled = false;
                sendData.Enabled = false;
                ResponeTextBox.AppendText("测试工具：连接已经断开！\r\n\r\n");
            }
            catch
            {
                ResponeTextBox.AppendText("测试工具:关闭连接异常，请检查是否已连接！ \r\n\r\n");
            }
        }

        private void getDataClear_Click(object sender, EventArgs e)
        {
            ResponeTextBox.Text = "";
        }

        private void GetMessage(MessageEventArgs e)
        {
            if (this.ResponeTextBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(GetMessage);
                this.Invoke(d, new object[] { e });
            }
            else
            {
                if (ServerJson.Checked)
                {
                    object json = @JsonConvert.DeserializeObject(@e.Data);
                    ResponeTextBox.AppendText("服务器:\r\n\r\n" + json + " \r\n\r\n");
                }
                else
                {
                    ResponeTextBox.AppendText("服务器:\r\n\r\n" + @e.Data + " \r\n\r\n");
                }
            }
        }

        private void sendData_Click(object sender, EventArgs e)
        {
            if (sendDataText.Text == "")
            {
                ResponeTextBox.AppendText("测试工具：发送数据不得为空！\r\n\r\n");
            }
            else
            {
                if (JSONparseLabel.Checked)
                {
                    try
                    {
                        string json = JsonConvert.DeserializeObject(sendDataText.Text).ToString();
                        ws.Send(json);
                        ResponeTextBox.AppendText("测试工具：向服务器发送了\r\n\r\n" + json + "\r\n\r\n");
                    }
                    catch
                    {
                        ResponeTextBox.AppendText("测试工具：您的JSON数据不标准，发送失败，请检查待发送饿数据。\r\n\r\n如发送的不是JSON数据，请取消勾选JSON\r\n\r\n");
                    }
                }
                else
                {
                    ws.Send(sendDataText.Text);
                    ResponeTextBox.AppendText("测试工具：向服务器发送了\r\n\r\n" + sendDataText.Text + "\r\n\r\n");
                }
            }
        }

        private void wordwrap_CheckedChanged(object sender, EventArgs e)
        {
            ResponeTextBox.WordWrap = wordwrap.Checked;
        }
    }
}
