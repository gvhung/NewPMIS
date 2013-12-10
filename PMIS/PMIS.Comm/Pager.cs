using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMIS.Comm
{
    public class Pager<T>
    {
       public  int total { get; set; }

        public String sort { get; set; }

        public String order { get; set; }

        public IList<T> rows { get; set; }
    }
}
