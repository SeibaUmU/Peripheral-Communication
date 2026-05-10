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
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace RS232_Interface
{
    public partial class Form1 : Form
    {
        TcpClient client;
        TcpListener server;
        NetworkStream stream;
        Thread receiveThread;
        bool isRunning = false;
        string TransmitData = String.Empty;
        int count = 0, count1 = 0, count2 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                box_com_port.Items.Add(port);
            }
        }

        private void box_com_port_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = box_com_port.Text;
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect("192.168.1.130", 8080);

                stream = client.GetStream();
                isRunning = true;

                receiveThread = new Thread(DataReceiver);
                receiveThread.IsBackground = true;
                receiveThread.Start();

                box_status_port.BackColor = Color.Green;
                box_status_port.Text = "Connected";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi mở Server: " + ex.Message);
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            CloseConnection();
        }

        private void button_on_Click(object sender, EventArgs e) => SendEthernet("@le2_on&");
        private void button_off_Click(object sender, EventArgs e) => SendEthernet("@le2_of&");
        string buffer = "";
        private void UpdateUI(string data)
        {
            if (data.StartsWith("@Lle"))
            {
                if (data.Contains("1_on")) textBox1.Text = "Led do bat";
                else if (data.Contains("1_of")) textBox1.Text = "Led do tat";
                else if (data.Contains("2_on")) textBox1.Text = "Led xanh bat";
                else if (data.Contains("2_of")) textBox1.Text = "Led xanh tat";
                else if (data.Contains("3_on")) textBox1.Text = "Led vang bat";
                else if (data.Contains("3_of")) textBox1.Text = "Led vang tat";
            }

            else if (data.StartsWith("@S"))
            {
                char switchId = data[2];
                string countVal = data.Substring(3);

                switch (switchId)
                {
                    case '0':
                        textBox1.Text = "Nut 1 nhan: " + countVal + " lan";
                        box_count_switch.Text = countVal;
                        break;
                    case '1':
                        textBox1.Text = "Nut 2 nhan: " + countVal + " lan";
                        box_count_switch1.Text = countVal;
                        break;
                    case '2':
                        textBox1.Text = "Nut 3 nhan: " + countVal + " lan";
                        box_count_switch2.Text = countVal;
                        break;
                }
            }

            else if (data.Contains("led do") || data.Contains("led xanh"))
            {
                textBox1.Text = data;
            }
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incoming = serialPort1.ReadExisting();
            buffer += incoming;

            while (buffer.Contains("&"))
            {
                int index = buffer.IndexOf("&");
                string singleCommand = buffer.Substring(0, index);
                buffer = buffer.Substring(index + 1);

                this.Invoke(new Action(() =>
                {
                    UpdateUI(singleCommand);
                }));
            }
        }
        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = box_send.Text.ToString();
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    MessageBox.Show("COM Port was disconnected.", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM Port was not found. Please check your input cable.", "Notification!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            if (checkBox1.Checked == true)
            {
                button_send.Enabled = true;
                box_send.ReadOnly = false;
            }
            else
            {
                button_send.Enabled = false;
                box_send.ReadOnly = true;
            }
        }

        private void button_exit_program_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit ?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CloseConnection();
                this.Close();
            }
        }

        private void button_on1_Click(object sender, EventArgs e) => SendEthernet("@le1_on&");

        private void button_on2_Click(object sender, EventArgs e) => SendEthernet("@le3_on&");

        private void button_off1_Click(object sender, EventArgs e) => SendEthernet("@le1_of&");

        private void button_off2_Click(object sender, EventArgs e) => SendEthernet("@le3_of&");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void DataReceiver()
        {
            byte[] readBuffer = new byte[1024];
            string dataStr = "";

            while (isRunning)
            {
                try
                {
                    if (stream != null && stream.DataAvailable)
                    {
                        int bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
                        string incoming = Encoding.ASCII.GetString(readBuffer, 0, bytesRead);
                        dataStr += incoming;

                        while (dataStr.Contains("&"))
                        {
                            int index = dataStr.IndexOf("&");
                            string command = dataStr.Substring(0, index);
                            dataStr = dataStr.Substring(index + 1);

                            this.Invoke(new Action(() => {
                                UpdateUI(command);
                            }));
                        }
                    }
                    Thread.Sleep(10);
                }
                catch { break; }
            }
        }
        private void SendEthernet(string cmd)
        {
            try
            {
                if (client != null && client.Connected && stream != null)
                {
                    byte[] msg = Encoding.ASCII.GetBytes(cmd);
                    stream.Write(msg, 0, msg.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi dữ hiệu: " + ex.Message);
            }
        }

        private void CloseConnection()
        {
            isRunning = false;
            if (stream != null) stream.Close();
            if (client != null) client.Close();

            box_status_port.BackColor = Color.Red;
            box_status_port.Text = "Disconnected";
        }

        private void AcceptModule()
        {
            try
            {
                client = server.AcceptTcpClient();
                stream = client.GetStream();

                this.Invoke(new Action(() => {
                    box_status_port.BackColor = Color.Green;
                    box_status_port.Text = "Module Connected!";
                }));

                DataReceiver();
            }
            catch { }
        }
    }
}
