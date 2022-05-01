namespace Your.Name.Space
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text;

    public static class PersianDate
    {
        private static Dictionary<string, string> weekDay = new Dictionary<string, string>()
        {
            {"Saturday","شنبه" },
            {"Sunday","یک شنبه" },
            {"Monday","دوشنبه" },
            {"Tuesday","سه شنبه" },
            {"Wednesday","چهار شنبه" },
            {"Thursday","پنج شنبه" },
            {"Friday","جمعه" }
        };

        private static string[] yearMonth = new string[12] { "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند" };

        public static string ToShamsi(this DateTime date)
        {
            PersianCalendar calendar = new PersianCalendar();

            StringBuilder value = new StringBuilder();

            value.Append(calendar.GetYear(date) + " ");
            value.Append(weekDay[calendar.GetDayOfWeek(date).ToString()]);
            value.Append($" {calendar.GetDayOfMonth(date)} ");
            value.Append($" {yearMonth[calendar.GetMonth(date) - 1]} ");
            return value.ToString();

        }
    }
}
