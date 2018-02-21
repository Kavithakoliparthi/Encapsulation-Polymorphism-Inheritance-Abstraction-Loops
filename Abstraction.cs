using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Abstraction
    {
        int EId;
        string EName;
        int EAge;
        public int PEId     //Property
        {
            set {EId = value;}
            get{return EId;}
        }
        public string PEName
        {
            set { EName = value; }
            get { return EName; }
        }
        public int PEAge
        {
            set { EAge = value; }
            get { return PEAge; }
        }
    }
}
