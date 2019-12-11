namespace 全加密GUI
{
    // Token: 0x02000003 RID: 3
    public partial class main : global::System.Windows.Forms.Form
    {
        // Token: 0x06000016 RID: 22 RVA: 0x00002960 File Offset: 0x00000B60
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000017 RID: 23 RVA: 0x00002998 File Offset: 0x00000B98
        private void InitializeComponent()
        {
            this.components = new global::System.ComponentModel.Container();
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::全加密GUI.main));
            this.button1 = new global::System.Windows.Forms.Button();
            this.button2 = new global::System.Windows.Forms.Button();
            this.button3 = new global::System.Windows.Forms.Button();
            this.textBox1 = new global::System.Windows.Forms.TextBox();
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
            this.label6 = new global::System.Windows.Forms.Label();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label8 = new global::System.Windows.Forms.Label();
            this.textBox4 = new global::System.Windows.Forms.TextBox();
            this.textBox5 = new global::System.Windows.Forms.TextBox();
            this.comboBox1 = new global::System.Windows.Forms.ComboBox();
            this.label9 = new global::System.Windows.Forms.Label();
            this.textBox6 = new global::System.Windows.Forms.TextBox();
            this.label7 = new global::System.Windows.Forms.Label();
            this.label10 = new global::System.Windows.Forms.Label();
            this.textBox7 = new global::System.Windows.Forms.TextBox();
            this.label11 = new global::System.Windows.Forms.Label();
            this.radioButton1 = new global::System.Windows.Forms.RadioButton();
            this.radioButton2 = new global::System.Windows.Forms.RadioButton();
            this.timer1 = new global::System.Windows.Forms.Timer(this.components);
            base.SuspendLayout();
            this.button1.Location = new global::System.Drawing.Point(85, 12);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(131, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "使用默认密钥读取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.button1_Click);
            this.button2.Location = new global::System.Drawing.Point(702, 13);
            this.button2.Name = "button2";
            this.button2.Size = new global::System.Drawing.Size(165, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "全加密卡破解密钥";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new global::System.EventHandler(this.button2_Click);
            this.button3.Location = new global::System.Drawing.Point(222, 13);
            this.button3.Name = "button3";
            this.button3.Size = new global::System.Drawing.Size(131, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "使用已知密钥读取";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new global::System.EventHandler(this.button3_Click);
            this.textBox1.BackColor = global::System.Drawing.Color.Black;
            this.textBox1.ForeColor = global::System.Drawing.Color.Lime;
            this.textBox1.Location = new global::System.Drawing.Point(12, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new global::System.Drawing.Size(647, 491);
            this.textBox1.TabIndex = 3;
            this.button7.Location = new global::System.Drawing.Point(85, 49);
            this.button7.Name = "button7";
            this.button7.Size = new global::System.Drawing.Size(131, 30);
            this.button7.TabIndex = 8;
            this.button7.Text = "写卡";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += (new global::System.EventHandler(this.button7_Click));
            this.label2.AutoSize = true;

            this.label2.ForeColor = global::System.Drawing.Color.Black;
            this.label2.Location = new global::System.Drawing.Point(84, 87);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(269, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "如果数据读取成功,数据将被自动保存为 key.dump\r\n写卡时,请先读卡!否则无法写入!";
            this.label4.AutoSize = true;
            this.label4.ForeColor = global::System.Drawing.Color.FromArgb(64, 64, 64);
            this.label4.Location = new global::System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(29, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "V1.0";
            this.pictureBox1.Image = global::全加密GUI.Properties.Resources.MIcon;
            this.pictureBox1.Location = new global::System.Drawing.Point(19, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new global::System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.button4.Location = new global::System.Drawing.Point(702, 49);
            this.button4.Name = "button4";
            this.button4.Size = new global::System.Drawing.Size(165, 30);
            this.button4.TabIndex = 13;
            this.button4.Text = "全部停止";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += (new global::System.EventHandler(this.button4_Click));
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(359, 22);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(59, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "已知密钥:";
            this.textBox2.Location = new global::System.Drawing.Point(424, 19);
            this.textBox2.MaxLength = 12;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new global::System.Drawing.Size(88, 21);
            this.textBox2.TabIndex = 15;
            this.label5.AutoSize = true;
            this.label5.Location = new global::System.Drawing.Point(223, 58);
            this.label5.Name = "label5";
            this.label5.Size = new global::System.Drawing.Size(59, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "写入数据:";
            this.textBox3.Location = new global::System.Drawing.Point(288, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new global::System.Drawing.Size(390, 21);
            this.textBox3.TabIndex = 17;
            this.button5.Location = new global::System.Drawing.Point(603, 13);
            this.button5.Name = "button5";
            this.button5.Size = new global::System.Drawing.Size(75, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "浏览...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += (new global::System.EventHandler(this.button5_Click));
            this.label6.AutoSize = true;
            this.label6.ForeColor = global::System.Drawing.Color.Red;
            this.label6.Location = new global::System.Drawing.Point(31, 96);
            this.label6.Name = "label6";
            this.label6.Size = new global::System.Drawing.Size(22, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "-";
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(680, 96);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(113, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "SLEEP_AT_FIELD_OFF";
            this.label8.AutoSize = true;
            this.label8.Location = new global::System.Drawing.Point(680, 124);
            this.label8.Name = "label8";
            this.label8.Size = new global::System.Drawing.Size(125, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "SLEEP_AFTER_FIELD_ON";
            this.textBox4.Location = new global::System.Drawing.Point(824, 93);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new global::System.Drawing.Size(49, 21);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "230";
            this.textBox5.Location = new global::System.Drawing.Point(824, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new global::System.Drawing.Size(49, 21);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "220";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[]
            {
                "0区",
                "1区",
                "2区",
                "3区",
                "4区",
                "5区",
                "6区",
                "7区",
                "8区",
                "9区",
                "10区",
                "11区",
                "12区",
                "13区",
                "14区",
                "15区",
                "0-15区"
            });
            this.comboBox1.Location = new global::System.Drawing.Point(824, 148);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new global::System.Drawing.Size(49, 20);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.SelectedIndexChanged += (new global::System.EventHandler(this.comboBox1_SelectedIndexChanged));
            this.label9.AutoSize = true;
            this.label9.Location = new global::System.Drawing.Point(680, 152);
            this.label9.Name = "label9";
            this.label9.Size = new global::System.Drawing.Size(143, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "选择获取密钥的区块号码:";
            this.textBox6.BackColor = global::System.Drawing.Color.Black;

            this.textBox6.ForeColor = global::System.Drawing.Color.Lime;
            this.textBox6.Location = new global::System.Drawing.Point(661, 307);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new global::System.Drawing.Size(212, 309);
            this.textBox6.TabIndex = 27;
            this.label7.Location = new global::System.Drawing.Point(665, 225);
            this.label7.Name = "label7";
            this.label7.Size = new global::System.Drawing.Size(208, 79);
            this.label7.TabIndex = 28;
            this.label7.Text = "使用[全加密卡破解密钥]时,如果长时间无信息显示,则密钥无法解...\r\n\r\n如果重复出现3次及以上次数,很可能为正确密钥,可以复制下来,用已知密钥读取来进行验证!";
            this.label10.AutoSize = true;
            this.label10.Location = new global::System.Drawing.Point(410, 96);
            this.label10.Name = "label10";
            this.label10.Size = new global::System.Drawing.Size(83, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "当前数据为0行";
            this.textBox7.Location = new global::System.Drawing.Point(525, 93);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new global::System.Drawing.Size(51, 21);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "99999";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox7.TextChanged += (new global::System.EventHandler(this.textBox7_TextChanged));
            this.label11.AutoSize = true;
            this.label11.Location = new global::System.Drawing.Point(582, 96);
            this.label11.Name = "label11";
            this.label11.Size = new global::System.Drawing.Size(77, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "行,自动清空!";
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new global::System.Drawing.Point(784, 178);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new global::System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.Text = "控制台显示";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new global::System.Drawing.Point(682, 178);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new global::System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "内置显示";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            this.timer1.Tick+=(new global::System.EventHandler(this.timer1_Tick));
            base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new global::System.Drawing.Size(889, 628);
            base.Controls.Add(this.radioButton2);
            base.Controls.Add(this.radioButton1);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.textBox7);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.textBox6);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.textBox5);
            base.Controls.Add(this.textBox4);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.button5);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.button4);
            base.Controls.Add(this.pictureBox1);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button7);
            base.Controls.Add(this.button3);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);

            base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
            base.MaximizeBox = false;
            base.Name = "main";
            this.RightToLeftLayout = true;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PN532 Fuck";
            base.FormClosing += (new global::System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing));
            base.Load += (new global::System.EventHandler(this.main_Load));
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        // Token: 0x04000007 RID: 7
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000008 RID: 8
        private global::System.Windows.Forms.Button button1;

        // Token: 0x04000009 RID: 9
        private global::System.Windows.Forms.Button button2;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Button button3;

        // Token: 0x0400000B RID: 11
        private global::System.Windows.Forms.TextBox textBox1;

        // Token: 0x0400000C RID: 12
        private global::System.Windows.Forms.Button button7;

        // Token: 0x0400000D RID: 13
        private global::System.Windows.Forms.Label label2;

        // Token: 0x0400000E RID: 14
        private global::System.Windows.Forms.Label label4;

        // Token: 0x0400000F RID: 15
        private global::System.Windows.Forms.PictureBox pictureBox1;

        // Token: 0x04000010 RID: 16
        private global::System.Windows.Forms.Button button4;

        // Token: 0x04000011 RID: 17
        private global::System.Windows.Forms.Label label1;

        // Token: 0x04000012 RID: 18
        private global::System.Windows.Forms.TextBox textBox2;

        // Token: 0x04000013 RID: 19
        private global::System.Windows.Forms.Label label5;

        // Token: 0x04000014 RID: 20
        private global::System.Windows.Forms.TextBox textBox3;

        // Token: 0x04000015 RID: 21
        private global::System.Windows.Forms.Button button5;

        // Token: 0x04000016 RID: 22
        private global::System.Windows.Forms.Label label6;

        // Token: 0x04000017 RID: 23
        private global::System.Windows.Forms.Label label3;

        // Token: 0x04000018 RID: 24
        private global::System.Windows.Forms.Label label8;

        // Token: 0x04000019 RID: 25
        private global::System.Windows.Forms.TextBox textBox4;

        // Token: 0x0400001A RID: 26
        private global::System.Windows.Forms.TextBox textBox5;

        // Token: 0x0400001B RID: 27
        private global::System.Windows.Forms.ComboBox comboBox1;

        // Token: 0x0400001C RID: 28
        private global::System.Windows.Forms.Label label9;

        // Token: 0x0400001D RID: 29
        private global::System.Windows.Forms.TextBox textBox6;

        // Token: 0x0400001E RID: 30
        private global::System.Windows.Forms.Label label7;

        // Token: 0x0400001F RID: 31
        private global::System.Windows.Forms.Label label10;

        // Token: 0x04000020 RID: 32
        private global::System.Windows.Forms.TextBox textBox7;

        // Token: 0x04000021 RID: 33
        private global::System.Windows.Forms.Label label11;

        // Token: 0x04000022 RID: 34
        private global::System.Windows.Forms.RadioButton radioButton1;

        // Token: 0x04000023 RID: 35
        private global::System.Windows.Forms.RadioButton radioButton2;

        // Token: 0x04000024 RID: 36
        private global::System.Windows.Forms.Timer timer1;
    }
}
