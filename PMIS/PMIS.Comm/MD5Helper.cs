using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PMIS.Comm
{
   public class MD5Helper
    {
        /// <summary>
        /// 将输入字符串转换为MD5的Hash字符串
        /// 字符编码使用UTF-8         
        /// </summary>
        /// <param name="value">输入字符串</param>
        /// <returns>hash字符串(长度32)</returns>       
        public static String ToString(String value)
        {
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            Byte[] bytes = provider.ComputeHash(Encoding.UTF8.GetBytes(value));
            String s = BitConverter.ToString(bytes);
            s = s.Replace("-", "");
            return s;
        }

        /// <summary>
        /// 判断指定的hash字符串是否是一个字符串经过MD5Hash化的结果
        /// 注意：字符串不区分大小写。
        /// </summary>
        /// <param name="value">源字符串：未经过md5hash化的字符串</param>
        /// <param name="hash">匹配字符串：一个MD5Hash字符串</param>
        /// <returns>如果相等则为True，否则为False</returns>
        public static Boolean Equals(String value, String hash)
        {
            String s = MD5Helper.ToString(value);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Equals(s, hash);
        }
    }
}

