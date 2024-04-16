using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task105_A.L._6
{
    internal static class Helper
    {
        public static bool CheckName(this string name)
        {

            if (!string.IsNullOrEmpty(name))
            {
                return true;
            }
            if (name.Length < 3)
            {
                return false;
            }
            bool uppercharcter = false;
            foreach (char c in name)
            {
                if (char.IsUpper(name[0]))
                {
                    uppercharcter = true;
                    break;
                }

            }
            return uppercharcter;
        }
        public static bool CheckSurname(this string surname)
        {
            if (!string.IsNullOrEmpty(surname))
            {
                return true;
            }
            if (surname.Length < 3)
            {
                return false;
            }
            bool uppercharcter = false;
            foreach (char c in surname)
            {
                if (char.IsUpper(surname[0]))
                {
                    uppercharcter = true;
                    break;
                }
            }
            return uppercharcter;
        }

        public static bool CheckClassroom(this string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                return false;
            }
            if (name.Length < 5)
            {
                return false;
            }
            bool uppercharcter1 = false;
            bool uppercharcter2 = false;
            bool number1 = false;
            bool number2 = false;
            bool number3 = false;
            foreach (char c in name)
            {
                if (char.IsUpper(name[0]))
                {
                    uppercharcter1 = true;
                }
                if (char.IsUpper(name[1]))
                {
                    uppercharcter2 = true;
                }
                if (char.IsDigit(name[2]))
                {
                    number1 = true;
                }
                if (char.IsDigit(name[3]))
                {
                    number2 = true;
                }
                if (char.IsDigit(name[4]))
                {
                    number3 = true;
                }
            }

            return uppercharcter1 && uppercharcter2 && number1 && number2 && number3;

        }
    }
}

