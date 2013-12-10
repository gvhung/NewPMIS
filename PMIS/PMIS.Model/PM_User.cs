using System;
//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template
using System.Collections;
using System.Collections.Generic;

namespace PMIS.Model
{
    [Serializable]
    public class PM_User
    {

        /// <summary>
        /// pm_UserID
        /// </summary>
        public virtual int pm_UserID
        {
            get;
            set;
        }

        /// <summary>
        /// pm_UserName
        /// </summary>
        public virtual string pm_UserName
        {
            get;
            set;
        }

        /// <summary>
        /// pm_UserLogin
        /// </summary>
        public virtual string pm_UserLogin
        {
            get;
            set;
        }

        /// <summary>
        /// pm_UserPassword
        /// </summary>
        public virtual string pm_UserPassword
        {
            get;
            set;
        }

        /// <summary>
        /// pm_State
        /// </summary>
        public virtual string pm_State
        {
            get;
            set;
        }

        /// <summary>
        /// Version
        /// </summary>
        public virtual int? Version
        {
            get;
            set;
        }

        public  virtual IList<PM_RoleFp> RoleFpList { get; set; }

    }
}