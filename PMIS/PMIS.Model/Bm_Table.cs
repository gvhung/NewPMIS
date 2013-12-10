using System;

//Nhibernate Code Generation Template 1.0
//author:MythXin
//blog:www.cnblogs.com/MythXin
//Entity Code Generation Template
namespace PMIS.Model
{
    [Serializable]
    public class Bm_Table
    {

        /// <summary>
        /// bm_id
        /// </summary>
        public virtual int bm_id
        {
            get;
            set;
        }
        /// <summary>
        /// bm_code
        /// </summary>
        public virtual string bm_code
        {
            get;
            set;
        }
        /// <summary>
        /// bm_lx
        /// </summary>
        public virtual string bm_lx
        {
            get;
            set;
        }
        /// <summary>
        /// bm_mc
        /// </summary>
        public virtual string bm_mc
        {
            get;
            set;
        }
        /// <summary>
        /// bm_sort
        /// </summary>
        public virtual string bm_sort
        {
            get;
            set;
        }
        /// <summary>
        /// bm_lxmc
        /// </summary>
        public virtual string bm_lxmc
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