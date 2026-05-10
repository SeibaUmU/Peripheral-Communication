using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Ethernet3LED3Switch
{
    public partial class Form1 : Form
    {
        // Khai báo kết nối TCP thay cho SerialPort
        private TcpClient tcpClient;
        private NetworkStream networkStream;
        private Thread receiveThread;
        private string receiveBuffer = "";

        // Trạng thái LED
        private bool isLed1On = false;
        private bool isLed2On = false;
        private bool isLed3On = false;

        public Form1()
        {
            InitializeComponent();

            // Gợi ý định dạng nhập IP vào TextBox
            IPTextBox.Text = "192.168.0.7:8234"; // Thay 8234 bằng Port thực tế trên module USR
        }

        // -----------------------------------------------------------
        // 1. KẾT NỐI VÀ NGẮT KẾT NỐI MẠNG
        // -----------------------------------------------------------
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (tcpClient == null || !tcpClient.Connected)
            {
                try
                {
                    // Tách IP và Port từ IPTextBox (VD: "192.168.0.7:8234")
                    string[] ipParts = IPTextBox.Text.Split(':');
                    if (ipParts.Length != 2)
                    {
                        MessageBox.Show("Vui lòng nhập IP theo định dạng IP:Port (VD: 192.168.0.7:8234)");
                        return;
                    }

                    string ipAddress = ipParts[0];
                    int port = int.Parse(ipParts[1]);

                    // Khởi tạo kết nối TCP
                    tcpClient = new TcpClient();
                    tcpClient.NoDelay = true; // <--- THÊM DÒNG NÀY VÀO ĐÂY
                    tcpClient.Connect(ipAddress, port);
                    networkStream = tcpClient.GetStream();

                    // Chạy luồng đọc dữ liệu liên tục để không đơ giao diện
                    receiveThread = new Thread(ReceiveData);
                    receiveThread.IsBackground = true;
                    receiveThread.Start();

                    ConnectButton.Text = "Disconnect";
                    ConnectStatus.Text = "Đã kết nối TCP";
                    ConnectStatus.ForeColor = System.Drawing.Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối IP: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Disconnect();
            }
        }

        private void Disconnect()
        {
            if (networkStream != null) networkStream.Close();
            if (tcpClient != null) tcpClient.Close();

            ConnectButton.Text = "Connect";
            ConnectStatus.Text = "Chưa kết nối";
            ConnectStatus.ForeColor = System.Drawing.Color.Red;
        }

        // -----------------------------------------------------------
        // 2. NHẬN DỮ LIỆU TỪ MODULE USR (CHẠY TRONG THREAD RIÊNG)
        // -----------------------------------------------------------
        private void ReceiveData()
        {
            try
            {
                byte[] buffer = new byte[1024];
                while (tcpClient != null && tcpClient.Connected)
                {
                    int bytesRead = networkStream.Read(buffer, 0, buffer.Length);
                    if (bytesRead > 0)
                    {
                        string inData = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                        receiveBuffer += inData;

                        // Tách gói tin theo ký tự '&' giống code cũ
                        while (receiveBuffer.Contains("&"))
                        {
                            int index = receiveBuffer.IndexOf("&");
                            string packet = receiveBuffer.Substring(0, index + 1);
                            receiveBuffer = receiveBuffer.Substring(index + 1);

                            LogData(ReceiveBox, packet); // Ghi log có thời gian

                            // Đẩy dữ liệu sang luồng giao diện (UI Thread) để xử lý
                            this.Invoke(new Action(() => ProcessPacket(packet)));
                        }
                    }
                }
            }
            catch
            {
                // Xảy ra khi ngắt kết nối đột ngột
                this.Invoke(new Action(Disconnect));
            }
        }

        // -----------------------------------------------------------
        // 3. GỬI DỮ LIỆU XUỐNG MODULE USR
        // -----------------------------------------------------------
        private void SendData(string data)
        {
            if (tcpClient != null && tcpClient.Connected && networkStream != null)
            {
                byte[] dataBytes = Encoding.ASCII.GetBytes(data);
                networkStream.Write(dataBytes, 0, dataBytes.Length);
                LogData(SendBox, data);
            }
            else
            {
                MessageBox.Show("Vui lòng kết nối IP trước!", "Cảnh báo");
            }
        }

        // -----------------------------------------------------------
        // CÁC HÀM XỬ LÝ GIAO DIỆN VÀ LOGIC (GIỮ NGUYÊN NHƯ BẢN TRƯỚC)
        // -----------------------------------------------------------
        private void ProcessPacket(string packet)
        {
            string data = packet.Replace("&", "");

            // Xử lý LED
            if (data == "@Lle1_on") { LED1Select.Text = "ON"; isLed1On = true; }
            else if (data == "@Lle1_of") { LED1Select.Text = "OFF"; isLed1On = false; }
            else if (data == "@Lle2_on") { LED2Status.Text = "ON"; isLed2On = true; }
            else if (data == "@Lle2_of") { LED2Status.Text = "OFF"; isLed2On = false; }
            else if (data == "@Lle3_on") { LED3Status.Text = "ON"; isLed3On = true; }
            else if (data == "@Lle3_of") { LED3Status.Text = "OFF"; isLed3On = false; }

            // Xử lý Switch
            if (data.StartsWith("@SW1_")) Switch1Count.Text = data.Replace("@SW1_", "").Replace("_", "").Trim();
            else if (data.StartsWith("@SW2_")) Switch2Count.Text = data.Replace("@SW2_", "").Replace("_", "").Trim();
            else if (data.StartsWith("@SW3_")) Switch3Count.Text = data.Replace("@SW3_", "").Replace("_", "").Trim();
        }

        private void LogData(RichTextBox rtb, string data)
        {
            if (rtb.InvokeRequired)
            {
                rtb.Invoke(new Action<RichTextBox, string>(LogData), rtb, data);
                return;
            }
            string timestamp = DateTime.Now.ToString("HH:mm:ss");
            rtb.AppendText($"[{timestamp}] {data}\n");
            rtb.SelectionStart = rtb.Text.Length;
            rtb.ScrollToCaret();
        }

        private void LED1Control_Click(object sender, EventArgs e) { SendData(isLed1On ? "@le1_of&" : "@le1_on&"); }
        private void LED2Control_Click(object sender, EventArgs e) { SendData(isLed2On ? "@le2_of&" : "@le2_on&"); }
        private void LED3Control_Click(object sender, EventArgs e) { SendData(isLed3On ? "@le3_of&" : "@le3_on&"); }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Disconnect();
            base.OnFormClosing(e);
        }

        // -- CÁC HÀM TRỐNG ĐỂ TRÁNH LỖI CS0103 CHO DESIGNER --
        private void SendBox_TextChanged(object sender, EventArgs e) { }
        private void ReceiveBox_TextChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void COMSelectLabel_Click(object sender, EventArgs e) { }
        private void BaudrateSelectLabel_Click(object sender, EventArgs e) { }
        private void ConnectStatus_Click(object sender, EventArgs e) { }
        private void Switch1Count_TextChanged(object sender, EventArgs e) { }
        private void Switch2Count_TextChanged(object sender, EventArgs e) { }
        private void Switch3Count_TextChanged(object sender, EventArgs e) { }
        private void IPSelect_SelectedIndexChanged(object sender, EventArgs e) { }
        private void ControlGroup_Enter(object sender, EventArgs e) { }
        private void COMSelect_SelectedIndexChanged(object sender, EventArgs e) { }
        private void BaudrateSelect_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LED1Select_Click(object sender, EventArgs e) { LED1Control_Click(sender, e); }
        private void LED2Status_Click(object sender, EventArgs e) { LED2Control_Click(sender, e); }
        private void LED3Status_Click(object sender, EventArgs e) { LED3Control_Click(sender, e); }
    }
}