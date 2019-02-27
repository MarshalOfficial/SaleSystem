using System;
using System.Collections.Generic;
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
    }
}
