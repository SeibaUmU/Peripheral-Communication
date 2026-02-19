using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string ReceivedData = String.Empty; //bien chua chuoi nhan ve 
        string TransmitData = String.Empty; //bien chua chuoi truyen di
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Serial_Port.PortName = "Select COM Port...";
            //Serial_Port.BaudRate = 9600;
            Serial_Port.DataBits = 8;
            Serial_Port.Parity = Parity.None;
            Serial_Port.StopBits = StopBits.One;
            
            //Tag: Là một thuộc tính của Button dùng để lưu trữ dữ liệu đi kèm. Ở đây, bạn đang gán số thứ tự (ID) của đèn LED cho mỗi nút.
            //Để khi nhấn nút, chương trình biết được nút đó đại diện cho đèn số mấy mà không cần viết nhiều hàm riêng biệt.
            button_ON.Tag = "0";
            button_ON1.Tag = "1";
            button_ON2.Tag = "2";
            button_OFF.Tag = "0";
            button_OFF1.Tag = "1";
            button_OFF2.Tag = "2";
            //doc thong tin cac cong COM co trong bo PC
            string[] ports = SerialPort.GetPortNames();
            //them ten cac cong COM vao muc COM Port
            foreach (string port in ports)
            {
                comboBox_COMPort.Items.Add(port);
            }

        }
        //ct con gui du lieu
        public void Send_Data(string Send_Text)
        {
            Serial_Port.Write(Send_Text);
            textbox_DataSend.Text = Send_Text.ToString(); //hien thi du lieu gui
        }
        //xu lieu khi dong giao dien
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Serial_Port.IsOpen)
                Serial_Port.Close(); //dong COM neu dang dc mo
        }
        //ham nut connect
        
        private void button_Connect_Click(object sender, EventArgs e)
        {
            
            
            if (comboBox_COMPort.Text == "") //kiem tra da pick COM ch
            {
                MessageBox.Show("Select COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); //thong bao loi neu ch pick
            }
            else if (comboBox_BaudRate.Text == "") //kiem tra pick baudrate ch
            {
                MessageBox.Show("Select baudrate for COM Port.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try //xu li khi cong COM da mo
                {
                    if (Serial_Port.IsOpen) //xu li th da ket noi
                    {
                        MessageBox.Show("COM Port is connected and ready for use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    else //th ch ket noi
                    {
                        // Cập nhật lại BaudRate từ comboBox trước khi mở cổng
                        Serial_Port.PortName = comboBox_COMPort.Text;
                        Serial_Port.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text);
                        Serial_Port.Open();

                        MessageBox.Show(comboBox_COMPort.Text + " is connected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        textBox_Status.BackColor = Color.Lime; //hieu chinh mau va thong tin
                        textBox_Status.Text = "Connecting...";

                        comboBox_COMPort.Enabled = false;
                        comboBox_BaudRate.Enabled = false;

                        ReceivedData = String.Empty;
                        TransmitData = String.Empty;
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    textBox_Status.BackColor = Color.Red;
                    textBox_Status.Text = "Disconnected!";
                    MessageBox.Show("COM Port is being used by another application. Please close Hercules or other apps.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception) //xu li xuat hien loi ko hien thi
                {
                    textBox_Status.BackColor = Color.Red; 
                    textBox_Status.Text = "Disconnected!";
                    MessageBox.Show("COM Port is not found. Please check your COM or Cable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 
        //khoi nut disconnect
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen) //th da ket noi
                {
                    Serial_Port.Close();

                    textBox_Status.BackColor = Color.Red;
                    textBox_Status.Text = "Disconnected!";

                    MessageBox.Show("COM Port is disconnected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    comboBox_COMPort.Enabled = true;
                    comboBox_BaudRate.Enabled = true;
                }
                else //th ch ket noi
                {
                    MessageBox.Show("COM Port have been disconnected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Disconnection appears error. Unable to disconnect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //xu li nut exit
        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit the program?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                if (Serial_Port.IsOpen) //dong cong neu dang dc mo
                {
                    Serial_Port.Close();
                }
                this.Close();
            }
        }
        //nut on
        private void button_ON_Click(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen)
                {   //Xác định chính xác nút nào vừa được nhấn trong số các nút dùng chung hàm này.
                    //Khi bạn nhấn vào bất kỳ nút nào (ON0, ON1 hay ON2), Windows sẽ gửi đối tượng đó vào biến sender
                    //Dòng này thực hiện "ép kiểu" (casting) để máy tính hiểu rằng: "Hãy đối xử với cái sender này như một cái Button thực thụ".
                    //Nhờ đó, bạn mới truy cập được các thuộc tính như .Tag hay .Text
                    Button clickedButton = (Button)sender;
                    string ledNumber = clickedButton.Tag.ToString(); //Lấy con số (0, 1, hoặc 2) mà chúng ta đã gán ở phần khởi tạo.
                    TransmitData = $"@le{ledNumber}_on&";
                    Send_Data(TransmitData); //gui dl qua port noi tiep
                }
                else
                {
                    textBox_Status.BackColor = Color.Red;
                    textBox_Status.Text = "Disconnected!";
                    MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The control appears error. Action can not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //nut off
        private void button_OFF_Click(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen)
                {
                    Button clickedButton = (Button)sender;
                    string ledNumber = clickedButton.Tag.ToString();
                    TransmitData = $"@le{ledNumber}_of&";
                    Send_Data(TransmitData);
                }
                else
                {
                    textBox_Status.BackColor = Color.Red;
                    textBox_Status.Text = "Disconnected!";
                    MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The control appears error. Action can not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //nut send
        private void button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (Serial_Port.IsOpen)
                {
                    TransmitData = textbox_DataSend.Text.ToString();
                    Send_Data(TransmitData);
                }
                else
                {
                    textBox_Status.BackColor = Color.Red;
                    textBox_Status.Text = "Disconnected!";
                    MessageBox.Show("COM Port is not connected. Please reconnect to use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The control appears error. Action can not be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //hop thoai tick send
        private void checkBox_DataSend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DataSend.Checked == true)
            {
                button_DataSend.Enabled = true; //cho phep nhap chuoi dl vao o send khi da tich o checktick send
                textbox_DataSend.ReadOnly = false;
            }
            else
            {
                button_DataSend.Enabled = false;
                textbox_DataSend.ReadOnly = true;
            }
        }
        //xu li khi chon cong COM
        private void comboBox_COMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_Port.IsOpen)
            {
                Serial_Port.Close();
            }//dong cong COM da chon trc do
            textBox_Status.BackColor = Color.Red;
            textBox_Status.Text = "Disconnected!";
            Serial_Port.PortName = comboBox_COMPort.Text; //lay so cong COM da chon
        }
        //xu li khi chon baud
        private void comboBox_BaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CHỈ lưu thông số, KHÔNG mở cổng
            if (Serial_Port.IsOpen) { 
            Serial_Port.Close(); }//dong cong COM da chon truoc do
            textBox_Status.BackColor = Color.Red;
            textBox_Status.Text = "Disconnected!";
            Serial_Port.BaudRate = Convert.ToInt32(comboBox_BaudRate.Text); //lay toc do baud da pick
        }
        //nhan du lieu tu cong COM
        private void Serial_Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //kiem tra xung dot
            //nhan dl bat dau bang @ va ket thuc = &
            ReceivedData = Serial_Port.ReadTo("&");
            textBox_DataReceive.Text = ReceivedData.ToString() + "&";  //hien thi dl nhan

            if (ReceivedData.Substring(0, 1) == "@") //kiem tra dung dinh dang chuoi dl @...&
            {
                if (ReceivedData.Substring(1, 1) == "S") //neu ky tu dau sau @ la S
                {
                    // Tách chuỗi dựa vào dấu gạch dưới '_'
                    // parts[0] sẽ là "@S1", parts[1] sẽ là "15"
                    string[] parts = ReceivedData.Split('_');

                    if (parts.Length == 2)
                    {
                        string swID = parts[0]; // "@S0", "@S1" hoặc "@S2"
                        string value = parts[1]; // Số lần nhấn

                        // Kiểm tra ID và đưa vào đúng TextBox
                        if (swID == "@S0") textBox_SW.Text = value;
                        else if (swID == "@S1") textBox_SW1.Text = value;
                        else if (swID == "@S2") textBox_SW2.Text = value;
                    }
                }
                else if (ReceivedData.Substring(1, 1) == "L") //kiem tra du lieu phan hoi LED
                {
                    // Xác định số thứ tự LED (nằm ở vị trí index 4 trong chuỗi "@Lle0_on")
                    string ledIndex = ReceivedData.Substring(4, 1);

                    // Kiểm tra trạng thái "on" hay "of" ở cuối chuỗi
                    bool isOn = ReceivedData.EndsWith("on");

                    if (ledIndex == "0")
                    {
                        ovalShape_LED.FillColor = isOn ? Color.Red : Color.DarkGray; //doi mau ovalshape: sang thi mau do, tat thi mau xam
                    }
                    else if (ledIndex == "1")
                    {
                        ovalShape_LED1.FillColor = isOn ? Color.Red : Color.DarkGray;
                    }
                    else if (ledIndex == "2")
                    {
                        ovalShape_LED2.FillColor = isOn ? Color.Red : Color.DarkGray;
                    }
                }
            }
        }


        private void Form1_Leave(object sender, EventArgs e)
        {

        }

        

        
    }
    
    }
