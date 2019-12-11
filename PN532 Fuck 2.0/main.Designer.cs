namespace 全加密GUI
{
    // Token: 0x02000003 RID: 3
    public partial class main : global::System.Windows.Forms.Form
    {
        // Token: 0x06000011 RID: 17 RVA: 0x000022F0 File Offset: 0x000004F0
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000012 RID: 18 RVA: 0x00002328 File Offset: 0x00000528
        private void InitializeComponent()
        {
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::全加密GUI.main));
            this.button1 = new global::System.Windows.Forms.Button();
            this.button2 = new global::System.Windows.Forms.Button();
            this.button3 = new global::System.Windows.Forms.Button();
            this.button7 = new global::System.Windows.Forms.Button();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
            this.button4 = new global::System.Windows.Forms.Button();
            this.label1 = new global::System.Windows.Forms.Label();
            this.textBox2 = new global::System.Windows.Forms.TextBox();
            this.label5 = new global::System.Windows.Forms.Label();
            this.textBox3 = new global::System.Windows.Forms.TextBox();
            this.button5 = new global::System.Windows.Forms.Button();
            //this.pictureBox1.BeginInit();
            base.SuspendLayout();
            this.button1.Location = new global::System.Drawing.Point(85, 12);
            this.button1.Name="button1";
            this.button1.Size=new global::System.Drawing.Size(131, 30);
            this.button1.TabIndex=0;
            this.button1.Text="使用默认密钥读取";
            this.button1.UseVisualStyleBackColor=true;
            this.button1.Click+=new global::System.EventHandler(this.button1_Click);
            this.button2.Location=new global::System.Drawing.Point(85, 49);
            this.button2.Name="button2";
            this.button2.Size=new global::System.Drawing.Size(131, 30);
            this.button2.TabIndex=1;
            this.button2.Text="全加密卡破解密钥";
            this.button2.UseVisualStyleBackColor=true;
            this.button2.Click+=new global::System.EventHandler(this.button2_Click);
            this.button3.Location=new global::System.Drawing.Point(222, 13);
            this.button3.Name="button3";
            this.button3.Size=new global::System.Drawing.Size(131, 30);
            this.button3.TabIndex=2;
            this.button3.Text="使用已知密钥读取";
            this.button3.UseVisualStyleBackColor=true;
            this.button3.Click+=new global::System.EventHandler(this.button3_Click);
            this.button7.Location=new global::System.Drawing.Point(222, 49);
            this.button7.Name="button7";
            this.button7.Size=new global::System.Drawing.Size(131, 30);
            this.button7.TabIndex=8;
            this.button7.Text="写卡";
            this.button7.UseVisualStyleBackColor=true;
            this.button7.Click+=new global::System.EventHandler(this.button7_Click);
            this.label2.AutoSize=true;
            this.label2.Location=new global::System.Drawing.Point(359, 49);
            this.label2.Name="label2";
            this.label2.Size=new global::System.Drawing.Size(269, 24);
            this.label2.TabIndex=9;
            this.label2.Text="如果数据读取成功,数据将被自动保存为 key.dump\r\n写卡时,请先读卡!否则无法写入!";
            this.label4.AutoSize=true;            
            this.label4.ForeColor=global::System.Drawing.Color.Gray;
            this.label4.Location=new global::System.Drawing.Point(8, 74);
            this.label4.Name="label4";
            this.label4.Size=new global::System.Drawing.Size(29, 12);
            this.label4.TabIndex=11;
            this.label4.Text="V1.0";
            this.pictureBox1.Image=global::全加密GUI.Properties.Resources.MIcon;
            this.pictureBox1.Location=new global::System.Drawing.Point(19, 13);
            this.pictureBox1.Name="pictureBox1";
            this.pictureBox1.Size=new global::System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode=System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex=12;
            this.pictureBox1.TabStop=false;
            this.button4.Location=new global::System.Drawing.Point(526, 13);
            this.button4.Name="button4";
            this.button4.Size=new global::System.Drawing.Size(100, 30);
            this.button4.TabIndex=13;
            this.button4.Text="全部停止";
            this.button4.UseVisualStyleBackColor=true;
            this.button4.Click+=new global::System.EventHandler(this.button4_Click);
            this.label1.AutoSize=true;
            this.label1.Location=new global::System.Drawing.Point(359, 22);
            this.label1.Name="label1";
            this.label1.Size=new global::System.Drawing.Size(59, 12);
            this.label1.TabIndex=14;
            this.label1.Text="已知密钥:";
            this.textBox2.Location=new global::System.Drawing.Point(424, 19);
            this.textBox2.MaxLength=12;
            this.textBox2.Name="textBox2";
            this.textBox2.Size=new global::System.Drawing.Size(88, 21);
            this.textBox2.TabIndex=15;
            this.label5.AutoSize=true;
            this.label5.Location=new global::System.Drawing.Point(24, 97);
            this.label5.Name="label5";
            this.label5.Size=new global::System.Drawing.Size(59, 12);
            this.label5.TabIndex=16;
            this.label5.Text="写入数据:";
            this.textBox3.Location=new global::System.Drawing.Point(85, 92);
            this.textBox3.Name="textBox3";
            this.textBox3.Size=new global::System.Drawing.Size(472, 21);
            this.textBox3.TabIndex=17;
            this.button5.Location=new global::System.Drawing.Point(563, 93);
            this.button5.Name="button5";
            this.button5.Size=new global::System.Drawing.Size(63, 21);
            this.button5.TabIndex=18;
            this.button5.Text="浏览...";
            this.button5.UseVisualStyleBackColor=true;
            this.button5.Click+=new global::System.EventHandler(this.button5_Click);
            base.AutoScaleDimensions=new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize=new global::System.Drawing.Size(638, 118);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle;
            base.Icon=(global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox=false;
            base.Name="main";
            base.StartPosition=System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text="PN532 Fuck";
            base.TopMost=true;

            base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            base.Load += new global::System.EventHandler(this.main_Load);
            //this.pictureBox1.EndInit();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x04000002 RID: 2
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000003 RID: 3
        private global::System.Windows.Forms.Button button1;

        // Token: 0x04000004 RID: 4
        private global::System.Windows.Forms.Button button2;

        // Token: 0x04000005 RID: 5
        private global::System.Windows.Forms.Button button3;

        // Token: 0x04000006 RID: 6
        private global::System.Windows.Forms.Button button7;

        // Token: 0x04000007 RID: 7
        private global::System.Windows.Forms.Label label2;

        // Token: 0x04000008 RID: 8
        private global::System.Windows.Forms.Label label4;

        // Token: 0x04000009 RID: 9
        private global::System.Windows.Forms.PictureBox pictureBox1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Button button4;

        // Token: 0x0400000B RID: 11
        private global::System.Windows.Forms.Label label1;

        // Token: 0x0400000C RID: 12
        private global::System.Windows.Forms.TextBox textBox2;

        // Token: 0x0400000D RID: 13
        private global::System.Windows.Forms.Label label5;

        // Token: 0x0400000E RID: 14
        private global::System.Windows.Forms.TextBox textBox3;

        // Token: 0x0400000F RID: 15
        private global::System.Windows.Forms.Button button5;
    }
}
