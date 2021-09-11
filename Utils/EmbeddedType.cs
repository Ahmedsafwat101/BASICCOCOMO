using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_COCOMO
{
    class EmbeddedType : BaseTypes
    {
        public EmbeddedType(int KLOC) : base(KLOC)
        {
            setA(2.8f);
            setB(1.20f);
            setC(2.5f);
            setD(0.32f);
        }
    }
}
