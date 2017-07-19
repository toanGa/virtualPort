using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace VirtualPort.Project
{
    class Device1
    {
        protected String name = "";
        public String note = "";
        const bool ON = true;
        const bool OFF = false;
        const int POWER = 25;
        const float MONEY_KWH = (float)2.5;

        protected float power = (float) 0.1;

        public bool state;
        public float moneyPayOneTimeRun = 0;


        Timer timer = new Timer();
        public DateTime dateTimeOpen;
        public DateTime dateTimeClose;

        public int totalMinute;
        public float totalHour;
        public float totalMoney;
        public Device1()
        {
            ResetState();
            
        }

        public void ResetState()
        {
            state = OFF;
            totalHour = 0;
            totalMinute = 0;
            totalMoney = 0;
            timer.Enabled = false;
            timer.Interval = 1000;
        }
        public void UpdateForThisRun()
        {
            totalHour += GetTotalHourRun();
            totalMinute += (int)GetTotalMinuteRun();
            totalMoney += MoneyPayForThisRun();
        }

        public String GetDateNow()
        {
            return DateTime.Now.Date.ToString("d");
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
        


        public void StartCountTime()
        {
            dateTimeOpen = DateTime.Now;
        }


        public void StopCountTime()
        {
            dateTimeClose = DateTime.Now;
        }


        public void ResetCountTime()
        {
            
        }

        public TimeSpan getTimeSpan()
        {
            TimeSpan timeSpan = (TimeSpan)(dateTimeClose.Subtract(dateTimeOpen));
            //return (TimeSpan)(dateTimeClose.Subtract(dateTimeOpen));
            Console.WriteLine(timeSpan);
            Console.WriteLine((int)timeSpan.TotalSeconds);
            return timeSpan;
        }

        public int GetTotalSecondRun()
        {
            TimeSpan timeSpan = (TimeSpan)(dateTimeClose.Subtract(dateTimeOpen));
            return (int)timeSpan.TotalSeconds;
        }

        public float GetTotalMinuteRun()
        {
            TimeSpan timeSpan = (TimeSpan)(dateTimeClose.Subtract(dateTimeOpen));
            return (float)timeSpan.TotalMinutes;
        }

        public float GetTotalHourRun()
        {
            TimeSpan timeSpan = (TimeSpan)(dateTimeClose.Subtract(dateTimeOpen));
            return (float)timeSpan.TotalHours;
        }

        public float MoneyPayForThisRun()
        {
            return (float)(GetTotalHourRun() * power * MONEY_KWH);
        }

        public int InsertToDb()
        {
            int x = 0;
            //try
            //{                
                ServiceReference1.Service1Client client = new
                    ServiceReference1.Service1Client();
                ServiceReference1.Device device = new ServiceReference1.Device();
                device.name = name.ToString();
                device.day = GetDayNow();
                device.month = GetMonthNow();
                device.year = GetYearNow();
            //System.Math.round(totalHour,4)
                device.hour = (float)System.Math.Round((double)totalHour,4);
                device.minute = totalMinute;
                device.money = (float)System.Math.Round((double)totalMoney, 4);
                device.note = note.ToString();
                Console.WriteLine(device.hour + "," + device.money + "," + device.month + "," + device.name);
                x = client.InsertDevice(device);

                
                return x;
            //}
            //catch (Exception e)
            //{

            //}
            //return x;
        }

        public int UpdateToDb(ServiceReference1.Device oldDevice)
        {
            int x = 0;
            try
            {
                ServiceReference1.Service1Client client = new
                    ServiceReference1.Service1Client();
                ServiceReference1.Device device = new ServiceReference1.Device();
                device.name = name;
                device.day = GetDayNow();
                device.month = GetMonthNow();
                device.year = GetYearNow();
                device.hour = totalHour;
                device.minute = totalMinute;
                device.money = totalMoney;
                device.note = note;

                x = client.UpdateDevice(oldDevice,device);

                return x;
            }
            catch (Exception e)
            {

            }
            return x;
        }

        public int DeleteInDb()
        {
            int x = 0;
            try
            {
                ServiceReference1.Service1Client client = new
                    ServiceReference1.Service1Client();
                ServiceReference1.Device device = new ServiceReference1.Device();
                device.name = name;
                device.day = GetDayNow();
                device.month = GetMonthNow();
                device.year = GetYearNow();
                device.hour = totalHour;
                device.minute = totalMinute;
                device.money = totalMoney;
                device.note = note;

                x = client.DeleteDeviceInDay(device.name,device.year,device.month,device.day);

                return x;
            }
            catch (Exception e)
            {

            }
            return x;
        }

        public float GetTotalMoneyInMonth(int month,int year)
        {
            ServiceReference1.Service1Client client = new
                    ServiceReference1.Service1Client();
            return client.TotalMoneyInMonth(month,year);
        }

        public float GetTotalMoneyInDay(int day,int month, int year)
        {
            ServiceReference1.Service1Client client = new
                    ServiceReference1.Service1Client();
            return client.TotalMoneyInDay(day,month, year);
        }
    }
}
