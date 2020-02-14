using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
    public class Example
    {
        private DataBase db = new DataBase();
        public string GeenerateEgn(DateTime dateOfBird, bool isMale, string placeOfbirth)
        {
            if (dateOfBird.Year < 1900)
            {
                throw new ArgumentOutOfRangeException(nameof(dateOfBird), "Cannot generate EGN before 1900");
            }

            if (placeOfbirth is null)
            {
                throw new ArgumentNullException();
            }

            if (placeOfbirth != db.SomethingForExample)
            {
                throw new ArgumentException("place of birth not valid", nameof(placeOfbirth));

            }
            return "";
        }

        internal class DataBase
        {
            public string SomethingForExample { get; set; }
        }
    }
}
