using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using 全加密GUI.Properties;

namespace 全加密GUI
{
    // Token: 0x02000003 RID: 3
    public partial class main : Form
    {
        // Token: 0x06000007 RID: 7 RVA: 0x000020D0 File Offset: 0x000002D0
        public main()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000008 RID: 8 RVA: 0x00002120 File Offset: 0x00000320
        private void main_Load(object sender, EventArgs e)
        {
            this.label4.Text = "V " + Application.ProductVersion.ToString();
            this.清空行数 = Convert.ToInt32(this.textBox7.Text);
            this.comboBox1.SelectedIndex = 0;
        }

        // Token: 0x06000009 RID: 9 RVA: 0x00002174 File Offset: 0x00000374
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("已知密钥不能为空");
            }
            else
            {
                this.textBox1.Text = "";
                this.行数 = 0;
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C echo 1|mfoc.exe -k " + this.textBox2.Text + " -O key.dump";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    process.BeginOutputReadLine();
                    process.OutputDataReceived += new DataReceivedEventHandler(this.process_OutputDataReceived);
                }
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x00002274 File Offset: 0x00000474
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                MessageBox.Show("数据不能为空");
            }
            else
            {
                this.textBox1.Text = "";
                this.行数 = 0;
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = "/C echo 1|nfc-mfclassic w A " + this.textBox3.Text + " key.dump";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    process.BeginOutputReadLine();
                    process.OutputDataReceived += new DataReceivedEventHandler(this.process_OutputDataReceived);
                }
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x00002374 File Offset: 0x00000574
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.行数 = 0;
            using (Process process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/C echo 1|mfoc.exe -O key.dump";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                process.BeginOutputReadLine();
                process.OutputDataReceived += new DataReceivedEventHandler(this.process_OutputDataReceived);
            }
        }

        // Token: 0x0600000C RID: 12 RVA: 0x00002430 File Offset: 0x00000630
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.行数 = 0;
            this.textBox6.Text = "";
            if (this.radioButton1.Checked)
            {
                Process.Start("cmd.exe", string.Concat(new string[]
                {
                    "/k echo 1|mfcuk.exe -C -R ",
                    this.区块数,
                    " -S ",
                    this.textBox5.Text,
                    " -s ",
                    this.textBox4.Text,
                    " -v 1"
                }));
            }
            else
            {
                using (Process process = new Process())
                {
                    process.StartInfo.FileName = "cmd.exe";
                    process.StartInfo.Arguments = string.Concat(new string[]
                    {
                        "/C echo 1|mfcuk.exe -C -R ",
                        this.区块数,
                        " -S ",
                        this.textBox5.Text,
                        " -s ",
                        this.textBox4.Text,
                        " -v 3"
                    });
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.CreateNoWindow = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.Start();
                    process.BeginOutputReadLine();
                    process.OutputDataReceived += new DataReceivedEventHandler(this.process_OutputDataReceived);
                }
            }
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000025C4 File Offset: 0x000007C4
        private void button4_Click(object sender, EventArgs e)
        {
            this.KillProcess("mfcuk");
            this.KillProcess("mfoc");
            this.KillProcess("nfc-mfclassic");
        }

        // Token: 0x0600000E RID: 14 RVA: 0x000025EC File Offset: 0x000007EC
        private void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                this.AppendText(e.Data + "\r\n");
            }
        }

        // Token: 0x0600000F RID: 15 RVA: 0x00002620 File Offset: 0x00000820
        public void AppendText(string text)
        {
            if (this.textBox1.InvokeRequired)
            {
                main.AppendTextCallback appendTextCallback = new main.AppendTextCallback(this.AppendText);
                this.textBox1.Invoke(appendTextCallback, new object[]
                {
                    text
                });
            }
            else
            {
                this.行数++;
                this.label10.Text = "当前数据为" + this.行数.ToString() + "行";
                if (this.行数 > this.清空行数)
                {
                    this.textBox1.Text = "";
                    this.行数 = 0;
                }
                int num = text.IndexOf("温");
                if (num >= 0)
                {
                    this.textBox6.AppendText(text.Substring(52, 12) + "\r\n");
                }
                this.textBox1.AppendText(text);
            }
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002718 File Offset: 0x00000918
        private void KillProcess(string processName)
        {
            Process[] processes = Process.GetProcesses();
            Process[] array = processes;
            for (int i = 0; i < array.Length; i++)
            {
                Process process = array[i];
                if (process.ProcessName == processName)
                {
                    process.Kill();
                }
            }
        }

        // Token: 0x06000011 RID: 17 RVA: 0x00002767 File Offset: 0x00000967
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.KillProcess("mfcuk");
            this.KillProcess("mfoc");
            this.KillProcess("nfc-mfclassic");
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002790 File Offset: 0x00000990
        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "请选择文件";
            openFileDialog.Filter = "数据文件|*.dump;*.bin";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                this.textBox3.Text = fileName;
            }
        }

        // Token: 0x06000013 RID: 19 RVA: 0x000027EC File Offset: 0x000009EC
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 16)
            {
                this.区块数 = "-1";
            }
            else
            {
                this.区块数 = this.comboBox1.SelectedIndex.ToString();
            }
        }

        // Token: 0x06000014 RID: 20 RVA: 0x0000283A File Offset: 0x00000A3A
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            this.清空行数 = Convert.ToInt32(this.textBox7.Text);
        }

        // Token: 0x06000015 RID: 21 RVA: 0x00002854 File Offset: 0x00000A54
        private void timer1_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();
            Process[] array = processes;
            for (int i = 0; i < array.Length; i++)
            {
                Process process = array[i];
                if (process.ProcessName == "mfcuk" | process.ProcessName == "mfoc" | process.ProcessName == "nfc-mfclassic")
                {
                    this.进度棒++;
                }
                if (this.进度棒 > 3)
                {
                    this.进度棒 = 0;
                }
                switch (this.进度棒)
                {
                    case 0:
                        this.label6.Text = "-";
                        break;
                    case 1:
                        this.label6.Text = "\\";
                        break;
                    case 2:
                        this.label6.Text = "|";
                        break;
                    case 3:
                        this.label6.Text = "/";
                        break;
                }
            }
        }

        // Token: 0x04000002 RID: 2
        public string 区块数 = "0";

        // Token: 0x04000003 RID: 3
        public int 行数 = 0;

        // Token: 0x04000004 RID: 4
        public int 清空行数 = 0;

        // Token: 0x04000005 RID: 5
        public string 破解结果 = "";

        // Token: 0x04000006 RID: 6
        public int 进度棒 = 0;

        // Token: 0x02000004 RID: 4
        // (Invoke) Token: 0x06000019 RID: 25
        public delegate void AppendTextCallback(string text);
    }
}
