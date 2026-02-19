using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HidSharp;

namespace USBControl
{
    public partial class Form_SampleUSB : Form
    {
        
        // Khai báo biến cho thư viện HidSharp
        HidSharp.HidDevice _myDevice;
        HidSharp.HidStream _myStream;
        System.Windows.Forms.Timer _connectTimer;
        public Form_SampleUSB()
        {
            InitializeComponent();
            
            // Cấu hình Timer để quét thiết bị liên tục (200ms một lần)
            _connectTimer = new System.Windows.Forms.Timer();
            _connectTimer.Interval = 200;
            _connectTimer.Tick += _connectTimer_Tick; // Tạo sự kiện Tick
            _connectTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            textBox_VID.Text = "04d8";
            textBox_PID.Text = "0001";
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Do you want to exit the program?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void _connectTimer_Tick(object sender, EventArgs e)
        {
            TryConnect();
            ReadData();
        }

        // Xử lý kết nối thiết bị
        private void TryConnect()
        {
            if (_myDevice != null) return; // Đã kết nối rồi thì bỏ qua

            var dev = DeviceList.Local.GetHidDeviceOrNull(0x04d8, 0x0001);
            if (dev == null) return;

            try
            {
                _myDevice = dev;
                if (_myDevice.TryOpen(out _myStream))
                {
                    _myStream.ReadTimeout = 50;
                    UpdateConnectionUI(connected: true);
                }
            }
            catch
            {
                _myDevice = null;
            }
        }

        // Đọc dữ liệu từ thiết bị
        private void ReadData()
        {
            if (_myStream == null) return;

            try
            {
                byte[] buff = new byte[64];
                int bytesRead = 0;

                try
                {
                    bytesRead = _myStream.Read(buff, 0, buff.Length);
                }
                catch (TimeoutException)
                {
                    return; // Không có dữ liệu mới -> bỏ qua
                }

                if (bytesRead > 0)
                {
                    UpdateDataUI(buff);
                }
            }
            catch (Exception)
            {
                HandleDisconnect();
            }
        }

        // Cập nhật giao diện khi có dữ liệu mới
        private void UpdateDataUI(byte[] buff)
        {
            textBox_SW0.Text = buff[1].ToString();
            textBox_SW1.Text = buff[2].ToString();
            textBox_SW2.Text = buff[3].ToString();
            toolStripStatusLabel_InforDevice.Text = "New Received Data";
        }

        // Cập nhật giao diện kết nối/ngắt kết nối
        private void UpdateConnectionUI(bool connected)
        {
            if (connected)
            {
                textBox_Status.Text = "Connected!";
                textBox_Status.BackColor = Color.Lime;
                toolStripStatusLabel_InforDevice.Text = "Device Connected";
            }
            else
            {
                textBox_Status.Text = "Disconnected!";
                textBox_Status.BackColor = Color.Red;
                toolStripStatusLabel_InforDevice.Text = "Device Disconnected";
            }
        }

        // Xử lý khi mất kết nối đột ngột
        private void HandleDisconnect()
        {
            if (_myStream != null) _myStream.Close();
            _myDevice = null;
            _myStream = null;
            UpdateConnectionUI(connected: false);
        }

        // Hàm này sẽ tính toán xem cần bật những đèn nào và gửi xuống USB
        private void SendLedData(object sender, EventArgs e)
        {
            // Nếu chưa kết nối USB thì không làm gì cả
            if (_myDevice == null || _myStream == null) return;

            try
            {
                byte[] buff = new byte[64];
                buff[0] = 0x00; // Report ID

                // Tính toán byte dữ liệu dựa trên trạng thái 8 ô checkbox
                // Logic: Mỗi ô checkbox tương ứng với 1 bit (1 dòng điện)
                byte ledStatus = 0;

                if (checkBox_LED1.Checked) ledStatus += 1;   // 2^0 -> Bit 0 (RD0)
                if (checkBox_LED2.Checked) ledStatus += 2;   // 2^1 -> Bit 1 (RD1)
                if (checkBox_LED3.Checked) ledStatus += 4;   // 2^2 -> Bit 2 (RD2)
                if (checkBox_LED4.Checked) ledStatus += 8;   // 2^3 -> Bit 3 (RD3)
                if (checkBox_LED5.Checked) ledStatus += 16;  // 2^4 -> Bit 4 (RD4)
                if (checkBox_LED6.Checked) ledStatus += 32;  // 2^5 -> Bit 5 (RD5)
                if (checkBox_LED7.Checked) ledStatus += 64;  // 2^6 -> Bit 6 (RD6)
                if (checkBox_LED8.Checked) ledStatus += 128; // 2^7 -> Bit 7 (RD7)

                buff[1] = ledStatus; // Gán giá trị tổng vào byte số 1

                // Gửi xuống mạch
                _myStream.Write(buff, 0, buff.Length);
            }
            catch (Exception ex)
            {
                // Có thể hiện lỗi hoặc bỏ qua nếu muốn
            }
        }
    }
}
