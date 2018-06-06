using System;

namespace DailyCode
{
    internal class TimeConversion
    {
        //Given a time in -hour AM/PM format, convert it to military (24-hour) time.

        public String getMiliTime(String s)
        {
            String converted = s;

            if (converted.Contains("AM"))
            {
                converted = converted.Substring(0, converted.Length - 2);
                if (converted.Substring(0, 2).Equals("12"))
                {
                    converted = "00" + converted.Substring(2);
                }
            }
            else if (converted.Contains("PM"))//contains PM
            {
                converted = converted.Substring(0, converted.Length - 2);
                String temp = converted.Substring(0, 2);
                int hour = Int32.Parse(temp);
                if (hour != 12) hour += 12;
                converted = hour + converted.Substring(2);
            }

            return converted;
        }
    }
}