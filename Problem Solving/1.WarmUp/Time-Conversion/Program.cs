using System;
using System.Text;

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

        static string TimeConvert(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            string period = sb.ToString().Substring(8, 2);
            int hour = int.Parse(sb.ToString().Substring(0, 2));

            sb.Length = 8;
            if (period.Equals("am", StringComparison.OrdinalIgnoreCase))
            {
                if (hour == 12)
                {
                    sb[0] = '0';
                    sb[1] = '0';
                }
            }
            else if (period.Equals("pm", StringComparison.OrdinalIgnoreCase))
            {
                if (hour != 12)
                {
                    hour += 12;
                    sb[0] = (hour / 10).ToString()[0];
                    sb[1] = (hour % 10).ToString()[0];
                }
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {
             string s = "05:01:00PM";
             string time = TimeStringConversion(s);
             Console.WriteLine(time);
        }
    }
}  