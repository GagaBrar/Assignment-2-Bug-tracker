using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2Bugtracker.Models.Helpers
{
    public static class ExtensionMethods
    {
        public static string ToDigitsOnly(this string str)
        {
            var stringNew = "";
            foreach (var i in str)
            {
                if (char.IsDigit(i))
                {
                    stringNew += i;
                }
            }
            return stringNew;
        }

        public static int AgeCalculator(this DateTimeOffset BirthDate)
        {
            var today = DateTime.Today;
            var todayDate = (today.Year * 100 + today.Month) * 100 + today.Day;
            var birthdate = (BirthDate.Year * 100 + BirthDate.Month) * 100 + BirthDate.Day;

            return (todayDate - birthdate) / 10000;
        }
    }
}