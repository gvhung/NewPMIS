using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMIS.Comm
{
    public class ReturnObj
    {
        public int State { get; set; }
        public String Msg { get; set; }
    }

    public class ReturnObjBean<T> : ReturnObj
    {
        public T Bean { get; set; }
    }
}
