using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMIS.Model
{
    [Serializable]
    public class PM_Fj
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
        /// guid
        /// </summary>
        public virtual Guid guid
        {
            get;
            set;
        }
        /// <summary>
        /// relative_path
        /// </summary>
        public virtual string relative_path
        {
            get;
            set;
        }
        /// <summary>
        /// fullname
        /// </summary>
        public virtual string fullname
        {
            get;
            set;
        }
        /// <summary>
        /// filename
        /// </summary>
        public virtual string filename
        {
            get;
            set;
        }
        /// <summary>
        /// accLevel
        /// </summary>
        public virtual string accLevel
        {
            get;
            set;
        }
        /// <summary>
        /// accUId
        /// </summary>
        public virtual string accUId
        {
            get;
            set;
        }

    }
}
