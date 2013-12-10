using System;
//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template
using System.Collections.Generic;

namespace PMIS.Model
{

    [Serializable]
    public class PM_Resource
    {

        /// <summary>
        /// pm_TReid
        /// </summary>
        public virtual int pm_TReid
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRName
        /// </summary>
        public virtual string pm_TRName
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRType
        /// </summary>
        public virtual string pm_TRType
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
        /// pm_TRFid
        /// </summary>
        public virtual int? pm_TRFid
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

        /// <summary>
        /// pm_TRURL
        /// </summary>
        public virtual string pm_TRURL
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRIMG
        /// </summary>
        public virtual string pm_TRIMG
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRpysx
        /// </summary>
        public virtual string pm_TRpysx
        {
            get;
            set;
        }

        public virtual PM_Resource FResource { get; set; }

        public virtual IList<PM_Resource> children { get; set; }

       // public virtual IList<PM_ReFp> ReFpLsit { get; set; }
    }
}