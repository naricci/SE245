using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_MidtermExam
{
    class ValidationLibrary
    {
        // Checks if field is filled in...receives a string
        public static bool IsItFilledIn(string temp)
        {
            bool result = false;

            if (temp.Length > 0)
            {
                result = true;
            }

            return result;
        }

        // Checks if a field is filled in with min length/receives a string
        public static bool IsItFilledIn(string temp, int minlen)
        {
            bool result = false;

            if (temp.Length >= minlen)
            {
                result = true;
            }

            return result;
        }

        // Receives a string and we can let user know if it has a semi-valid email format
        public static bool IsValidEmail(string temp)
        {
            // Assume true, but look for bad stuff to make it false
            bool result = true;

            // Look for position of "@"
            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation + 1);

            // temp = scott@neit.ca
            // length = 13
            // position of last period = 10

            // Look for position of last period "."
            int periodLocation = temp.LastIndexOf(".");

            // Check for minimum length
            if (temp.Length < 8)
            {
                result = false;
            }
            else if (atLocation < 2)    // If it is -1, not found and needs at least 2 chars in front
            {
                result = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                result = false;
            }

            return result;
        }


        // Zip Code Func - Checks to make sure length equals 5 digits
        public static bool IsValidZip(string temp)
        {
            // Assume true, but look for bad stuff to make it false
            bool result = true;

            foreach (Char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            if (temp.Length < 5 || temp.Length > 5)
            {
                result = false;
            }

            return result;
        }


        // Phone Func - Checks to make sure length is at least 7 digits
        public static bool IsValidPhoneNumber(string temp)
        {
            bool result = true;

            foreach (Char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            if (temp.Length < 7)
            {
                result = false;
            }

            return result;
        }


        // Digit Check Func - Check to make sure all characters are digits
        public static bool IsAllDigits(string temp)
        {
            bool result = true;

            foreach (Char c in temp)
            {
                if (Char.IsDigit(c) == false)
                {
                    result = false;
                }
            }

            return result;
        }
    }
}
