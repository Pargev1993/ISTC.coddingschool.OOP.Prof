using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        public static int howManySundays(int s, string startD)
        {
            return (s + convertDayToInt(startD)) / 7;

        }

        public static int convertDayToInt(string Day)
        {
            switch (Day)
            {
                case "Sunday":
                    return 0;
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                default:
                    return 6;
            }

        }

        static void Main(string[] args)
        {
            int n = 9;
            string startDay = "Saturday";
            howManySundays(n, startDay);
        }
    }
}
