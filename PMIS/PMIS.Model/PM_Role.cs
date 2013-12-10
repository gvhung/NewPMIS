using System;
//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template
using System.Collections.Generic;

namespace PMIS.Model
{
    [Serializable] //PM_Role
    public class PM_Role
    {

        /// <summary>
        /// pm_TRId
        /// </summary>
        public virtual int pm_TRId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRNanme
        /// </summary>
        public virtual string pm_TRNanme
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRFid
        /// </summary>
        public virtual int? pm_TRFid
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRBz
        /// </summary>
        public virtual string pm_TRBz
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRState
        /// </summary>
        public virtual string pm_TRState
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

        public virtual IList<PM_ReFp> ReFpList { get; set; }

        //public virtual IList<PM_RoleFp> RoleFpList { get; set; } 
    }
}