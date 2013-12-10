using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMIS.Comm
{
    public class UtilCodeInfo
    {

        public static string GetGuid()
        {
            return Guid.NewGuid().ToString("N");
        }

        /// <summary>
        /// 用户角色
        /// </summary>
        public static IList<BmInfo> usRole;
        /// <summary>
        /// 用户状态
        /// </summary>
        public static IList<BmInfo> usstate;
        /// <summary>
        /// 系统资源类型
        /// </summary>
        public static IList<BmInfo> xtzylx;
        /// <summary>
        /// 系统资源状态
        /// </summary>
        public static IList<BmInfo> xtzyzt;
        /// <summary>
        /// 获取编码名称
        /// </summary>
        /// <param name="strCode">编码</param>
        /// <param name="list">编码所属集合</param>
        /// <returns></returns>
        public static string GetCiName(string strCode, IList<BmInfo> list)
        {
            string name = "";
            try
            {
                if (!string.IsNullOrEmpty(strCode))
                {
                    var codeInfo = list.First(r => r.Code.Equals(strCode));
                    name = codeInfo.Name;
                }
            }
            catch
            {
                name = "";
            }
            return name;
        }

        /// <summary>
        /// 角色状态
        /// </summary>
        public static IList<BmInfo> rolestate;
        /// <summary>
        /// 资源编码
        /// </summary>
        public static IList<BmInfo> recode { get; set; }
        /// <summary>
        /// 审核结果
        /// </summary>
        public static IList<BmInfo> shjg { get; set; }

      
    }
}
