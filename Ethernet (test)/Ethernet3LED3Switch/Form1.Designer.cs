namespace Ethernet3LED3Switch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SendBox = new RichTextBox();
            ReceiveBox = new RichTextBox();
            SendLabel = new Label();
            ReceiveLabel = new Label();
            SetupGroup = new GroupBox();
            ConnectStatus = new Label();
            IPlabel = new Label();
            COMSelectLabel = new Label();
            BaudrateSelectLabel = new Label();
            BaudrateSelect = new ComboBox();
            COMSelect = new ComboBox();
            ConnectButton = new Button();
            ControlGroup = new GroupBox();
            LED1Select = new Label();
            LED2Status = new Label();
            LED3Status = new Label();
            LED1Control = new Button();
            LED2Control = new Button();
            LED3Control = new Button();
            Switch1Count = new TextBox();
            IPTextBox = new TextBox();
            Switch2Count = new TextBox();
            Switch3Count = new TextBox();
            SetupGroup.SuspendLayout();
            ControlGroup.SuspendLayout();
            SuspendLayout();
            // 
            // SendBox
            // 
            SendBox.Location = new Point(434, 43);
            SendBox.Name = "SendBox";
            SendBox.Size = new Size(354, 164);
            SendBox.TabIndex = 0;
            SendBox.Text = "";
            SendBox.TextChanged += SendBox_TextChanged;
            // 
            // ReceiveBox
            // 
            ReceiveBox.Location = new Point(434, 259);
            ReceiveBox.Name = "ReceiveBox";
            ReceiveBox.Size = new Size(354, 179);
            ReceiveBox.TabIndex = 1;
            ReceiveBox.Text = "";
            ReceiveBox.TextChanged += ReceiveBox_TextChanged;
            // 
            // SendLabel
            // 
            SendLabel.AutoSize = true;
            SendLabel.Location = new Point(549, 9);
            SendLabel.Name = "SendLabel";
            SendLabel.Size = new Size(119, 20);
            SendLabel.TabIndex = 2;
            SendLabel.Text = "Dữ liệu truyền đi";
            SendLabel.Click += label1_Click;
            // 
            // ReceiveLabel
            // 
            ReceiveLabel.AutoSize = true;
            ReceiveLabel.Location = new Point(556, 224);
            ReceiveLabel.Name = "ReceiveLabel";
            ReceiveLabel.Size = new Size(112, 20);
            ReceiveLabel.TabIndex = 3;
            ReceiveLabel.Text = "Dữ liệu nhận về";
            ReceiveLabel.Click += label2_Click;
            // 
            // SetupGroup
            // 
            SetupGroup.Controls.Add(ConnectStatus);
            SetupGroup.Controls.Add(IPTextBox);
            SetupGroup.Controls.Add(IPlabel);
            SetupGroup.Controls.Add(COMSelectLabel);
            SetupGroup.Controls.Add(BaudrateSelectLabel);
            SetupGroup.Controls.Add(BaudrateSelect);
            SetupGroup.Controls.Add(COMSelect);
            SetupGroup.Controls.Add(ConnectButton);
            SetupGroup.Location = new Point(12, 34);
            SetupGroup.Name = "SetupGroup";
            SetupGroup.Size = new Size(384, 173);
            SetupGroup.TabIndex = 4;
            SetupGroup.TabStop = false;
            SetupGroup.Text = "Setup Ethernet";
            SetupGroup.Enter += groupBox1_Enter;
            // 
            // ConnectStatus
            // 
            ConnectStatus.AutoSize = true;
            ConnectStatus.Location = new Point(276, 73);
            ConnectStatus.Name = "ConnectStatus";
            ConnectStatus.Size = new Size(92, 20);
            ConnectStatus.TabIndex = 18;
            ConnectStatus.Text = "Chưa kết nối";
            ConnectStatus.Click += ConnectStatus_Click;
            // 
            // IPlabel
            // 
            IPlabel.AutoSize = true;
            IPlabel.Location = new Point(16, 108);
            IPlabel.Name = "IPlabel";
            IPlabel.Size = new Size(78, 20);
            IPlabel.TabIndex = 13;
            IPlabel.Text = "IP Address";
            IPlabel.Click += label3_Click;
            // 
            // COMSelectLabel
            // 
            COMSelectLabel.AutoSize = true;
            COMSelectLabel.Location = new Point(16, 29);
            COMSelectLabel.Name = "COMSelectLabel";
            COMSelectLabel.Size = new Size(42, 20);
            COMSelectLabel.TabIndex = 12;
            COMSelectLabel.Text = "COM";
            COMSelectLabel.Click += COMSelectLabel_Click;
            // 
            // BaudrateSelectLabel
            // 
            BaudrateSelectLabel.AutoSize = true;
            BaudrateSelectLabel.Location = new Point(16, 68);
            BaudrateSelectLabel.Name = "BaudrateSelectLabel";
            BaudrateSelectLabel.Size = new Size(69, 20);
            BaudrateSelectLabel.TabIndex = 11;
            BaudrateSelectLabel.Text = "Baudrate";
            BaudrateSelectLabel.Click += BaudrateSelectLabel_Click;
            // 
            // BaudrateSelect
            // 
            BaudrateSelect.FormattingEnabled = true;
            BaudrateSelect.Location = new Point(103, 65);
            BaudrateSelect.Name = "BaudrateSelect";
            BaudrateSelect.Size = new Size(151, 28);
            BaudrateSelect.TabIndex = 9;
            BaudrateSelect.SelectedIndexChanged += BaudrateSelect_SelectedIndexChanged;
            // 
            // COMSelect
            // 
            COMSelect.FormattingEnabled = true;
            COMSelect.Location = new Point(103, 26);
            COMSelect.Name = "COMSelect";
            COMSelect.Size = new Size(151, 28);
            COMSelect.TabIndex = 10;
            COMSelect.SelectedIndexChanged += COMSelect_SelectedIndexChanged;
            // 
            // ConnectButton
            // 
            ConnectButton.Location = new Point(274, 108);
            ConnectButton.Name = "ConnectButton";
            ConnectButton.Size = new Size(94, 29);
            ConnectButton.TabIndex = 5;
            ConnectButton.Text = "Connect";
            ConnectButton.UseVisualStyleBackColor = true;
            ConnectButton.Click += ConnectButton_Click;
            // 
            // ControlGroup
            // 
            ControlGroup.Controls.Add(Switch3Count);
            ControlGroup.Controls.Add(Switch2Count);
            ControlGroup.Controls.Add(Switch1Count);
            ControlGroup.Controls.Add(LED1Select);
            ControlGroup.Controls.Add(LED2Status);
            ControlGroup.Controls.Add(LED3Status);
            ControlGroup.Controls.Add(LED1Control);
            ControlGroup.Controls.Add(LED2Control);
            ControlGroup.Controls.Add(LED3Control);
            ControlGroup.Location = new Point(12, 251);
            ControlGroup.Name = "ControlGroup";
            ControlGroup.Size = new Size(384, 187);
            ControlGroup.TabIndex = 0;
            ControlGroup.TabStop = false;
            ControlGroup.Text = "Control";
            ControlGroup.Enter += ControlGroup_Enter;
            // 
            // LED1Select
            // 
            LED1Select.AutoSize = true;
            LED1Select.Location = new Point(36, 102);
            LED1Select.Name = "LED1Select";
            LED1Select.Size = new Size(34, 20);
            LED1Select.TabIndex = 15;
            LED1Select.Text = "OFF";
            LED1Select.Click += LED1Select_Click;
            // 
            // LED2Status
            // 
            LED2Status.AutoSize = true;
            LED2Status.Location = new Point(152, 102);
            LED2Status.Name = "LED2Status";
            LED2Status.Size = new Size(34, 20);
            LED2Status.TabIndex = 16;
            LED2Status.Text = "OFF";
            LED2Status.Click += LED2Status_Click;
            // 
            // LED3Status
            // 
            LED3Status.AutoSize = true;
            LED3Status.Location = new Point(274, 102);
            LED3Status.Name = "LED3Status";
            LED3Status.Size = new Size(34, 20);
            LED3Status.TabIndex = 17;
            LED3Status.Text = "OFF";
            LED3Status.Click += LED3Status_Click;
            // 
            // LED1Control
            // 
            LED1Control.Location = new Point(6, 143);
            LED1Control.Name = "LED1Control";
            LED1Control.Size = new Size(94, 29);
            LED1Control.TabIndex = 6;
            LED1Control.Text = "LED 1";
            LED1Control.UseVisualStyleBackColor = true;
            LED1Control.Click += LED1Control_Click;
            // 
            // LED2Control
            // 
            LED2Control.Location = new Point(125, 143);
            LED2Control.Name = "LED2Control";
            LED2Control.Size = new Size(94, 29);
            LED2Control.TabIndex = 7;
            LED2Control.Text = "LED 2";
            LED2Control.UseVisualStyleBackColor = true;
            LED2Control.Click += LED2Control_Click;
            // 
            // LED3Control
            // 
            LED3Control.Location = new Point(244, 143);
            LED3Control.Name = "LED3Control";
            LED3Control.Size = new Size(94, 29);
            LED3Control.TabIndex = 8;
            LED3Control.Text = "LED 3";
            LED3Control.UseVisualStyleBackColor = true;
            LED3Control.Click += LED3Control_Click;
            // 
            // Switch1Count
            // 
            Switch1Count.Location = new Point(6, 36);
            Switch1Count.Name = "Switch1Count";
            Switch1Count.Size = new Size(94, 27);
            Switch1Count.TabIndex = 19;
            Switch1Count.Text = "SW1:";
            Switch1Count.TextChanged += Switch1Count_TextChanged;
            // 
            // IPTextBox
            // 
            IPTextBox.Location = new Point(103, 108);
            IPTextBox.Name = "IPTextBox";
            IPTextBox.Size = new Size(151, 27);
            IPTextBox.TabIndex = 20;
            // 
            // Switch2Count
            // 
            Switch2Count.Location = new Point(125, 36);
            Switch2Count.Name = "Switch2Count";
            Switch2Count.Size = new Size(94, 27);
            Switch2Count.TabIndex = 20;
            Switch2Count.Text = "SW2:";
            Switch2Count.TextChanged += Switch2Count_TextChanged;
            // 
            // Switch3Count
            // 
            Switch3Count.Location = new Point(244, 36);
            Switch3Count.Name = "Switch3Count";
            Switch3Count.Size = new Size(94, 27);
            Switch3Count.TabIndex = 21;
            Switch3Count.Text = "SW3:";
            Switch3Count.TextChanged += Switch3Count_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ControlGroup);
            Controls.Add(SetupGroup);
            Controls.Add(ReceiveLabel);
            Controls.Add(SendLabel);
            Controls.Add(ReceiveBox);
            Controls.Add(SendBox);
            Name = "Form1";
            Text = "Form1";
            SetupGroup.ResumeLayout(false);
            SetupGroup.PerformLayout();
            ControlGroup.ResumeLayout(false);
            ControlGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox SendBox;
        private RichTextBox ReceiveBox;
        private Label SendLabel;
        private Label ReceiveLabel;
        private GroupBox SetupGroup;
        private GroupBox ControlGroup;
        private ComboBox BaudrateSelect;
        private ComboBox COMSelect;
        private Button ConnectButton;
        private Button LED1Control;
        private Button LED2Control;
        private Button LED3Control;
        private Label IPlabel;
        private Label COMSelectLabel;
        private Label BaudrateSelectLabel;
        private Label ConnectStatus;
        private Label LED1Select;
        private Label LED2Status;
        private Label LED3Status;
        private TextBox IPTextBox;
        private TextBox Switch3Count;
        private TextBox Switch2Count;
        private TextBox Switch1Count;
    }
}
