using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace EgnHelper
{
    public class EgnValidator : IEgnValidator
    {
        private const string dateTimeFormat = "yyyy-M-d";
        private int[] weights = new int[] { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

        private Dictionary<int, string> citiest = new Dictionary<int, string>()
        {
            {43, "Благоевград" },
            {54, "Стара Загора" },
            {22, "София" },
            {52, "Пловдив" },
            {53, "Варна" },
            {56, "Бургас" },
            {44, "Други" },
        };

        public bool IsValid(string egn)
        {
            if(egn is null)
            {
                throw new ArgumentNullException(nameof(egn));
            }

            if(!Regex.IsMatch(egn, "[0-9]{10}"))
            {
                return false;
            }

            int yearPart = int.Parse(egn.Substring(0, 2));
            int monthPart = int.Parse(egn.Substring(2, 2));
            int dayPart = int.Parse(egn.Substring(4, 2));

            int month = monthPart;
            int year = yearPart;

            if(monthPart >= 21 && monthPart <= 32)
            {
                //1800 - 1899
                month -= 20;
                year += 1800;
            }
            else if(monthPart >= 41 && monthPart <= 52)
            {
                //2000 - 2099
                month -= 40;
                year += 2000;
            }
            else if(monthPart >= 1 && monthPart <= 12)
            {
                //1900 - 1999
                year += 1900;
            }
            else
            {
                return false;
            }

            string currentDateTime = $"{year}-{month}-{dayPart}";
            if (!DateTime.TryParseExact(
                currentDateTime,
                dateTimeFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out _))
            {
                return false;
            }

            var checkSum = 0;
            for (int i = 0; i <= 8; i++)
            {
                var digit = egn[i] - '0';
                checkSum += digit * weights[i];
            }

            var lastDigit = checkSum % 11;
            if(lastDigit == 10)
            {
                lastDigit = 0;
            }

            if(int.Parse(egn[9].ToString()) != lastDigit)
            {
                return false;
            }

            return true;
        }
    }
}
