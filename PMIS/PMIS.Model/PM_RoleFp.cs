using System;
//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template
using System.Configuration;

namespace PMIS.Model
{

    [Serializable]
		public class PM_RoleFp
        {
	
      	/// <summary>
		/// pm_TRFpId
        /// </summary>
        public virtual int pm_TRFpId
        {
            get; 
            set; 
        }        
		/// <summary>
		/// pm_TRFpUid
        /// </summary>
        public virtual int pm_TRFpUid
        {
            get; 
            set; 
        }        
		/// <summary>
		/// pm_TRFpRid
        /// </summary>
        public virtual int? pm_TRFpRid
        {
            get; 
            set; 
        }        
		 
        public virtual PM_User User
        {
            get;
            set;
        }

        public virtual PM_Role Role { get; set; }
	}
}