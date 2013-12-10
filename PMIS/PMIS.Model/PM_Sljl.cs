using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMIS.Model
{
    //PM_Sljl
    public class PM_Sljl
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
        /// pm_UID
        /// </summary>
        public virtual int pm_UID
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
        /// pm_Sltime
        /// </summary>
        public virtual DateTime pm_Sltime
        {
            get;
            set;
        }

        /// <summary>
        /// pm_Tjtime
        /// </summary>
        public virtual DateTime? pm_Tjtime
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