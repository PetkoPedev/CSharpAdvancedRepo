using System;
using System.Collections.Generic;
using System.Text;

namespace P05_DateModifier
{
    public class DateModifier
    {
        private DateTime DateOne;
        private DateTime DateTwo;

        public DateModifier(DateTime date1, DateTime date2)
        {
            this.DateOne = date1;
            this.DateTwo = date2;
        }

        public double DifferenceInDates()
        {
            return Math.Abs((DateTwo - DateOne).TotalDays);
        }
    }
}
