using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyDate_2._3C
{
    internal class TestMyDate
    {
        static void Main(string[] args)
        {
            // Test cases
            MyDate date = new MyDate(14, 2, 2023); // Tuesday, 14th February 2023
            Console.WriteLine(date.ToString());

            MyDate nextDay = date.NextDay(); // 14/02/23  -> 15/02/23
            Console.WriteLine(nextDay.ToString());

            MyDate nextMonth = date.NextMonth(); // 15/02/23  -> 15/03/23
            Console.WriteLine(nextMonth.ToString());

            MyDate nextYear = date.NextYear(); // 15/03/23  -> 15/03/24
            Console.WriteLine(nextYear.ToString());

            MyDate prevDay = date.PreviousDay(); // 15/03/24  -> 14/03/24
            Console.WriteLine(prevDay.ToString());

            MyDate prevMonth = date.PreviousMonth(); // 14/03/24  -> 14/02/24
            Console.WriteLine(prevMonth.ToString());

            MyDate prevYear = date.PreviousYear(); // 14/02/24  -> 14/02/23
            Console.WriteLine(prevYear.ToString());

            Console.WriteLine($"Is 2020 a leap year? {MyDate.IsLeapYear(2020)}");

            Console.WriteLine($"Is 2023-02-29 a valid date? {MyDate.IsValidDate(2023, 2, 29)}");

            Console.WriteLine($"Day of the week for 2023-02-14: {MyDate.GetDayOfWeek(14, 2, 2023)}");
        }
    }
}
