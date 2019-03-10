using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CAQM
{
    public static class Helper
    {

        public static bool HasMonitorType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (
                        value.ToUpper() == "AM"
                        || value.ToUpper() == "CS"
                        || value.ToUpper() == "UM"
                        || value.ToUpper() == "AP"
                        | value.ToUpper() == "DP"
                    );
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool AMType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (value.ToUpper() == "AM");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool CSType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (value.ToUpper() == "CS");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DPType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (value.ToUpper() == "DP");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UMType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (value.ToUpper() == "UM");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool APType(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value))
                    return false;
                else
                    return (value.ToUpper() == "AP");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Int32? ToINT(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Int32? ToInt32(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Double? ToDouble(string value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static Decimal? ToDecimal(string value)
        {
            try
            {
                return Convert.ToDecimal(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DateTime? ToDateTime(string value)
        {
            try
            {
                return Convert.ToDateTime(value);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}