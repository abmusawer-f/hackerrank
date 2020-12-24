using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Classes
{
    public static class TimeConversion
    {
        public static string timeConversion(string s)
        {
            DateTime dateTime = DateTime.Parse(s);
            return dateTime.ToString("HH:mm:ss");

        }
    }
}
