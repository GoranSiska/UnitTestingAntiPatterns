using System;

namespace Misspecification.TestClasses
{
    public class DateConverter
    {
        public DateTime Convert(string input)
        {
            DateTime result;
            if(DateTime.TryParse(input, out result))
            {
                return result;
            }
            return DateTime.Now;
        }
    }
}
