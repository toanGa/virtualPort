﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualPort.BaiTapLon
{
    public partial class TestMoving : Form
    {

        Image boll1;
        Image boll2;
        Image boll3;
        Image bowling_pin;
        Image bestScore;
        Rectangle bollRect;

        Boolean bollState;
        const Boolean BOLL_READY = true;
        const Boolean BOLL_RUNNING = false;


        System.Drawing.Graphics graphics = null;
        System.Drawing.SolidBrush myBrush = null;
        System.Drawing.Rectangle rectangle;

        int barLocation = 0;
        const int BAR_LEFT = 0, BAR_RIGHT = 8;
        Boolean direction = true;
        const Boolean LEFT_TO_RIGHT = true;
        const Boolean RIGHT_TO_LEFT = false;

        int[] diemlan = new int[8];

        const Boolean PAUSE = false;
        const Boolean PLAY = true;

        Boolean systemState;

        int countGun = 0;
        const int MAX_COUNT = 7;


        int speed = 0;
        const int SPEED_MAX = 7;
        const int SPEED_MIN = 1;
        const int LOCAL_1 = 0, LOCAL_2 = 30, LOCAL_3 = 60,
            LOCAL_4 = 90, LOCAL_5 = 120, LOCAL_6 = 150,
            LOCAL_7 = 180, LOCAL_8 = 210, LOCAL_9 = 240;

        SerialPlay serial = null;
        Thread serialProcess = null;
        const String SERIAL_UP = "up";
        const String SERIAL_DOWN = "down";
        const String SERIAL_OK = "ok";
        const String SERIAL_RESET = "reset";
        const String SERIAL_PAUSE = "pause";


        public delegate void AddDataDelegate(String myString);////////
        public AddDataDelegate myDelegate;///////////////
        public TestMoving()
        {
            InitializeComponent();
            try
            {
                serial = new SerialPlay("COM2");
            }
            catch (Exception e)
            {
                MessageBox.Show("khong the choi qua cong com");
            }

            CreatComponent();

            //serialProcess = new Thread(SerialProc);
            //serialProcess.Start();

            serialPort1.Open();

            this.myDelegate = new AddDataDelegate(AddDataMethod);//////////
        }

        /// <summary>
        /// test data show on label
        /// </summary>
        /// <param name="myString"></param>
        public void AddDataMethod(String myString)
        {
            //labelTest.Text = myString;
            //labelTest.Invoke(this.myDelegate, new Object[] { myString });
            textBox1.Text = myString;
        }

        void CreatComponent()
        {
            //mainGraphic = 
            boll1 = VirtualPort.Properties.Resources.icon1;
            boll2 = VirtualPort.Properties.Resources.icon2;
            boll3 = VirtualPort.Properties.Resources.icon3;

            bowling_pin = VirtualPort.Properties.Resources.bowling_pin;
            bestScore = VirtualPort.Properties.Resources.best_score;
            bollRect = new Rectangle(305, 355, 30, 30);

            bollState = BOLL_READY;
            timer2.Enabled = false;

            systemState = PLAY;
            speed = 4;
            for (int i = 1; i <= 7; i++)
            {
                diemlan[i] = 0;
            }


            //creat graphics
            graphics = label2.CreateGraphics();
            //imageBackground = Image.FromFile("C:\\Users\\toan\\Desktop\\hinh\\jangmi.jpg");
            myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        }

        /// <summary>
        ///  draw speed bar start up
        /// </summary>
        void DrawSpeedBar()
        {
            rectangle = new System.Drawing.Rectangle(
                barLocation * 30, 0, 10, 10);


            //graphics.DrawEllipse(System.Drawing.Pens.Black, rectangle);
            //graphics.DrawRectangle(System.Drawing.Pens.Red, rectangle);
            // graphics.
            graphics.FillRectangle(myBrush, rectangle);
            Thread.Sleep(100);
            //label1.BackColor = Color.Blue;
            //graphics.Dispose();
            graphics.Clear(Color.White);
        }



        int bollLocate = 0;
        private void TestMoving_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(boll1, bollRect);
            if (bollLocate == 0)
            {
                g.DrawImage(boll1, bollRect);
            }
            else if (bollLocate == 1)
            {
                g.DrawImage(boll2, bollRect);
            }else
                g.DrawImage(boll3, bollRect);

            //Thread thread = new Thread(DrawBackground);
        }

        int test = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            checker.Text = "" + test;
            test++;
            if (direction == LEFT_TO_RIGHT)
                if (barLocation == 8)
                {
                    direction = RIGHT_TO_LEFT;
                }
                else
                {
                    barLocation++;
                }
            else// direction is right to left
            {
                if (barLocation == 0)
                {
                    direction = LEFT_TO_RIGHT;
                }
                else
                {
                    barLocation--;
                }
            }
            DrawSpeedBar();
        }


        private void ok_Click(object sender, EventArgs e)
        {
            ok_Event();
        }


        int currentPoint;
        void ok_Event()
        {
            if (bollState == BOLL_READY)
            {
                timer2.Enabled = true;
                bollState = BOLL_RUNNING;
                //MessageBox.Show("nem xong");

            }
            else if (bollState == BOLL_RUNNING)
            {

            }

            countGun++;
            if (countGun == MAX_COUNT + 1)
            {
                countGun = 7;
            }


            if (countGun == 1)
            {
                diemlan[1] = GetPoint();
                diemlan1.Text = "" + diemlan[1];
            }
            else if (countGun == 2)
            {
                diemlan[2] = GetPoint();
                diemlan2.Text = "" + diemlan[2];
            }
            else if (countGun == 3)
            {
                diemlan[3] = GetPoint();
                diemlan3.Text = "" + diemlan[3];
            }
            else if (countGun == 4)
            {
                diemlan[4] = GetPoint();
                diemlan4.Text = "" + diemlan[4];
            }
            else if (countGun == 5)
            {
                diemlan[5] = GetPoint();
                diemlan5.Text = "" + diemlan[5];
            }
            else if (countGun == 6)
            {
                diemlan[6] = GetPoint();
                diemlan6.Text = "" + diemlan[6];
            }
            else if (countGun == 7)
            {
                diemlan[7] = GetPoint();
                diemlan7.Text = "" + diemlan[7];
                countGun = 0;
                MessageBox.Show("het luot choi");

                int total = 0;
                foreach (int i in diemlan)
                {
                    total += i;
                }
                MessageBox.Show("tong diem la:" + total);
                Resetpoint();
            }
            currentPoint = diemlan[countGun];
        }
        private void speedUp_Click(object sender, EventArgs e)
        {
            if (systemState == PLAY)
                if (speed == SPEED_MIN) { }
                else
                {
                    lock (syncObj1)
                    {
                        speed--;
                        timer1.Interval = speed * 100;
                    }
                    
                    
                } 
        }

        private void speedDown_Click(object sender, EventArgs e)
        {
            if (systemState == PLAY)
                if (speed == SPEED_MAX) { }
                else
                {
                    speed++;
                    timer1.Interval = speed * 100;
                } 
        }

        private void reset_Click(object sender, EventArgs e)
        {
            speed = 4;
            timer1.Interval = speed * 100;
            for (int i = 1; i <= 7; i++)
            {
                diemlan[i] = 0;
            }
            diemlan1.Text = "lan 1";
            diemlan2.Text = "lan 2";
            diemlan3.Text = "lan 3";
            diemlan4.Text = "lan 4";
            diemlan5.Text = "lan 5";
            diemlan6.Text = "lan 6";
            diemlan7.Text = "lan 7";

            systemState = PLAY;
            countGun = 0;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (systemState == PAUSE)
            {
                systemState = PLAY;
                timer1.Enabled = true;
            }
            else
            {
                systemState = PAUSE;
                timer1.Enabled = false;
            } 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            bollLocate++;
            if (bollLocate == 3)
            {
                bollLocate = 0;
            }
            //bollRect.X += 3;
            bollRect.Y -= 10;
            if (bollRect.Y == 125)
            {
                //Image img = Image.FromFile(@"C:\Users\toan\Desktop\bowling\best-score.ipg");
                timer2.Enabled = false;
                //pictureBox1.Image = img;
                bollRect.X = 305;
                bollRect.Y = 355;
                //MessageBox.Show("nem xong");
                if(currentPoint == 10)
                    pictureBox1.Image = bestScore;

                bollState = BOLL_READY;
                timer2.Enabled = false;
                timer3.Enabled = true;
                //Thread.Sleep(2000);
                //pictureBox1.Image = bowling_pin;
            }

            Invalidate();
        }

        int GetPoint()
        {
            int point = 0;
            if ((barLocation == BAR_LEFT) | (barLocation == BAR_RIGHT))
            {
                point = 0;
            }
            else if ((barLocation == 1) | (barLocation == 7))
            {
                point = 1;
            }
            else if ((barLocation == 2) | (barLocation == 6))
            {
                point = 2;
            }
            else if ((barLocation == 3) | (barLocation == 5))
            {
                point = 5;
            }
            else if ((barLocation == 4))
            {
                point = 10;
            }

            return point;
        }

        void Resetpoint()
        {
            for (int i = 1; i <= 7; i++)
            {
                diemlan[i] = 0;
            }
            diemlan1.Text = "lan 1";
            diemlan2.Text = "lan 2";
            diemlan3.Text = "lan 3";
            diemlan4.Text = "lan 4";
            diemlan5.Text = "lan 5";
            diemlan6.Text = "lan 6";
            diemlan7.Text = "lan 7";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = bowling_pin;
            timer3.Enabled = false;
        }


        static object syncObj1 = new object();
        void SerialProc()
        {
            String datain;// = serial.GetDataIncome();
            while (true)
            {

                if (serial.IsDataIn())
                {
                    datain = serial.GetDataIncome();
                    if (datain == SERIAL_UP)
                    {
                        
                            if (systemState == PLAY)
                                if (speed == SPEED_MIN) { }
                                else
                                {
                                    lock (syncObj1)
                                    {
                                        speed--;
                                        timer1.Interval = speed * 100;
                                    }
                                    
                                    
                                }
                            //MessageBox.Show("up speed" + speed);
                        
                        
                        //while (serial.GetDataIncome() == SERIAL_UP) ;
                    }
                    else if (datain == SERIAL_DOWN)
                    {
                        if (systemState == PLAY)
                            if (speed == SPEED_MAX) { }
                            else
                            {
                                speed++;
                                timer1.Interval = speed * 100;
                            }
                        //MessageBox.Show("up down" + speed);
                        //while (serial.GetDataIncome() == SERIAL_DOWN) ;
                    }
                    else if (datain == SERIAL_OK)
                    {
                        //ok_Event();
                        if (bollState == BOLL_READY)
                        {
                            timer2.Enabled = true;
                            bollState = BOLL_RUNNING;
                            //MessageBox.Show("nem xong");

                        }
                    }
                    else if (datain == SERIAL_RESET)
                    {

                    }
                    else if (datain == SERIAL_PAUSE)
                    {

                    }

                    serial.ResetFlag();
                }
                Thread.Sleep(500);

            }
        }

        private delegate void DelegateHienThiDuLieuNhan(String dataIn);
        void ProcDLDen(String s)
        {
            if (this.labelTest.InvokeRequired)
            {
                DelegateHienThiDuLieuNhan myDelegate = new DelegateHienThiDuLieuNhan(ProcDLDen);
                textBox1.Invoke(myDelegate, new object[] { s });
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
            
            String data = serialPort1.ReadExisting();
            Console.WriteLine("data nhan: " + data);
            MessageBox.Show("ddd" +  data);
            //labelTest.Text = data;
            //AddDataMethod(data);
            ProcDLDen(data);
            /*
            String data = serialPort1.ReadExisting();
            if (data == SERIAL_UP)
                    {
                        
                            if (systemState == PLAY)
                                if (speed == SPEED_MIN) { }
                                else
                                {
                                    lock (syncObj1)
                                    {
                                        speed--;
                                        timer1.Interval = speed * 100;
                                    }
                                    
                                    
                                }
                            //MessageBox.Show("up speed" + speed);
                        
                        
                        //while (serial.GetDataIncome() == SERIAL_UP) ;
                    }
                    else if (data == SERIAL_DOWN)
                    {
                        if (systemState == PLAY)
                            if (speed == SPEED_MAX) { }
                            else
                            {
                                speed++;
                                timer1.Interval = speed * 100;
                            }
                        //MessageBox.Show("up down" + speed);
                        //while (serial.GetDataIncome() == SERIAL_DOWN) ;
                    }
                    else if (data == SERIAL_OK)
                    {
                        //ok_Event();
                        if (bollState == BOLL_READY)
                        {
                            timer2.Enabled = true;
                            bollState = BOLL_RUNNING;
                            //MessageBox.Show("nem xong");

                        }
                    }
                    else if (data == SERIAL_RESET)
                    {

                    }
                    else if (data == SERIAL_PAUSE)
                    {

                    }

                    serial.ResetFlag();
                */
        } 
             

    }
}
