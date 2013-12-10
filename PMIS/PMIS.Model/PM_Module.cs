using System;

//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template

namespace PMIS.Model
{

    [Serializable]
    public class PM_Module
    {

        /// <summary>
        /// pm_TMid
        /// </summary>
        public virtual int pm_TMid
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMGuid
        /// </summary>
        public virtual Guid pm_TMGuid
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleName
        /// </summary>
        public virtual string pm_TMModuleName
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleLead
        /// </summary>
        public virtual string pm_TMModuleLead
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleAddTime
        /// </summary>
        public virtual DateTime? pm_TMModuleAddTime
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleAddUser
        /// </summary>
        public virtual string pm_TMModuleAddUser
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleModifyUser
        /// </summary>
        public virtual string pm_TMModuleModifyUser
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMModuleModifyTime
        /// </summary>
        public virtual DateTime? pm_TMModuleModifyTime
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMFid
        /// </summary>
        public virtual int? pm_TMFid
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMState
        /// </summary>
        public virtual string pm_TMState
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
        /// pm_TPGuid
        /// </summary>
        public virtual Guid pm_TPGuid
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TMWd
        /// </summary>
        public virtual string pm_TMWd
        {
            get;
            set;
        }        

    }
}