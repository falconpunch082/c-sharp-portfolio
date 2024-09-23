using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDate_2._3C
{
    class MyDate
    {
        // Declaring variables
        private int _year;
        private int _month;
        private int _day;

        // Decalring constants
        private static string[] MONTHS = { "Jan", "Feb", "Mar", "Apr", "May", "Jun",
                                            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        private static string[] DAYS = { "Sunday", "Monday", "Tuesday", "Wednesday",
                                            "Thursday", "Friday", "Saturday" };
        private static int[] DAYS_IN_MONTHS = { 31, 28, 31, 30, 31, 30,
                                                 31, 31, 30, 31, 30, 31 };

        // Constructor
        public MyDate(int day, int month, int year)
        {
            SetDate(day, month, year);
        }

        // Set methods
        public void SetYear(int year)
        {
            if (year < 1 || year > 9999)
            {
                throw new ArgumentOutOfRangeException("Invalid year!");
            }
            _year = year;
        }

        public void SetMonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException("Invalid month!");
            }
            _month = month;
        }

        public void SetDay(int day)
        {
            int dayMax = GetDaysInMonth(_year, _month);
            if (day < 1 || day > dayMax)
            {
                throw new ArgumentOutOfRangeException("Invalid day!");
            }
            _day = day;
        }

        public void SetDate(int day, int month, int year)
        {
            if (IsValidDate(year, month, day))
            {
                _year = year;
                _month = month;
                _day = day;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid year, month, or day!");
            }
        }

        // Get methods
        public int GetYear()
        {
            return _year;
        }

        public int GetMonth()
        {
            return _month;
        }

        public int GetDay()
        {
            return _day;
        }

        // Other methods
        public MyDate NextDay()
        {
            _day += 1; // Starts domino of updates with adding day

            if (_day > GetDaysInMonth(_year, _month)) // If next day is more than current month number of days
            {
                _day = 1; // Reset day to 1
                this.NextMonth();
            }

            return this;
        }

        public MyDate NextMonth()
        {
            _month += 1; // Starts domino of updates with adding month

            if (_month > 12) // If month is 13 (which does not exist), proceed to next year
            {
                _month = 1; // Reset month to January
                this.NextYear();
            }

            return this;
        }

        public MyDate NextYear()
        {
            _year += 1; // Starts domino of updates with adding year
            if (_year > 9999) // If year is 10000 then throw error
            {
                throw new InvalidOperationException("Year out of range!");
            }

            return this;
        }

        // No comments for Previous[x] methods because same concept for Next[x] methods, just -- instead of ++
        public MyDate PreviousDay()
        {
            _day -= 1;

            if (_day < 1)
            {
                this.PreviousMonth(); // Change month first
                _day = GetDaysInMonth(_year, _month); // Then, reset day to previous month's last date
            }

            return this;
        }

        public MyDate PreviousMonth()
        {
            _month -= 1;

            if (_month < 1)
            {
                _month = 12;
                this.PreviousYear();
            }

            return this;
        }

        public MyDate PreviousYear()
        {
            _year -= 1;
            if (_year < 1)
            {
                throw new InvalidOperationException("Year out of range!");
            }

            return this;
        }

        public override string ToString() // Override status because there is already a function named ToString() from the Object class
        {
            DateTime date = new DateTime(_year, _month, _day);
            return $"{DAYS[(int)date.DayOfWeek]} {_day} {MONTHS[_month - 1]} {_year}";
        }

        // Static methods
        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0); // Checks if the year can be divided by 4 and 100 OR by 400
        }

        public static bool IsValidDate(int year, int month, int day)
        {
            if (year < 1 || year > 9999 || month < 1 || month > 12) // Checks if year is between 1 and 9999 inclusive and if month is between 1 and 12 inclusive
            {
                return false;
            }

            int maxDay = GetDaysInMonth(year, month); // If month and year check is true, then check if day is within the maximum amount of days within a month
            return (day >= 1 && day <= maxDay);
        }

        public static int GetDayOfWeek(int day, int month, int year) // Using Tomohiko Sakamoto's Algorithm
        {
            // Array with leading number of days values
            int[] leading = { 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };

            // If month is less than 3, reduce year by 1
            if (month < 3)
            {
                year -= 1;
            }

            return ((year + year / 4 - year / 100 + year / 400 + leading[month - 1] + day) % 7);
        }

        private static int GetDaysInMonth(int year, int month)
        {
            if (month == 2 && IsLeapYear(year)) // For Februaries of leap years
            {
                return 29;
            }
            return DAYS_IN_MONTHS[month - 1]; // Else get day in months from constant array
        }
    }
}
