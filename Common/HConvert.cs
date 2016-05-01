using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 类型转换帮助类
    /// </summary>
    public class HConvert
    {
        /// <summary>
        /// 将字符串类型转换为int32
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int ToInt(string str)
        {
            int result;
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return int.TryParse(str,out result)?result:0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static double ToDouble(string str)
        {
            double result;
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return double.TryParse(str, out result)?result:0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static decimal ToDecimal(string str)
        {
            decimal result;
            if (string.IsNullOrEmpty(str))
            {
                return 0;
            }
            return decimal.TryParse(str,out result)?result:0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static DateTime ToDate(string str)
        {
            DateTime result;
            if (string.IsNullOrEmpty(str))
            {
                return DateTime.MinValue;
            }
            return DateTime.TryParse(str, out result) ? result : DateTime.MinValue;
        }


    }
}
