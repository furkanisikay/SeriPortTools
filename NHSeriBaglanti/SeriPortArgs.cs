using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHSeriBaglanti
{
    public class SeriPortArgs
    {
        public SeriPortArgs(string PortName,int Baundrate)
        {
            this.PortName = PortName;
            this.Baundrate = Baundrate;
        }

        public string PortName { get; set; }
        public int Baundrate{ get; set; }
    }
}
