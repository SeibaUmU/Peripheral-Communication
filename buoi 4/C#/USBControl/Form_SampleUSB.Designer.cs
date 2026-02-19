namespace USBControl
{
    partial class Form_SampleUSB
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
            this.groupBox_DeviceInfor = new System.Windows.Forms.GroupBox();
            this.textBox_PN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_VN = new System.Windows.Forms.TextBox();
            this.textBox_PID = new System.Windows.Forms.TextBox();
            this.textBox_VID = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_SWStat = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SW2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_SW1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SW0 = new System.Windows.Forms.TextBox();
            this.groupBox_LEDCtrl = new System.Windows.Forms.GroupBox();
            this.checkBox_LED8 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED7 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED6 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED5 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED4 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED3 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED2 = new System.Windows.Forms.CheckBox();
            this.checkBox_LED1 = new System.Windows.Forms.CheckBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip_InforDevice = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_InforDevice = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox_DeviceInfor.SuspendLayout();
            this.groupBox_SWStat.SuspendLayout();
            this.groupBox_LEDCtrl.SuspendLayout();
            this.statusStrip_InforDevice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "USB (HID) Communication Lab";
            // 
            // groupBox_DeviceInfor
            // 
            this.groupBox_DeviceInfor.Controls.Add(this.textBox_PN);
            this.groupBox_DeviceInfor.Controls.Add(this.label4);
            this.groupBox_DeviceInfor.Controls.Add(this.label3);
            this.groupBox_DeviceInfor.Controls.Add(this.textBox_VN);
            this.groupBox_DeviceInfor.Controls.Add(this.textBox_PID);
            this.groupBox_DeviceInfor.Controls.Add(this.textBox_VID);
            this.groupBox_DeviceInfor.Controls.Add(this.textBox_Status);
            this.groupBox_DeviceInfor.Controls.Add(this.label13);
            this.groupBox_DeviceInfor.Controls.Add(this.label12);
            this.groupBox_DeviceInfor.Controls.Add(this.label11);
            this.groupBox_DeviceInfor.Controls.Add(this.label10);
            this.groupBox_DeviceInfor.Controls.Add(this.label9);
            this.groupBox_DeviceInfor.Location = new System.Drawing.Point(12, 64);
            this.groupBox_DeviceInfor.Name = "groupBox_DeviceInfor";
            this.groupBox_DeviceInfor.Size = new System.Drawing.Size(386, 273);
            this.groupBox_DeviceInfor.TabIndex = 1;
            this.groupBox_DeviceInfor.TabStop = false;
            this.groupBox_DeviceInfor.Text = "Device Information";
            // 
            // textBox_PN
            // 
            this.textBox_PN.BackColor = System.Drawing.Color.White;
            this.textBox_PN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PN.Location = new System.Drawing.Point(157, 191);
            this.textBox_PN.Name = "textBox_PN";
            this.textBox_PN.ReadOnly = true;
            this.textBox_PN.Size = new System.Drawing.Size(190, 23);
            this.textBox_PN.TabIndex = 16;
            this.textBox_PN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "for PIC18F4550";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "for Microchip";
            // 
            // textBox_VN
            // 
            this.textBox_VN.BackColor = System.Drawing.Color.White;
            this.textBox_VN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VN.Location = new System.Drawing.Point(157, 150);
            this.textBox_VN.Name = "textBox_VN";
            this.textBox_VN.ReadOnly = true;
            this.textBox_VN.Size = new System.Drawing.Size(190, 23);
            this.textBox_VN.TabIndex = 12;
            this.textBox_VN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_PID
            // 
            this.textBox_PID.BackColor = System.Drawing.Color.White;
            this.textBox_PID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PID.Location = new System.Drawing.Point(157, 108);
            this.textBox_PID.Name = "textBox_PID";
            this.textBox_PID.ReadOnly = true;
            this.textBox_PID.Size = new System.Drawing.Size(64, 23);
            this.textBox_PID.TabIndex = 11;
            this.textBox_PID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_VID
            // 
            this.textBox_VID.BackColor = System.Drawing.Color.White;
            this.textBox_VID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_VID.Location = new System.Drawing.Point(157, 71);
            this.textBox_VID.Name = "textBox_VID";
            this.textBox_VID.ReadOnly = true;
            this.textBox_VID.Size = new System.Drawing.Size(64, 23);
            this.textBox_VID.TabIndex = 10;
            this.textBox_VID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Status
            // 
            this.textBox_Status.BackColor = System.Drawing.Color.Red;
            this.textBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Status.Location = new System.Drawing.Point(157, 34);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(115, 23);
            this.textBox_Status.TabIndex = 9;
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(18, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Product Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Vendor Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Product ID (HEX)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Vendor ID (HEX)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Device Status";
            // 
            // groupBox_SWStat
            // 
            this.groupBox_SWStat.Controls.Add(this.label6);
            this.groupBox_SWStat.Controls.Add(this.textBox_SW2);
            this.groupBox_SWStat.Controls.Add(this.label2);
            this.groupBox_SWStat.Controls.Add(this.textBox_SW1);
            this.groupBox_SWStat.Controls.Add(this.label5);
            this.groupBox_SWStat.Controls.Add(this.textBox_SW0);
            this.groupBox_SWStat.Location = new System.Drawing.Point(418, 214);
            this.groupBox_SWStat.Name = "groupBox_SWStat";
            this.groupBox_SWStat.Size = new System.Drawing.Size(222, 123);
            this.groupBox_SWStat.TabIndex = 2;
            this.groupBox_SWStat.TabStop = false;
            this.groupBox_SWStat.Text = "Switch Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Counter (SW2)";
            // 
            // textBox_SW2
            // 
            this.textBox_SW2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_SW2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW2.Location = new System.Drawing.Point(143, 88);
            this.textBox_SW2.Name = "textBox_SW2";
            this.textBox_SW2.ReadOnly = true;
            this.textBox_SW2.Size = new System.Drawing.Size(59, 23);
            this.textBox_SW2.TabIndex = 6;
            this.textBox_SW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Counter (SW1)";
            // 
            // textBox_SW1
            // 
            this.textBox_SW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_SW1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW1.Location = new System.Drawing.Point(143, 53);
            this.textBox_SW1.Name = "textBox_SW1";
            this.textBox_SW1.ReadOnly = true;
            this.textBox_SW1.Size = new System.Drawing.Size(59, 23);
            this.textBox_SW1.TabIndex = 4;
            this.textBox_SW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Counter (SW0)";
            // 
            // textBox_SW0
            // 
            this.textBox_SW0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_SW0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_SW0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW0.Location = new System.Drawing.Point(143, 21);
            this.textBox_SW0.Name = "textBox_SW0";
            this.textBox_SW0.ReadOnly = true;
            this.textBox_SW0.Size = new System.Drawing.Size(59, 23);
            this.textBox_SW0.TabIndex = 0;
            this.textBox_SW0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox_LEDCtrl
            // 
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED8);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED7);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED6);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED5);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED4);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED3);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED2);
            this.groupBox_LEDCtrl.Controls.Add(this.checkBox_LED1);
            this.groupBox_LEDCtrl.Location = new System.Drawing.Point(418, 64);
            this.groupBox_LEDCtrl.Name = "groupBox_LEDCtrl";
            this.groupBox_LEDCtrl.Size = new System.Drawing.Size(222, 145);
            this.groupBox_LEDCtrl.TabIndex = 2;
            this.groupBox_LEDCtrl.TabStop = false;
            this.groupBox_LEDCtrl.Text = "LED Control";
            // 
            // checkBox_LED8
            // 
            this.checkBox_LED8.AutoSize = true;
            this.checkBox_LED8.Location = new System.Drawing.Point(140, 108);
            this.checkBox_LED8.Name = "checkBox_LED8";
            this.checkBox_LED8.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED8.TabIndex = 12;
            this.checkBox_LED8.Text = "LED8";
            this.checkBox_LED8.UseVisualStyleBackColor = true;
            this.checkBox_LED8.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED7
            // 
            this.checkBox_LED7.AutoSize = true;
            this.checkBox_LED7.Location = new System.Drawing.Point(140, 84);
            this.checkBox_LED7.Name = "checkBox_LED7";
            this.checkBox_LED7.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED7.TabIndex = 11;
            this.checkBox_LED7.Text = "LED7";
            this.checkBox_LED7.UseVisualStyleBackColor = true;
            this.checkBox_LED7.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED6
            // 
            this.checkBox_LED6.AutoSize = true;
            this.checkBox_LED6.Location = new System.Drawing.Point(140, 60);
            this.checkBox_LED6.Name = "checkBox_LED6";
            this.checkBox_LED6.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED6.TabIndex = 10;
            this.checkBox_LED6.Text = "LED6";
            this.checkBox_LED6.UseVisualStyleBackColor = true;
            this.checkBox_LED6.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED5
            // 
            this.checkBox_LED5.AutoSize = true;
            this.checkBox_LED5.Location = new System.Drawing.Point(140, 34);
            this.checkBox_LED5.Name = "checkBox_LED5";
            this.checkBox_LED5.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED5.TabIndex = 9;
            this.checkBox_LED5.Text = "LED5";
            this.checkBox_LED5.UseVisualStyleBackColor = true;
            this.checkBox_LED5.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED4
            // 
            this.checkBox_LED4.AutoSize = true;
            this.checkBox_LED4.Location = new System.Drawing.Point(39, 106);
            this.checkBox_LED4.Name = "checkBox_LED4";
            this.checkBox_LED4.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED4.TabIndex = 8;
            this.checkBox_LED4.Text = "LED4";
            this.checkBox_LED4.UseVisualStyleBackColor = true;
            this.checkBox_LED4.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED3
            // 
            this.checkBox_LED3.AutoSize = true;
            this.checkBox_LED3.Location = new System.Drawing.Point(39, 84);
            this.checkBox_LED3.Name = "checkBox_LED3";
            this.checkBox_LED3.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED3.TabIndex = 7;
            this.checkBox_LED3.Text = "LED3";
            this.checkBox_LED3.UseVisualStyleBackColor = true;
            this.checkBox_LED3.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED2
            // 
            this.checkBox_LED2.AutoSize = true;
            this.checkBox_LED2.Location = new System.Drawing.Point(39, 58);
            this.checkBox_LED2.Name = "checkBox_LED2";
            this.checkBox_LED2.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED2.TabIndex = 6;
            this.checkBox_LED2.Text = "LED2";
            this.checkBox_LED2.UseVisualStyleBackColor = true;
            this.checkBox_LED2.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // checkBox_LED1
            // 
            this.checkBox_LED1.AutoSize = true;
            this.checkBox_LED1.Location = new System.Drawing.Point(39, 32);
            this.checkBox_LED1.Name = "checkBox_LED1";
            this.checkBox_LED1.Size = new System.Drawing.Size(62, 20);
            this.checkBox_LED1.TabIndex = 5;
            this.checkBox_LED1.Text = "LED1";
            this.checkBox_LED1.UseVisualStyleBackColor = true;
            this.checkBox_LED1.CheckedChanged += new System.EventHandler(this.SendLedData);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Exit.Location = new System.Drawing.Point(12, 343);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(143, 39);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Exit Program";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(494, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Design by Seiba";
            // 
            // statusStrip_InforDevice
            // 
            this.statusStrip_InforDevice.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip_InforDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_InforDevice});
            this.statusStrip_InforDevice.Location = new System.Drawing.Point(0, 389);
            this.statusStrip_InforDevice.Name = "statusStrip_InforDevice";
            this.statusStrip_InforDevice.Size = new System.Drawing.Size(651, 26);
            this.statusStrip_InforDevice.TabIndex = 4;
            this.statusStrip_InforDevice.Text = "statusStrip_InforDevice";
            // 
            // toolStripStatusLabel_InforDevice
            // 
            this.toolStripStatusLabel_InforDevice.Name = "toolStripStatusLabel_InforDevice";
            this.toolStripStatusLabel_InforDevice.Size = new System.Drawing.Size(130, 20);
            this.toolStripStatusLabel_InforDevice.Text = "USB Disconnected";
            // 
            // Form_SampleUSB
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(651, 415);
            this.Controls.Add(this.statusStrip_InforDevice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox_SWStat);
            this.Controls.Add(this.groupBox_LEDCtrl);
            this.Controls.Add(this.groupBox_DeviceInfor);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_SampleUSB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HID - USB Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_DeviceInfor.ResumeLayout(false);
            this.groupBox_DeviceInfor.PerformLayout();
            this.groupBox_SWStat.ResumeLayout(false);
            this.groupBox_SWStat.PerformLayout();
            this.groupBox_LEDCtrl.ResumeLayout(false);
            this.groupBox_LEDCtrl.PerformLayout();
            this.statusStrip_InforDevice.ResumeLayout(false);
            this.statusStrip_InforDevice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_DeviceInfor;
        private System.Windows.Forms.GroupBox groupBox_SWStat;
        private System.Windows.Forms.GroupBox groupBox_LEDCtrl;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_SW0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_VN;
        private System.Windows.Forms.TextBox textBox_PID;
        private System.Windows.Forms.TextBox textBox_VID;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_PN;
        private System.Windows.Forms.StatusStrip statusStrip_InforDevice;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_InforDevice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SW2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SW1;
        private System.Windows.Forms.CheckBox checkBox_LED1;
        private System.Windows.Forms.CheckBox checkBox_LED8;
        private System.Windows.Forms.CheckBox checkBox_LED7;
        private System.Windows.Forms.CheckBox checkBox_LED6;
        private System.Windows.Forms.CheckBox checkBox_LED5;
        private System.Windows.Forms.CheckBox checkBox_LED4;
        private System.Windows.Forms.CheckBox checkBox_LED3;
        private System.Windows.Forms.CheckBox checkBox_LED2;
    }
}

