using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFrameworkClassLibrary
{
    public class Class1
    {
        public string Test()
        {
            EventLog.WriteEntry("FRANCKYJORGE", "Hello from .net framework");
            return "HI";
        }
    }
}
