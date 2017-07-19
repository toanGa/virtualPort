using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.mrQuy
{
    public partial class mrQuy : Form
    {
        public mrQuy()
        {
            InitializeComponent();
            try
            {
                serialPort1.Open();
            }
            catch(Exception e)
            {
                MessageBox.Show("error open serial port");
            }
        }


        // xu ly phan hien thi du lieu den
        private delegate void DelegateHienThiDuLieuNhan(String dataIn);
        void ProcDLDen(String s)
        {
            if (this.label1.InvokeRequired)
            {
                DelegateHienThiDuLieuNhan myDelegate = new DelegateHienThiDuLieuNhan(ProcDLDen);
                label1.Invoke(myDelegate, new object[] { s });
                //labelTest.Text = s;


            }
            else
            {
                //textBox1.Text = s;
                label1.Text = s;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            String dataIn = sp.ReadExisting();
            //label1.Text = dataIn;
            //Thread demoThread =
            //new Thread(new ThreadStart(this.ThreadProcUnsafe));

            //demoThread.Start();
            ProcDLDen(dataIn);
        }
    }
}
