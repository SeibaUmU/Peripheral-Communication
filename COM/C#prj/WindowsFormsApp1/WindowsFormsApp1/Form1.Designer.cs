namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_COMPort = new System.Windows.Forms.ComboBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_SW2 = new System.Windows.Forms.TextBox();
            this.textBox_SW1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_SW = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_OFF2 = new System.Windows.Forms.Button();
            this.button_ON2 = new System.Windows.Forms.Button();
            this.button_OFF1 = new System.Windows.Forms.Button();
            this.button_ON1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button_OFF = new System.Windows.Forms.Button();
            this.button_ON = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.ovalShape_LED2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape_LED1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ovalShape_LED = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox_DataSend = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_DataSend = new System.Windows.Forms.TextBox();
            this.textBox_DataReceive = new System.Windows.Forms.TextBox();
            this.button_DataSend = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS232 (COM) COMMUNICATION LAB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(842, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Designed by Seiba";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_COMPort);
            this.groupBox1.Controls.Add(this.textBox_Status);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_BaudRate);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(267, 288);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setup";
            // 
            // comboBox_COMPort
            // 
            this.comboBox_COMPort.FormattingEnabled = true;
            this.comboBox_COMPort.Location = new System.Drawing.Point(104, 33);
            this.comboBox_COMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_COMPort.Name = "comboBox_COMPort";
            this.comboBox_COMPort.Size = new System.Drawing.Size(152, 24);
            this.comboBox_COMPort.TabIndex = 9;
            this.comboBox_COMPort.SelectedIndexChanged += new System.EventHandler(this.comboBox_COMPort_SelectedIndexChanged);
            // 
            // textBox_Status
            // 
            this.textBox_Status.BackColor = System.Drawing.Color.Red;
            this.textBox_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Status.Location = new System.Drawing.Point(35, 148);
            this.textBox_Status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(188, 28);
            this.textBox_Status.TabIndex = 8;
            this.textBox_Status.Tag = "";
            this.textBox_Status.Text = "Disconnected!";
            this.textBox_Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 231);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 7;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM Port";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(104, 63);
            this.comboBox_BaudRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(152, 24);
            this.comboBox_BaudRate.TabIndex = 4;
            this.comboBox_BaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBox_BaudRate_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_SW2);
            this.groupBox2.Controls.Add(this.textBox_SW1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_SW);
            this.groupBox2.Location = new System.Drawing.Point(285, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(381, 130);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch Status";
            // 
            // textBox_SW2
            // 
            this.textBox_SW2.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_SW2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW2.Location = new System.Drawing.Point(249, 91);
            this.textBox_SW2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SW2.Name = "textBox_SW2";
            this.textBox_SW2.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW2.TabIndex = 11;
            this.textBox_SW2.Text = "0";
            this.textBox_SW2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_SW1
            // 
            this.textBox_SW1.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_SW1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW1.Location = new System.Drawing.Point(249, 60);
            this.textBox_SW1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SW1.Name = "textBox_SW1";
            this.textBox_SW1.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW1.TabIndex = 10;
            this.textBox_SW1.Text = "0";
            this.textBox_SW1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Counter (SW2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Counter (SW1)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Counter (SW0)";
            // 
            // textBox_SW
            // 
            this.textBox_SW.BackColor = System.Drawing.SystemColors.Highlight;
            this.textBox_SW.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SW.Location = new System.Drawing.Point(249, 30);
            this.textBox_SW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_SW.Name = "textBox_SW";
            this.textBox_SW.Size = new System.Drawing.Size(100, 22);
            this.textBox_SW.TabIndex = 7;
            this.textBox_SW.Text = "0";
            this.textBox_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.button_OFF2);
            this.groupBox3.Controls.Add(this.button_ON2);
            this.groupBox3.Controls.Add(this.button_OFF1);
            this.groupBox3.Controls.Add(this.button_ON1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button_OFF);
            this.groupBox3.Controls.Add(this.button_ON);
            this.groupBox3.Controls.Add(this.shapeContainer1);
            this.groupBox3.Location = new System.Drawing.Point(294, 207);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(688, 140);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LED Control";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(480, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 16);
            this.label12.TabIndex = 14;
            this.label12.Text = "LED2 On/Off";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(245, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "LED1 On/Off";
            // 
            // button_OFF2
            // 
            this.button_OFF2.Location = new System.Drawing.Point(565, 84);
            this.button_OFF2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OFF2.Name = "button_OFF2";
            this.button_OFF2.Size = new System.Drawing.Size(116, 39);
            this.button_OFF2.TabIndex = 12;
            this.button_OFF2.Text = "OFF";
            this.button_OFF2.UseVisualStyleBackColor = true;
            this.button_OFF2.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // button_ON2
            // 
            this.button_ON2.Location = new System.Drawing.Point(565, 38);
            this.button_ON2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ON2.Name = "button_ON2";
            this.button_ON2.Size = new System.Drawing.Size(116, 39);
            this.button_ON2.TabIndex = 11;
            this.button_ON2.Text = "ON";
            this.button_ON2.UseVisualStyleBackColor = true;
            this.button_ON2.Click += new System.EventHandler(this.button_ON_Click);
            // 
            // button_OFF1
            // 
            this.button_OFF1.Location = new System.Drawing.Point(336, 84);
            this.button_OFF1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OFF1.Name = "button_OFF1";
            this.button_OFF1.Size = new System.Drawing.Size(116, 39);
            this.button_OFF1.TabIndex = 10;
            this.button_OFF1.Text = "OFF";
            this.button_OFF1.UseVisualStyleBackColor = true;
            this.button_OFF1.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // button_ON1
            // 
            this.button_ON1.Location = new System.Drawing.Point(336, 38);
            this.button_ON1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ON1.Name = "button_ON1";
            this.button_ON1.Size = new System.Drawing.Size(116, 39);
            this.button_ON1.TabIndex = 9;
            this.button_ON1.Text = "ON";
            this.button_ON1.UseVisualStyleBackColor = true;
            this.button_ON1.Click += new System.EventHandler(this.button_ON_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "LED0 On/Off";
            // 
            // button_OFF
            // 
            this.button_OFF.Location = new System.Drawing.Point(104, 84);
            this.button_OFF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OFF.Name = "button_OFF";
            this.button_OFF.Size = new System.Drawing.Size(116, 39);
            this.button_OFF.TabIndex = 5;
            this.button_OFF.Text = "OFF";
            this.button_OFF.UseVisualStyleBackColor = true;
            this.button_OFF.Click += new System.EventHandler(this.button_OFF_Click);
            // 
            // button_ON
            // 
            this.button_ON.Location = new System.Drawing.Point(104, 38);
            this.button_ON.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ON.Name = "button_ON";
            this.button_ON.Size = new System.Drawing.Size(116, 39);
            this.button_ON.TabIndex = 4;
            this.button_ON.Text = "ON";
            this.button_ON.UseVisualStyleBackColor = true;
            this.button_ON.Click += new System.EventHandler(this.button_ON_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 17);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.ovalShape_LED2,
            this.ovalShape_LED1,
            this.ovalShape_LED});
            this.shapeContainer1.Size = new System.Drawing.Size(682, 121);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // ovalShape_LED2
            // 
            this.ovalShape_LED2.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_LED2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape_LED2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ovalShape_LED2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_LED2.Location = new System.Drawing.Point(493, 46);
            this.ovalShape_LED2.Name = "ovalShape_LED2";
            this.ovalShape_LED2.Size = new System.Drawing.Size(46, 47);
            // 
            // ovalShape_LED1
            // 
            this.ovalShape_LED1.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_LED1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape_LED1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ovalShape_LED1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_LED1.Location = new System.Drawing.Point(259, 45);
            this.ovalShape_LED1.Name = "ovalShape_LED1";
            this.ovalShape_LED1.Size = new System.Drawing.Size(46, 47);
            // 
            // ovalShape_LED
            // 
            this.ovalShape_LED.BackColor = System.Drawing.SystemColors.Control;
            this.ovalShape_LED.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.ovalShape_LED.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.ovalShape_LED.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ovalShape_LED.Location = new System.Drawing.Point(26, 45);
            this.ovalShape_LED.Name = "ovalShape_LED";
            this.ovalShape_LED.Size = new System.Drawing.Size(46, 47);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox_DataSend);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textbox_DataSend);
            this.groupBox4.Controls.Add(this.textBox_DataReceive);
            this.groupBox4.Location = new System.Drawing.Point(682, 59);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(293, 87);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Data Send/Receive";
            // 
            // checkBox_DataSend
            // 
            this.checkBox_DataSend.AutoSize = true;
            this.checkBox_DataSend.FlatAppearance.BorderSize = 3;
            this.checkBox_DataSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox_DataSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_DataSend.Location = new System.Drawing.Point(115, 30);
            this.checkBox_DataSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_DataSend.Name = "checkBox_DataSend";
            this.checkBox_DataSend.Size = new System.Drawing.Size(15, 14);
            this.checkBox_DataSend.TabIndex = 6;
            this.checkBox_DataSend.UseVisualStyleBackColor = true;
            this.checkBox_DataSend.CheckedChanged += new System.EventHandler(this.checkBox_DataSend_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Send";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Receive";
            // 
            // textbox_DataSend
            // 
            this.textbox_DataSend.Location = new System.Drawing.Point(135, 27);
            this.textbox_DataSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_DataSend.Name = "textbox_DataSend";
            this.textbox_DataSend.Size = new System.Drawing.Size(135, 22);
            this.textbox_DataSend.TabIndex = 9;
            // 
            // textBox_DataReceive
            // 
            this.textBox_DataReceive.Location = new System.Drawing.Point(135, 55);
            this.textBox_DataReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_DataReceive.Name = "textBox_DataReceive";
            this.textBox_DataReceive.Size = new System.Drawing.Size(135, 22);
            this.textBox_DataReceive.TabIndex = 11;
            // 
            // button_DataSend
            // 
            this.button_DataSend.Location = new System.Drawing.Point(682, 156);
            this.button_DataSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_DataSend.Name = "button_DataSend";
            this.button_DataSend.Size = new System.Drawing.Size(116, 39);
            this.button_DataSend.TabIndex = 4;
            this.button_DataSend.Text = "Send";
            this.button_DataSend.UseVisualStyleBackColor = true;
            this.button_DataSend.Click += new System.EventHandler(this.button_Send_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(863, 156);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(116, 39);
            this.button6.TabIndex = 5;
            this.button6.Text = "Exit Program";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Serial_Port
            // 
            this.Serial_Port.DtrEnable = true;
            this.Serial_Port.RtsEnable = true;
            this.Serial_Port.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Serial_Port_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(996, 382);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button_DataSend);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RS232 COM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.Button button_OFF;
        private System.Windows.Forms.Button button_ON;
        private System.Windows.Forms.Button button_DataSend;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_SW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textbox_DataSend;
        private System.Windows.Forms.TextBox textBox_DataReceive;
        private System.Windows.Forms.CheckBox checkBox_DataSend;
        private System.IO.Ports.SerialPort Serial_Port;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_LED;
        private System.Windows.Forms.ComboBox comboBox_COMPort;
        private System.Windows.Forms.TextBox textBox_SW2;
        private System.Windows.Forms.TextBox textBox_SW1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_OFF2;
        private System.Windows.Forms.Button button_ON2;
        private System.Windows.Forms.Button button_OFF1;
        private System.Windows.Forms.Button button_ON1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_LED2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape ovalShape_LED1;
    }
}

