using System;

//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template

namespace PMIS.Model
{
    [Serializable]
    public class PM_REOPENED
    {

        /// <summary>
        /// pm_ID
        /// </summary>
        public virtual int pm_ID
        {
            get;
            set;
        }

        /// <summary>
        /// pm_BId
        /// </summary>
        public virtual Guid pm_BId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_SckfrId
        /// </summary>
        public virtual int pm_SckfrId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_ScCsrId
        /// </summary>
        public virtual int pm_ScCsrId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_BcCsrId
        /// </summary>
        public virtual int pm_BcCsrId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_REOPENEDTime
        /// </summary>
        public virtual DateTime pm_REOPENEDTime
        {
            get;
            set;
        }

        /// <summary>
        /// pm_Zt
        /// </summary>
        public virtual string pm_Zt
        {
            get;
            set;
        }

    }
}