using System;

//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template

namespace PMIS.Model
{

    [Serializable]
    public class PM_Product
    {

        /// <summary>
        /// 自增ID
        /// </summary>
        public virtual int pm_TPId
        {
            get;
            set;
        }
        /// <summary>
        /// GUID
        /// </summary>
        public virtual Guid pm_TPGuid
        {
            get;
            set;
        }
        /// <summary>
        /// 项目名
        /// </summary>
        public virtual string pm_TPName
        {
            get;
            set;
        }
        /// <summary>
        /// 负责人
        /// </summary>
        public virtual string pm_TPLead
        {
            get;
            set;
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public virtual DateTime? pm_TPAddtime
        {
            get;
            set;
        }
        /// <summary>
        /// 添加人
        /// </summary>
        public virtual string pm_TPAddUser
        {
            get;
            set;
        }

        public virtual PM_User AddUser
        {
            get; set;
        }

        /// <summary>
        /// 修改时间
        /// </summary>
        public virtual DateTime? pm_TPModifyTime
        {
            get;
            set;
        }
        /// <summary>
        /// 修改人
        /// </summary>
        public virtual string pm_TPModifyUser
        {
            get;
            set;
        }
        public virtual PM_User ModifyUser
        {
            get;
            set;
        }
        /// <summary>
        /// 项目版本
        /// </summary>
        public virtual string pm_TPVersion
        {
            get;
            set;
        }
        /// <summary>
        /// 项目状态
        /// </summary>
        public virtual string pm_TPState
        {
            get;
            set;
        }
        /// <summary>
        /// 父项目
        /// </summary>
        public virtual int? pm_TPFId
        {
            get;
            set;
        }
        /// <summary>
        /// 版本
        /// </summary>
        public virtual int? Version
        {
            get;
            set;
        }
        /// <summary>
        /// 解决方案名
        /// </summary>
        public virtual string pm_TPJjfaName
        {
            get;
            set;
        }
        /// <summary>
        /// 文档
        /// </summary>
        public virtual string pm_TPWd
        {
            get;
            set;
        } 

        public  virtual DateTime pm_TPCreateTime { get; set; }
    }
}