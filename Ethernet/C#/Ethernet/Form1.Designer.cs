namespace Ethernet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_DisConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.textBox_ServerIP_2 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_3 = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_4 = new System.Windows.Forms.TextBox();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_ServerIP_1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SW0 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_L2_OFF = new System.Windows.Forms.Button();
            this.btn_L2_ON = new System.Windows.Forms.Button();
            this.btn_L1_OFF = new System.Windows.Forms.Button();
            this.btn_L1_ON = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_L0_OFF = new System.Windows.Forms.Button();
            this.btn_L0_ON = new System.Windows.Forms.Button();
            this.textBox_SW1 = new System.Windows.Forms.TextBox();
            this.textBox_SW2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(526, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ETHERNET COMMUNICATION - SERVER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_DisConnect);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button_Connect);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_2);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_3);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_4);
            this.groupBox1.Controls.Add(this.textBox_ServerPort);
            this.groupBox1.Controls.Add(this.textBox_Status);
            this.groupBox1.Controls.Add(this.textBox_ServerIP_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 258);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setup";
            // 
            // button_DisConnect
            // 
            this.button_DisConnect.Enabled = false;
            this.button_DisConnect.Location = new System.Drawing.Point(182, 142);
            this.button_DisConnect.Name = "button_DisConnect";
            this.button_DisConnect.Size = new System.Drawing.Size(131, 36);
            this.button_DisConnect.TabIndex = 13;
            this.button_DisConnect.Text = "Disconnect";
            this.button_DisConnect.UseVisualStyleBackColor = true;
            this.button_DisConnect.Click += new System.EventHandler(this.button_DisConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(25, 142);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(131, 36);
            this.button_Connect.TabIndex = 7;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // textBox_ServerIP_2
            // 
            this.textBox_ServerIP_2.Location = new System.Drawing.Point(143, 40);
            this.textBox_ServerIP_2.Name = "textBox_ServerIP_2";
            this.textBox_ServerIP_2.Size = new System.Drawing.Size(62, 22);
            this.textBox_ServerIP_2.TabIndex = 10;
            this.textBox_ServerIP_2.Text = "168";
            this.textBox_ServerIP_2.Validated += new System.EventHandler(this.textBox_ServerIP_2_Validated);
            // 
            // textBox_ServerIP_3
            // 
            this.textBox_ServerIP_3.Location = new System.Drawing.Point(211, 40);
            this.textBox_ServerIP_3.Name = "textBox_ServerIP_3";
            this.textBox_ServerIP_3.Size = new System.Drawing.Size(55, 22);
            this.textBox_ServerIP_3.TabIndex = 9;
            this.textBox_ServerIP_3.Text = "1";
            this.textBox_ServerIP_3.Validated += new System.EventHandler(this.textBox_ServerIP_3_Validated);
            // 
            // textBox_ServerIP_4
            // 
            this.textBox_ServerIP_4.Location = new System.Drawing.Point(272, 40);
            this.textBox_ServerIP_4.Name = "textBox_ServerIP_4";
            this.textBox_ServerIP_4.Size = new System.Drawing.Size(55, 22);
            this.textBox_ServerIP_4.TabIndex = 8;
            this.textBox_ServerIP_4.Text = "200";
            this.textBox_ServerIP_4.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox_ServerIP_4.Validated += new System.EventHandler(this.textBox_ServerIP_4_Validated);
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Location = new System.Drawing.Point(86, 78);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.Size = new System.Drawing.Size(100, 22);
            this.textBox_ServerPort.TabIndex = 7;
            this.textBox_ServerPort.Text = "8001";
            this.textBox_ServerPort.Validated += new System.EventHandler(this.textBox_ServerPort_Validated);
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(25, 206);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(288, 22);
            this.textBox_Status.TabIndex = 6;
            // 
            // textBox_ServerIP_1
            // 
            this.textBox_ServerIP_1.Location = new System.Drawing.Point(78, 40);
            this.textBox_ServerIP_1.Name = "textBox_ServerIP_1";
            this.textBox_ServerIP_1.Size = new System.Drawing.Size(59, 22);
            this.textBox_ServerIP_1.TabIndex = 4;
            this.textBox_ServerIP_1.Text = "192";
            this.textBox_ServerIP_1.Validated += new System.EventHandler(this.textBox_ServerIP_1_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SW2);
            this.groupBox2.Controls.Add(this.textBox_SW1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_SW0);
            this.groupBox2.Location = new System.Drawing.Point(354, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Counter SW2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Counter SW1";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Counter SW0";
            // 
            // textBox_SW0
            // 
            this.textBox_SW0.Location = new System.Drawing.Point(165, 15);
            this.textBox_SW0.Name = "textBox_SW0";
            this.textBox_SW0.ReadOnly = true;
            this.textBox_SW0.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW0.TabIndex = 5;
            this.textBox_SW0.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_L2_OFF);
            this.groupBox3.Controls.Add(this.btn_L2_ON);
            this.groupBox3.Controls.Add(this.btn_L1_OFF);
            this.groupBox3.Controls.Add(this.btn_L1_ON);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btn_L0_OFF);
            this.groupBox3.Controls.Add(this.btn_L0_ON);
            this.groupBox3.Location = new System.Drawing.Point(354, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 152);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Led status";
            // 
            // btn_L2_OFF
            // 
            this.btn_L2_OFF.Location = new System.Drawing.Point(190, 99);
            this.btn_L2_OFF.Name = "btn_L2_OFF";
            this.btn_L2_OFF.Size = new System.Drawing.Size(75, 23);
            this.btn_L2_OFF.TabIndex = 16;
            this.btn_L2_OFF.Text = "OFF";
            this.btn_L2_OFF.UseVisualStyleBackColor = true;
            this.btn_L2_OFF.Click += new System.EventHandler(this.btn_L2_OFF_Click);
            // 
            // btn_L2_ON
            // 
            this.btn_L2_ON.Location = new System.Drawing.Point(190, 58);
            this.btn_L2_ON.Name = "btn_L2_ON";
            this.btn_L2_ON.Size = new System.Drawing.Size(75, 23);
            this.btn_L2_ON.TabIndex = 15;
            this.btn_L2_ON.Text = "ON";
            this.btn_L2_ON.UseVisualStyleBackColor = true;
            this.btn_L2_ON.Click += new System.EventHandler(this.btn_L2_ON_Click);
            // 
            // btn_L1_OFF
            // 
            this.btn_L1_OFF.Location = new System.Drawing.Point(97, 99);
            this.btn_L1_OFF.Name = "btn_L1_OFF";
            this.btn_L1_OFF.Size = new System.Drawing.Size(75, 23);
            this.btn_L1_OFF.TabIndex = 14;
            this.btn_L1_OFF.Text = "OFF";
            this.btn_L1_OFF.UseVisualStyleBackColor = true;
            this.btn_L1_OFF.Click += new System.EventHandler(this.btn_L1_OFF_Click);
            // 
            // btn_L1_ON
            // 
            this.btn_L1_ON.Location = new System.Drawing.Point(97, 58);
            this.btn_L1_ON.Name = "btn_L1_ON";
            this.btn_L1_ON.Size = new System.Drawing.Size(75, 23);
            this.btn_L1_ON.TabIndex = 13;
            this.btn_L1_ON.Text = "ON";
            this.btn_L1_ON.UseVisualStyleBackColor = true;
            this.btn_L1_ON.Click += new System.EventHandler(this.btn_L1_ON_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "LED2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "LED1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "LED0";
            // 
            // btn_L0_OFF
            // 
            this.btn_L0_OFF.Enabled = false;
            this.btn_L0_OFF.Location = new System.Drawing.Point(6, 99);
            this.btn_L0_OFF.Name = "btn_L0_OFF";
            this.btn_L0_OFF.Size = new System.Drawing.Size(75, 23);
            this.btn_L0_OFF.TabIndex = 5;
            this.btn_L0_OFF.Text = "OFF";
            this.btn_L0_OFF.UseVisualStyleBackColor = true;
            this.btn_L0_OFF.Click += new System.EventHandler(this.btn_L0_OFF_Click);
            // 
            // btn_L0_ON
            // 
            this.btn_L0_ON.Enabled = false;
            this.btn_L0_ON.Location = new System.Drawing.Point(6, 58);
            this.btn_L0_ON.Name = "btn_L0_ON";
            this.btn_L0_ON.Size = new System.Drawing.Size(75, 23);
            this.btn_L0_ON.TabIndex = 4;
            this.btn_L0_ON.Text = "ON";
            this.btn_L0_ON.UseVisualStyleBackColor = true;
            this.btn_L0_ON.Click += new System.EventHandler(this.btn_L0_ON_Click);
            // 
            // textBox_SW1
            // 
            this.textBox_SW1.Location = new System.Drawing.Point(165, 43);
            this.textBox_SW1.Name = "textBox_SW1";
            this.textBox_SW1.ReadOnly = true;
            this.textBox_SW1.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW1.TabIndex = 12;
            this.textBox_SW1.Text = "0";
            // 
            // textBox_SW2
            // 
            this.textBox_SW2.Location = new System.Drawing.Point(165, 71);
            this.textBox_SW2.Name = "textBox_SW2";
            this.textBox_SW2.ReadOnly = true;
            this.textBox_SW2.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW2.TabIndex = 13;
            this.textBox_SW2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 349);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ethernet Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_ServerIP_1;
        private System.Windows.Forms.TextBox textBox_ServerIP_2;
        private System.Windows.Forms.TextBox textBox_ServerIP_3;
        private System.Windows.Forms.TextBox textBox_ServerIP_4;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_SW0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_L0_OFF;
        private System.Windows.Forms.Button btn_L0_ON;
        private System.Windows.Forms.Button button_DisConnect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_L2_OFF;
        private System.Windows.Forms.Button btn_L2_ON;
        private System.Windows.Forms.Button btn_L1_OFF;
        private System.Windows.Forms.Button btn_L1_ON;
        private System.Windows.Forms.TextBox textBox_SW2;
        private System.Windows.Forms.TextBox textBox_SW1;
    }
}

