using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.Project
{
    public partial class Embedded : Form
    {
        public const bool ON = true;
        public const bool OFF = false;

        Light light = null;
        Span span = null;
        TV tv = null;

        Color onColor;
        Color offColor;

        const String LIGH_ON = "1";
        const String LIGH_OFF = "2";
        const String TV_ON = "3";
        const String TV_OFF = "4";
        const String SPAN_ON = "5";
        const String SPAN_OFF = "6";

        public Embedded()
        {
            InitializeComponent();
            light = new Light();
            span = new Span();
            tv = new TV();

            onColor = Color.FromArgb(70, 250, 15);
            offColor = Color.FromArgb(15, 80, 100);
            label1.Text = "hello world";

            serialPort1.Open();
            //if (tv.InsertToDb() == 1)
                //MessageBox.Show("ok man chay duoc roi");
            //ServiceAccess();
        }

        public void ServiceAccess()
        {
            ServiceReference1.Service1Client client = new
                ServiceReference1.Service1Client();

            ServiceReference1.Device device = new ServiceReference1.Device();
            device.date = DateTime.Now.Date.ToString();
            device.name = "TV";
            device.minute = 203;
            device.hour = (float)2.3;
            device.money = (float)3.3;

            device.note = "this access from client in winform";

            
            if (client.InsertDevice(device) == 1)
            {
                MessageBox.Show("insert success");
            }
        }

        public int GetDayNow()
        {
            return DateTime.Now.Day;

        }

        public int GetMonthNow()
        {
            return DateTime.Now.Month;
        }

        public int GetYearNow()
        {
            return DateTime.Now.Year;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //light.StartCountTime();
            //serialPort1.Write("light start");
            //ServiceAccess();
            if (light.state == OFF)
            {
                light.StartCountTime();
                light.state = ON;
                button1.BackColor = onColor;
                serialPort1.Write(LIGH_ON);
                label1.Text = light.dateTimeOpen + "";
                label2.Text = "";
                label3.Text = "";
            }
            else
            {
                light.StopCountTime();
                light.state = OFF;
                serialPort1.Write(LIGH_OFF);
                light.UpdateForThisRun();


                button1.BackColor = offColor;
                label1.Text = "" + (light.totalMinute) + "m";
                label2.Text = "" + light.totalHour + "h";
                label3.Text = "money :" + light.totalMoney;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //light.StartCountTime();
            if (tv.state == OFF)
            {
                
                serialPort1.Write(TV_ON);
                tv.StartCountTime();
                tv.state = ON;
                button2.BackColor = onColor;
                label4.Text = tv.dateTimeOpen + "";
                label5.Text = "";
                label6.Text = "";
            }
            else
            {
                serialPort1.Write(TV_OFF);
                tv.StopCountTime();
                tv.state = OFF;
                tv.UpdateForThisRun();


                button2.BackColor = offColor;
                label4.Text = "" + (tv.totalMinute) + "m";
                label5.Text = "" + tv.totalHour + "h";
                label6.Text = "money :" + tv.totalMoney;
            }
        }

        // xu ly phan hien thi du lieu den
        private delegate void DelegateHienThiDuLieuNhan(String dataIn);
        void ProcDLDen(String s)
        {
            if (this.labelTest.InvokeRequired)
            {
                DelegateHienThiDuLieuNhan myDelegate = new DelegateHienThiDuLieuNhan(ProcDLDen);
                labelTest.Invoke(myDelegate, new object[] { s });
                //labelTest.Text = s;


            }
            else
            {
                //textBox1.Text = s;
                labelTest.Text = s;
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            MessageBox.Show("has data income");
            SerialPort sp = (SerialPort)sender;
            String dataIn = sp.ReadExisting();
            //label1.Text = dataIn;
            //Thread demoThread =
                //new Thread(new ThreadStart(this.ThreadProcUnsafe));

            //demoThread.Start();
            ProcDLDen(dataIn);

        }

        private void ThreadProcUnsafe()
        {
            try
            {
                label1.Text = "This text was set unsafely.";
            }
            catch(Exception e)
            {
                MessageBox.Show("error receive");
            }
            
        }

        private void Embedded_FormClosing(object sender, FormClosingEventArgs e)
        {
            Thread th = new Thread(SaveBeforeClose);
            th.Start();
            /*
            serialPort1.Close();
            if (light.totalMoney != 0)
            {
                if (light.InsertToDb() == 1)
                {
                    MessageBox.Show("insert light!");
                }
                else
                {
                    MessageBox.Show("error insert light");
                }
                
            }
            if (span.totalMoney != 0)
            {
                if (span.InsertToDb() == 1)
                {
                    MessageBox.Show("insert span!");

                }
                else
                {
                    MessageBox.Show("error insert span");
                }
            }
            if (tv.totalMoney != 0)
            {
                if (tv.InsertToDb() == 1)
                {
                    MessageBox.Show("insert tv!");
                }
                else
                {
                    MessageBox.Show("error insert tv");
                }
            }
             * */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //light.StartCountTime();
            if (span.state == OFF)
            {
                serialPort1.Write(SPAN_ON);
                span.StartCountTime();
                span.state = ON;
                button3.BackColor = onColor;
                label8.Text = span.dateTimeOpen + "";
                label9.Text = "";
                label10.Text = "";
            }
            else
            {
                serialPort1.Write(SPAN_OFF);
                span.StopCountTime();
                span.state = OFF;
                span.UpdateForThisRun();


                button3.BackColor = offColor;
                label8.Text = "" + span.totalMinute + "m";
                label9.Text = "" + span.totalHour + "h";
                label10.Text = "money :" + span.totalMoney;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            SaveBeforeClose();
        }

        private void Embedded_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        public void SaveBeforeClose()
        {
            //serialPort1.Close();
            if (light.state == ON)
            {
                light.StopCountTime();
                light.state = OFF;
                //serialPort1.Write(LIGH_OFF);
                light.UpdateForThisRun();
            }
            if (tv.state == ON)
            {
                tv.StopCountTime();
                tv.state = OFF;
                //serialPort1.Write(LIGH_OFF);
                tv.UpdateForThisRun();
            }
            if (span.state == ON)
            {
                span.StopCountTime();
                span.state = OFF;
                //serialPort1.Write(LIGH_OFF);
                span.UpdateForThisRun();
            }
                
            if (light.totalMoney != 0)
            {
                if (light.InsertToDb() == 1)
                {
                    MessageBox.Show("insert light!");
                }
                else
                {
                    MessageBox.Show("error insert light");
                }

            }
            if (span.totalMoney != 0)
            {
                if (span.InsertToDb() == 1)
                {
                    MessageBox.Show("insert span!");

                }
                else
                {
                    MessageBox.Show("error insert span");
                }
            }
            if (tv.totalMoney != 0)
            {
                if (tv.InsertToDb() == 1)
                {
                    MessageBox.Show("insert tv!");
                }
                else
                {
                    MessageBox.Show("error insert tv");
                }
            }

            //serialPort1.Write("A");
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();

            MessageBox.Show("tong so tien trong thang:" + new Device1().GetTotalMoneyInMonth(Int32.Parse(mn), Int32.Parse(yy)));
            MessageBox.Show("tong so tien trong ngay:" + new Device1().GetTotalMoneyInDay(Int32.Parse(dy), Int32.Parse(mn), Int32.Parse(yy)));
        }

        private void button5_Click(object sender, EventArgs e)
        {

            serialPort1.Write("A");
            String sDate = DateTime.Now.ToString();
            DateTime datevalue = (Convert.ToDateTime(sDate.ToString()));

            String dy = datevalue.Day.ToString();
            String mn = datevalue.Month.ToString();
            String yy = datevalue.Year.ToString();
            MessageBox.Show("day:" + dy + ",month:" + mn + ",year:" + yy);
            
        }

        int xemDay;
        int xemMonth;
        int xemYear;
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            xemDay = monthCalendar1.SelectionStart.Day;
            xemMonth = monthCalendar1.SelectionStart.Month;
            xemYear = monthCalendar1.SelectionStart.Year;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String hienThi = "Tổng số tiền điện trong ngày:" + xemDay + "-" + xemMonth + "-" + xemYear + ":";
            hienThi += new Device1().GetTotalMoneyInDay(xemDay, xemMonth, xemYear) + "  ngàn đồng";
            hienThi += "\nTổng số tiền trong tháng:" + xemMonth + "-" + xemYear + ":";
            hienThi += new Device1().GetTotalMoneyInMonth(xemMonth, xemYear) + "  ngàn đồng";

            label13.Text = hienThi;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


    }
}
