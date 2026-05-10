using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Wifi
{
    public partial class Form1 : Form
    {
        IPEndPoint ipe;
        Socket server;
        Socket client;
        //byte[] datasend = new byte[1]; // Mang gui di
        //byte[] datareceive = new byte[1]; // Mang nhan ve
        //int count = 0;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit the program?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (button_DisConnect.Enabled == true)
                {
                    server.Close();
                    client.Close();
                }
            }
        }
   
        private void button_Connect_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Endpoint_Thread);
            thread.IsBackground = true;
            thread.Start();

            textBox_Status.BackColor = Color.Yellow;
            textBox_Status.Text = "Waiting for device to connect...";

            // Khóa cấu hình IP/Port
            SetIPControlsState(false);
        }

        void Endpoint_Thread()
        {
            try
            {
                string ip = $"{textBox_ServerIP_1.Text.Trim()}.{textBox_ServerIP_2.Text.Trim()}.{textBox_ServerIP_3.Text.Trim()}.{textBox_ServerIP_4.Text.Trim()}";
                int port = int.Parse(textBox_ServerPort.Text.Trim());

                ipe = new IPEndPoint(IPAddress.Parse(ip), port);
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                server.Bind(ipe);
                server.Listen(10);
                client = server.Accept();

                textBox_Status.BackColor = Color.Lime;
                textBox_Status.Text = "Connected with: " + client.RemoteEndPoint.ToString();

                Thread thread = new Thread(Receive);
                thread.IsBackground = true;
                thread.Start();

                SetActionButtonsState(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Check the connection again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUI();
            }
        }

        private void button_DisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null) client.Close();
                if (server != null) server.Close();
            }
            catch { }
            ResetUI();
        }

        private void Receive()
        {
            try
            {
                byte[] buffer = new byte[1024];
                string receiveBuffer = "";

                while (true)
                {
                    int bytesRead = client.Receive(buffer);
                    if (bytesRead > 0)
                    {
                        string inData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        receiveBuffer += inData;

                        while (receiveBuffer.Contains("&"))
                        {
                            int index = receiveBuffer.IndexOf("&");
                            string packet = receiveBuffer.Substring(0, index + 1);
                            receiveBuffer = receiveBuffer.Substring(index + 1);

                            this.Invoke(new Action(() => {
                                ParsePacket(packet);
                            }));
                        }
                    }
                }
            }
            catch { if (client != null) client.Close(); }
        }

        private void ParsePacket(string packet)
        {
            // Xử lý dữ liệu từ 3 nút nhấn (Switch)
            if (packet.Contains("@S"))
            {
                string[] parts = packet.Replace("&", "").Split('_');
                if (parts.Length == 2)
                {
                    if (parts[0] == "@S0") textBox_SW0.Text = parts[1];
                    else if (parts[0] == "@S1") textBox_SW1.Text = parts[1];
                    else if (parts[0] == "@S2") textBox_SW2.Text = parts[1];
                }
            }
            // Xử lý phản hồi trạng thái LED (tùy chọn hiển thị lên PictureBox)
            else if (packet.Contains("@Lle"))
            {
                bool isOn = packet.Contains("on");
                // Ví dụ: if(packet.Contains("Lle0")) picLED0.Image = isOn ? ... : ...;
            }
        }

        // Hàm gửi dữ liệu dùng chung
        private void SendPacket(string cmd)
        {
            try
            {
                byte[] datasend = Encoding.ASCII.GetBytes(cmd);
                client.Send(datasend, datasend.Length, SocketFlags.None);
            }
            catch
            {
                MessageBox.Show("Connection lost!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUI();
            }
        }

        // Sự kiện cho 3 bộ nút LED
        private void btn_L0_ON_Click(object sender, EventArgs e) => SendPacket("@le0_on&");
        private void btn_L0_OFF_Click(object sender, EventArgs e) => SendPacket("@le0_of&");

        private void btn_L1_ON_Click(object sender, EventArgs e) => SendPacket("@le1_on&");
        private void btn_L1_OFF_Click(object sender, EventArgs e) => SendPacket("@le1_of&");

        private void btn_L2_ON_Click(object sender, EventArgs e) => SendPacket("@le2_on&");
        private void btn_L2_OFF_Click(object sender, EventArgs e) => SendPacket("@le2_of&");

        // Các hàm hỗ trợ giao diện
        private void ResetUI()
        {
            textBox_Status.BackColor = Color.Red;
            textBox_Status.Text = "Not connected";
            SetIPControlsState(true);
            SetActionButtonsState(false);
        }

        private void SetIPControlsState(bool state)
        {
            textBox_ServerIP_1.Enabled = textBox_ServerIP_2.Enabled =
            textBox_ServerIP_3.Enabled = textBox_ServerIP_4.Enabled =
            textBox_ServerPort.Enabled = state;
            button_Connect.Enabled = state;
            button_DisConnect.Enabled = !state;
        }

        private void SetActionButtonsState(bool state)
        {
            // Đảm bảo bạn đã đặt tên các nút này trong Designer
            btn_L0_ON.Enabled = btn_L0_OFF.Enabled = state;
            btn_L1_ON.Enabled = btn_L1_OFF.Enabled = state;
            btn_L2_ON.Enabled = btn_L2_OFF.Enabled = state;
        }


        private void textBox_ServerIP_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_ServerIP_1_Validated(object sender, EventArgs e)
        {
            if (textBox_ServerIP_1.Text == "")
            {
                MessageBox.Show("Blank is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_1.Text = "192";
                textBox_ServerIP_1.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_1.Text) < 1)
            {
                MessageBox.Show(textBox_ServerIP_1.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_1.Text = "192";
                textBox_ServerIP_1.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_1.Text) > 223)
            {
                MessageBox.Show(textBox_ServerIP_1.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_1.Text = "192";
                textBox_ServerIP_1.Focus();
            }
        }

        private void textBox_ServerIP_2_Validated(object sender, EventArgs e)
        {
            if (textBox_ServerIP_2.Text == "")
            {
                MessageBox.Show("Blank is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_2.Text = "168";
                textBox_ServerIP_2.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_2.Text) < 1)
            {
                MessageBox.Show(textBox_ServerIP_2.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_2.Text = "168";
                textBox_ServerIP_2.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_2.Text) > 223)
            {
                MessageBox.Show(textBox_ServerIP_2.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_2.Text = "168";
                textBox_ServerIP_2.Focus();
            }
        }

        private void textBox_ServerIP_3_Validated(object sender, EventArgs e)
        {
            if (textBox_ServerIP_3.Text == "")
            {
                MessageBox.Show("Blank is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_3.Text = "0";
                textBox_ServerIP_3.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_3.Text) < 1)
            {
                MessageBox.Show(textBox_ServerIP_3.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_3.Text = "0";
                textBox_ServerIP_3.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_3.Text) > 223)
            {
                MessageBox.Show(textBox_ServerIP_3.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_3.Text = "0";
                textBox_ServerIP_3.Focus();
            }
        }

        private void textBox_ServerIP_4_Validated(object sender, EventArgs e)
        {
            if (textBox_ServerIP_4.Text == "")
            {
                MessageBox.Show("Blank is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_4.Text = "123";
                textBox_ServerIP_4.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_4.Text) < 1)
            {
                MessageBox.Show(textBox_ServerIP_4.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_4.Text = "123";
                textBox_ServerIP_4.Focus();
            }
            else if (Int16.Parse(textBox_ServerIP_4.Text) > 223)
            {
                MessageBox.Show(textBox_ServerIP_4.Text + " is not a valid entry. Please specify a value between 1 and 223", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerIP_4.Text = "123";
                textBox_ServerIP_4.Focus();
            }
        }

        private void textBox_ServerPort_Validated(object sender, EventArgs e)
        {
            if (textBox_ServerPort.Text == "")
            {
                MessageBox.Show("Blank is not a valid entry. Please specify a value between 0 and 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerPort.Text = "8000";
                textBox_ServerPort.Focus();
            }
            else if (Int32.Parse(textBox_ServerPort.Text) < 0)
            {
                MessageBox.Show(textBox_ServerPort.Text + " is not a valid entry. Please specify a value between 0 and 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerPort.Text = "8000";
                textBox_ServerPort.Focus();
            }
            else if (Int32.Parse(textBox_ServerPort.Text) > 65535)
            {
                MessageBox.Show(textBox_ServerPort.Text + " is not a valid entry. Please specify a value between 0 and 65535", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_ServerPort.Text = "8000";
                textBox_ServerPort.Focus();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
