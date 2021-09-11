using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_COCOMO
{
    class OrganicType : BaseTypes
    {
        public OrganicType(int KLOC) : base(KLOC)
        {
            setA(3.2f); 
            setB(1.05f);
            setC(2.5f);
            setD(0.38f);
        }
    }
}
