using System;
using System.Globalization;

namespace PersianDateConverter
{
    public class Converter
    {
        private static PersianCalendar pc = new PersianCalendar();

        public static DateTime ToGregorian(string persianDate)
        {
            string[] parts = persianDate.Split('/');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        }

        public static string ToPersian(DateTime date)
        {
            int year = pc.GetYear(date);
            int month = pc.GetMonth(date);
            int day = pc.GetDayOfMonth(date);
            return $"{year}/{month}/{day}";
        }

        public static bool IsValidPersianDate(string persianDate)
        {
            try
            {
                ToGregorian(persianDate);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
