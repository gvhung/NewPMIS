using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMIS.Model
{
    public class PM_ReFp
    {
        /// <summary>
        /// id
        /// </summary>
        public virtual int id
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TReid
        /// </summary>
        public virtual int pm_TReid
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRId
        /// </summary>
        public virtual int pm_TRId
        {
            get;
            set;
        }

        /// <summary>
        /// pm_TRIsRead
        /// </summary>
        public virtual bool pm_TRIsRead
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TRIsCreate
        /// </summary>
        public virtual bool pm_TRIsCreate
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TRIsEdit
        /// </summary>
        public virtual bool pm_TRIsEdit
        {
            get;
            set;
        }
        /// <summary>
        /// pm_TRIsDelete
        /// </summary>
        public virtual bool pm_TRIsDelete
        {
            get;
            set;
        }        

        public virtual PM_Resource Resource { get; set; }

       // public virtual PM_Role Role { get; set; }
    }
}
