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
        // Token: 0x06000007 RID: 7 RVA: 0x000020CD File Offset: 0x000002CD
        public main()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000008 RID: 8 RVA: 0x000020E6 File Offset: 0x000002E6
        private void main_Load(object sender, EventArgs e)
        {
            this.label4.Text = "V " + Application.ProductVersion.ToString();
        }

        // Token: 0x06000009 RID: 9 RVA: 0x0000210C File Offset: 0x0000030C
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("已知密钥不能为空");
            }
            else
            {
                Process.Start("cmd.exe", "/k echo 1|mfoc.exe -k " + this.textBox2.Text + " -O key.dump");
            }
        }

        // Token: 0x0600000A RID: 10 RVA: 0x0000216C File Offset: 0x0000036C
        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "")
            {
                MessageBox.Show("数据不能为空");
            }
            else
            {
                Process.Start("cmd.exe", "/k echo 1|nfc-mfclassic w A " + this.textBox3.Text + " key.dump");
            }
        }

        // Token: 0x0600000B RID: 11 RVA: 0x000021CC File Offset: 0x000003CC
        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k echo 1|mfoc.exe -O key.dump");
        }

        // Token: 0x0600000C RID: 12 RVA: 0x000021DF File Offset: 0x000003DF
        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k echo 1|mfcuk.exe -C -R 3 -S 250 - s 250 -v 3");
        }

        // Token: 0x0600000D RID: 13 RVA: 0x000021F2 File Offset: 0x000003F2
        private void button4_Click(object sender, EventArgs e)
        {
            this.KillProcess("mfcuk");
            this.KillProcess("mfoc");
            this.KillProcess("nfc-mfclassic");
        }

        // Token: 0x0600000E RID: 14 RVA: 0x0000221C File Offset: 0x0000041C
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

        // Token: 0x0600000F RID: 15 RVA: 0x0000226B File Offset: 0x0000046B
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.KillProcess("mfcuk");
            this.KillProcess("mfoc");
            this.KillProcess("nfc-mfclassic");
        }

        // Token: 0x06000010 RID: 16 RVA: 0x00002294 File Offset: 0x00000494
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
    }
}
