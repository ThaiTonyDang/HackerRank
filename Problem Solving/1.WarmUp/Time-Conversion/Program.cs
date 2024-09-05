using System;

namespace Time_Conversion
{
    internal class Program
    {
        public static string TimeConversion(string s)
        {
             int hour = Int32.Parse(s.Substring(0, 2));
             if (s.Substring(s.Length - 2, 2) == "AM" || hour == 12)
             {
                hour = 0;
             }
             if (s.Substring(s.Length - 2, 2) == "PM" || hour == 12)
             {
                 hour = (hour + 12) % 24;
             }

             return hour.ToString().PadLeft(2, '0') + s.Substring(2, 6);
        }

        public static string TimeStringConversion(string strTime)
        {
             string[] timeArr = strTime.Split(':'); // chia ở nơi được chọn, chuyển thành mảng
             string AMPM = timeArr[2].Substring(2); 
             string result = "";

             if (AMPM.Contains("PM"))
             {
                string hh = string.Empty;
                if (timeArr[0] == "12")
                {
                    hh = "12";
                }
                else if (Convert.ToInt16(timeArr[0]) + 12 == 24)
                {
                    hh = "00";
                }
                else
                {
                    hh = (Convert.ToInt16(timeArr[0]) + 12).ToString();
                }

                result = string.Concat(hh, ":", timeArr[1], ":", timeArr[2].Substring(0, 2));
             }

             else if (AMPM.Contains("AM"))
             {
                if (timeArr[0] == "12")
                {
                result = string.Concat("00:", timeArr[1], ":", timeArr[2].Substring(0, 2));
                }
                else
                {
                result = strTime.Substring(0, strTime.Length - 2);
                }
             }

             return result;
        }

        static void Main(string[] args)
        {
             string s = "07:01:00AM";
             string time = TimeStringConversion(s);
             Console.WriteLine(time);
        }
    }
}  