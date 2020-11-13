using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Presention.Model
{
    public static class Validation
    {

        public static bool IsEmpty(TextBox txtString)
        {
            if (txtString == null || txtString.Equals(String.Empty) || txtString.Text.Trim().Equals(String.Empty))
                return false;
            return true;
        }


        public static bool IsString(TextBox txtString, bool changeColor = true)
        {
            if (!IsEmpty(txtString)) return false;

            for (int i = 0; i < txtString.Text.Length; i++)
            {
                if (Char.IsDigit(txtString.Text[i]))
                {
                    if (changeColor) ChangeColor(txtString);
                    return false;
                }

            }

            return true;
        }


        public static bool IsDigit(TextBox txtString, bool changeColor = true)
        {
            if (!IsEmpty(txtString)) return false;

            for (int i = 0; i < txtString.Text.Length; i++)
            {
                if (!Char.IsDigit(txtString.Text[i]))
                {
                    if (changeColor) ChangeColor(txtString);
                    return false;
                }
            }
            return true;
        }


        public static bool IsInteger(TextBox textBox, bool changeColor = true)
        {
            int intNumber;
            bool result = int.TryParse(textBox.Text, out intNumber);

            if (!result)
                if (changeColor) ChangeColor(textBox);

            return result;
        }


        public static bool IsDouble(TextBox textBox, bool changeColor = true)
        {
            double number;
            bool result = double.TryParse(textBox.Text, out number);

            if (!result)
                if (changeColor) ChangeColor(textBox);

            return result;
        }


        public static bool IsDateTime(TextBox textBox, bool changeColor = true)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(textBox.Text, "MM/dd/yyyy", null, DateTimeStyles.None, out dateTime) == true ||
                DateTime.TryParseExact(textBox.Text, "M/d/yyyy", null, DateTimeStyles.None, out dateTime) == true)
                return true;

            if (changeColor) ChangeColor(textBox);

            return false;
        }


        public static bool IsTime(TextBox textBox, bool changeColor = true)
        {
            DateTime dateTime;

            if (DateTime.TryParseExact(textBox.Text, "h:mm tt", null, DateTimeStyles.None, out dateTime) == true)
                return true;

            if (changeColor) ChangeColor(textBox);

            return false;
        }


        public static bool IsTimeSpan(TextBox textBox,  bool changeColor = true)
        {
            TimeSpan value;

            bool result = TimeSpan.TryParse(textBox.Text, out value);

            if(!result)
                if (changeColor) ChangeColor(textBox);

            return result;
        }


        public static bool IsValidEmail(TextBox textBox, bool changeColor = true)
        {
            string email = textBox.Text;

            if (string.IsNullOrWhiteSpace(email)) return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                if (changeColor) ChangeColor(textBox);
                return false;
            }
            catch (ArgumentException e)
            {
                if (changeColor) ChangeColor(textBox);
                return false;
            }

            try
            {
                bool result = Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));

                if (!result)
                    if (changeColor) ChangeColor(textBox);

                return result;
            }
            catch (RegexMatchTimeoutException)
            {
                if (changeColor) ChangeColor(textBox);
                return false;
            }
        }


        public static bool IsValidPhone(TextBox txtPhone, bool changeColor = true)
        {
            if (txtPhone.TextLength != 10)
            {
                txtPhone.ForeColor = Color.Red;
                return false;
            }

            return Validation.IsDigit(txtPhone);
        }


        public static void ChangeColor(TextBox textBox)
        {
            textBox.ForeColor = Color.Red;
        }


        public static string Filter(this string str, List<char> charsToRemove)
        {
            charsToRemove.ForEach(c => str = str.Replace(c.ToString(), String.Empty));
            return str;
        }


        public static string RemoveChars(string str)
        {
            List<char> myStr = new List<char>() { '$' };
            str = str.Filter(myStr);

            return str;
        }

    }
}
