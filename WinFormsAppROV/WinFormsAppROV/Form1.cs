using System;
using System.IO.Ports;

namespace WinFormsAppROV

{
    public partial class Form1 : Form
    {

        private string[] baudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
        private SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            cbxCOM.DataSource = SerialPort.GetPortNames();
            cbxBaudrate.DataSource = baudRate;

            if (serialPort.IsOpen)
            {
                MessageBox.Show("Đã kết nối");
                statusConnect();
            }
            else
            {
                MessageBox.Show("Chưa kết nối");
                statusDisConnect();
            }
        }

        private void statusConnect()
        {
            lbStatus.Text = ("Đã kết nối");
            lbStatus.ForeColor = Color.Green;
            btnConnect.Enabled = false;
            btnDisConnect.Enabled = true;
        }

        private void statusDisConnect()
        {
            lbStatus.Text = ("Chưa kết nối");
            lbStatus.ForeColor = Color.Red;
            btnConnect.Enabled = true;
            btnDisConnect.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                string com = cbxCOM.Text;
                string baudrate = cbxBaudrate.Text;
                serialPort.PortName = com;
                serialPort.BaudRate = Convert.ToInt32(baudrate);
                serialPort.Open();
                statusConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                statusDisConnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}