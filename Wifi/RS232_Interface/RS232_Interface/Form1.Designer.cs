namespace RS232_Interface
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
            this.box_comunication_setup = new System.Windows.Forms.GroupBox();
            this.box_status_port = new System.Windows.Forms.TextBox();
            this.box_baud_rate = new System.Windows.Forms.ComboBox();
            this.box_com_port = new System.Windows.Forms.ComboBox();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_switch_status = new System.Windows.Forms.GroupBox();
            this.box_count_switch2 = new System.Windows.Forms.TextBox();
            this.box_count_switch1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.box_count_switch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_data_send_receive = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.box_receive = new System.Windows.Forms.TextBox();
            this.box_send = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.box_led_control = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_off = new System.Windows.Forms.Button();
            this.button_on = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_exit_program = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.box_led_control2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_off2 = new System.Windows.Forms.Button();
            this.button_on2 = new System.Windows.Forms.Button();
            this.box_led_control1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_off1 = new System.Windows.Forms.Button();
            this.button_on1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.box_comunication_setup.SuspendLayout();
            this.box_switch_status.SuspendLayout();
            this.box_data_send_receive.SuspendLayout();
            this.box_led_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.box_led_control2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.box_led_control1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // box_comunication_setup
            // 
            this.box_comunication_setup.Controls.Add(this.box_status_port);
            this.box_comunication_setup.Controls.Add(this.box_baud_rate);
            this.box_comunication_setup.Controls.Add(this.box_com_port);
            this.box_comunication_setup.Controls.Add(this.button_disconnect);
            this.box_comunication_setup.Controls.Add(this.button_connect);
            this.box_comunication_setup.Controls.Add(this.label3);
            this.box_comunication_setup.Controls.Add(this.label2);
            this.box_comunication_setup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_comunication_setup.Location = new System.Drawing.Point(12, 34);
            this.box_comunication_setup.Name = "box_comunication_setup";
            this.box_comunication_setup.Size = new System.Drawing.Size(252, 215);
            this.box_comunication_setup.TabIndex = 0;
            this.box_comunication_setup.TabStop = false;
            this.box_comunication_setup.Text = "Comunication Setup";
            // 
            // box_status_port
            // 
            this.box_status_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.box_status_port.Location = new System.Drawing.Point(40, 124);
            this.box_status_port.Name = "box_status_port";
            this.box_status_port.Size = new System.Drawing.Size(153, 26);
            this.box_status_port.TabIndex = 10;
            this.box_status_port.Text = "Disconnect";
            this.box_status_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box_baud_rate
            // 
            this.box_baud_rate.FormattingEnabled = true;
            this.box_baud_rate.Location = new System.Drawing.Point(107, 78);
            this.box_baud_rate.Name = "box_baud_rate";
            this.box_baud_rate.Size = new System.Drawing.Size(121, 28);
            this.box_baud_rate.TabIndex = 10;
            // 
            // box_com_port
            // 
            this.box_com_port.FormattingEnabled = true;
            this.box_com_port.Location = new System.Drawing.Point(98, 34);
            this.box_com_port.Name = "box_com_port";
            this.box_com_port.Size = new System.Drawing.Size(130, 28);
            this.box_com_port.TabIndex = 9;
            this.box_com_port.SelectedIndexChanged += new System.EventHandler(this.box_com_port_SelectedIndexChanged);
            // 
            // button_disconnect
            // 
            this.button_disconnect.Location = new System.Drawing.Point(134, 168);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(112, 33);
            this.button_disconnect.TabIndex = 6;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(6, 168);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(98, 33);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "COM Port";
            // 
            // box_switch_status
            // 
            this.box_switch_status.Controls.Add(this.box_count_switch2);
            this.box_switch_status.Controls.Add(this.box_count_switch1);
            this.box_switch_status.Controls.Add(this.label8);
            this.box_switch_status.Controls.Add(this.label7);
            this.box_switch_status.Controls.Add(this.box_count_switch);
            this.box_switch_status.Controls.Add(this.label4);
            this.box_switch_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_switch_status.Location = new System.Drawing.Point(270, 34);
            this.box_switch_status.Name = "box_switch_status";
            this.box_switch_status.Size = new System.Drawing.Size(252, 150);
            this.box_switch_status.TabIndex = 1;
            this.box_switch_status.TabStop = false;
            this.box_switch_status.Text = "Switch Status";
            // 
            // box_count_switch2
            // 
            this.box_count_switch2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_count_switch2.Location = new System.Drawing.Point(130, 115);
            this.box_count_switch2.Name = "box_count_switch2";
            this.box_count_switch2.Size = new System.Drawing.Size(100, 26);
            this.box_count_switch2.TabIndex = 16;
            this.box_count_switch2.Text = "0";
            this.box_count_switch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box_count_switch1
            // 
            this.box_count_switch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_count_switch1.Location = new System.Drawing.Point(130, 78);
            this.box_count_switch1.Name = "box_count_switch1";
            this.box_count_switch1.Size = new System.Drawing.Size(100, 26);
            this.box_count_switch1.TabIndex = 15;
            this.box_count_switch1.Text = "0";
            this.box_count_switch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Counter (SW2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Counter (SW1)";
            // 
            // box_count_switch
            // 
            this.box_count_switch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.box_count_switch.Location = new System.Drawing.Point(130, 34);
            this.box_count_switch.Name = "box_count_switch";
            this.box_count_switch.Size = new System.Drawing.Size(100, 26);
            this.box_count_switch.TabIndex = 12;
            this.box_count_switch.Text = "0";
            this.box_count_switch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Counter (SW0)";
            // 
            // box_data_send_receive
            // 
            this.box_data_send_receive.Controls.Add(this.checkBox1);
            this.box_data_send_receive.Controls.Add(this.box_receive);
            this.box_data_send_receive.Controls.Add(this.box_send);
            this.box_data_send_receive.Controls.Add(this.label6);
            this.box_data_send_receive.Controls.Add(this.label5);
            this.box_data_send_receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_data_send_receive.Location = new System.Drawing.Point(528, 34);
            this.box_data_send_receive.Name = "box_data_send_receive";
            this.box_data_send_receive.Size = new System.Drawing.Size(342, 138);
            this.box_data_send_receive.TabIndex = 2;
            this.box_data_send_receive.TabStop = false;
            this.box_data_send_receive.Text = "Data Send/Receive";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(83, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // box_receive
            // 
            this.box_receive.Location = new System.Drawing.Point(122, 80);
            this.box_receive.Name = "box_receive";
            this.box_receive.Size = new System.Drawing.Size(214, 26);
            this.box_receive.TabIndex = 11;
            // 
            // box_send
            // 
            this.box_send.Location = new System.Drawing.Point(122, 34);
            this.box_send.Name = "box_send";
            this.box_send.Size = new System.Drawing.Size(214, 26);
            this.box_send.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Receive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Send";
            // 
            // box_led_control
            // 
            this.box_led_control.Controls.Add(this.pictureBox1);
            this.box_led_control.Controls.Add(this.button_off);
            this.box_led_control.Controls.Add(this.button_on);
            this.box_led_control.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_led_control.Location = new System.Drawing.Point(270, 255);
            this.box_led_control.Name = "box_led_control";
            this.box_led_control.Size = new System.Drawing.Size(252, 117);
            this.box_led_control.TabIndex = 2;
            this.box_led_control.TabStop = false;
            this.box_led_control.Text = "LED Control 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox1.ImageLocation = "D:\\GTDKTBNV\\RS232_Interface\\led_tat.png";
            this.pictureBox1.InitialImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 78);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_off
            // 
            this.button_off.Location = new System.Drawing.Point(150, 64);
            this.button_off.Name = "button_off";
            this.button_off.Size = new System.Drawing.Size(80, 39);
            this.button_off.TabIndex = 1;
            this.button_off.Text = "OFF";
            this.button_off.UseVisualStyleBackColor = true;
            this.button_off.Click += new System.EventHandler(this.button_off_Click);
            // 
            // button_on
            // 
            this.button_on.Location = new System.Drawing.Point(150, 20);
            this.button_on.Name = "button_on";
            this.button_on.Size = new System.Drawing.Size(80, 38);
            this.button_on.TabIndex = 0;
            this.button_on.Text = "ON";
            this.button_on.UseVisualStyleBackColor = true;
            this.button_on.Click += new System.EventHandler(this.button_on_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(299, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "RS232 Comunication Lab";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_send.Location = new System.Drawing.Point(551, 178);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 41);
            this.button_send.TabIndex = 7;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_exit_program
            // 
            this.button_exit_program.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exit_program.Location = new System.Drawing.Point(696, 178);
            this.button_exit_program.Name = "button_exit_program";
            this.button_exit_program.Size = new System.Drawing.Size(130, 41);
            this.button_exit_program.TabIndex = 8;
            this.button_exit_program.Text = "Exit Program";
            this.button_exit_program.UseVisualStyleBackColor = true;
            this.button_exit_program.Click += new System.EventHandler(this.button_exit_program_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // box_led_control2
            // 
            this.box_led_control2.Controls.Add(this.pictureBox2);
            this.box_led_control2.Controls.Add(this.button_off2);
            this.box_led_control2.Controls.Add(this.button_on2);
            this.box_led_control2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_led_control2.Location = new System.Drawing.Point(528, 255);
            this.box_led_control2.Name = "box_led_control2";
            this.box_led_control2.Size = new System.Drawing.Size(252, 117);
            this.box_led_control2.TabIndex = 3;
            this.box_led_control2.TabStop = false;
            this.box_led_control2.Text = "LED Control 2";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox2.ImageLocation = "D:\\GTDKTBNV\\RS232_Interface\\led_tat.png";
            this.pictureBox2.InitialImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox2.Location = new System.Drawing.Point(10, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 78);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_off2
            // 
            this.button_off2.Location = new System.Drawing.Point(150, 64);
            this.button_off2.Name = "button_off2";
            this.button_off2.Size = new System.Drawing.Size(80, 39);
            this.button_off2.TabIndex = 1;
            this.button_off2.Text = "OFF";
            this.button_off2.UseVisualStyleBackColor = true;
            this.button_off2.Click += new System.EventHandler(this.button_off2_Click);
            // 
            // button_on2
            // 
            this.button_on2.Location = new System.Drawing.Point(150, 20);
            this.button_on2.Name = "button_on2";
            this.button_on2.Size = new System.Drawing.Size(80, 38);
            this.button_on2.TabIndex = 0;
            this.button_on2.Text = "ON";
            this.button_on2.UseVisualStyleBackColor = true;
            this.button_on2.Click += new System.EventHandler(this.button_on2_Click);
            // 
            // box_led_control1
            // 
            this.box_led_control1.Controls.Add(this.pictureBox3);
            this.box_led_control1.Controls.Add(this.button_off1);
            this.box_led_control1.Controls.Add(this.button_on1);
            this.box_led_control1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_led_control1.Location = new System.Drawing.Point(12, 255);
            this.box_led_control1.Name = "box_led_control1";
            this.box_led_control1.Size = new System.Drawing.Size(252, 117);
            this.box_led_control1.TabIndex = 9;
            this.box_led_control1.TabStop = false;
            this.box_led_control1.Text = "LED Control 0";
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox3.ImageLocation = "D:\\GTDKTBNV\\RS232_Interface\\led_tat.png";
            this.pictureBox3.InitialImage = global::RS232_Interface.Properties.Resources.led_tat1;
            this.pictureBox3.Location = new System.Drawing.Point(10, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 78);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // button_off1
            // 
            this.button_off1.Location = new System.Drawing.Point(150, 64);
            this.button_off1.Name = "button_off1";
            this.button_off1.Size = new System.Drawing.Size(80, 39);
            this.button_off1.TabIndex = 1;
            this.button_off1.Text = "OFF";
            this.button_off1.UseVisualStyleBackColor = true;
            this.button_off1.Click += new System.EventHandler(this.button_off1_Click);
            // 
            // button_on1
            // 
            this.button_on1.Location = new System.Drawing.Point(150, 20);
            this.button_on1.Name = "button_on1";
            this.button_on1.Size = new System.Drawing.Size(80, 38);
            this.button_on1.TabIndex = 0;
            this.button_on1.Text = "ON";
            this.button_on1.UseVisualStyleBackColor = true;
            this.button_on1.Click += new System.EventHandler(this.button_on1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 378);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.box_led_control1);
            this.Controls.Add(this.box_led_control2);
            this.Controls.Add(this.button_exit_program);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.box_led_control);
            this.Controls.Add(this.box_data_send_receive);
            this.Controls.Add(this.box_switch_status);
            this.Controls.Add(this.box_comunication_setup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RS232 Interface";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.box_comunication_setup.ResumeLayout(false);
            this.box_comunication_setup.PerformLayout();
            this.box_switch_status.ResumeLayout(false);
            this.box_switch_status.PerformLayout();
            this.box_data_send_receive.ResumeLayout(false);
            this.box_data_send_receive.PerformLayout();
            this.box_led_control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.box_led_control2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.box_led_control1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox box_comunication_setup;
        private System.Windows.Forms.TextBox box_status_port;
        private System.Windows.Forms.ComboBox box_baud_rate;
        private System.Windows.Forms.ComboBox box_com_port;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox box_switch_status;
        private System.Windows.Forms.TextBox box_count_switch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox box_data_send_receive;
        private System.Windows.Forms.TextBox box_receive;
        private System.Windows.Forms.TextBox box_send;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox box_led_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_off;
        private System.Windows.Forms.Button button_on;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_exit_program;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox box_count_switch2;
        private System.Windows.Forms.TextBox box_count_switch1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox box_led_control2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_off2;
        private System.Windows.Forms.Button button_on2;
        private System.Windows.Forms.GroupBox box_led_control1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_off1;
        private System.Windows.Forms.Button button_on1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

