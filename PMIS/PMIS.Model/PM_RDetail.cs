using System;

//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template

namespace PMIS.Model
{

    [Serializable]
    public class PM_RDetail
    {

        /// <summary>
        /// pm_TRRDId
        /// </summary>
        public virtual int pm_TRRDId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRRRid
        /// </summary>
        public virtual int pm_TRRRid
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRRReId
        /// </summary>
        public virtual int pm_TRRReId
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

    }
}