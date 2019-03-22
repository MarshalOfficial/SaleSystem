using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SaleSystemCore.Extension
{
    public static class Extension
    {
        public static int ToInt(this object obj)
        {
            try
            {
                return int.Parse(obj.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal ToDecimal(this object obj)
        {
            try
            {
                return decimal.Parse(obj.ToString());
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static string ToStringEmpty(this object obj)
        {
            try
            {
                return obj.ToString();
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        public static string HashString(this string input)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(Encoding.ASCII.GetBytes(input));
            string hashedPassword = new UTF8Encoding().GetString(sha1data);
            return hashedPassword;
        }

        public static string GetPureDateTime()
        {
            return DateTime.Now.ToString("yyyyMMdd").Replace(":", "").Replace("-", "").Replace("/", "").Replace(@"\", "").Replace(" ", "");
        }

        public static string GetDateTimeYearPart()  
        {
            return DateTime.Now.ToString("yyyy").Replace(":", "").Replace("-", "").Replace("/", "").Replace(@"\", "").Replace(" ", "");
        }
    }
}
