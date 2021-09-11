using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_COCOMO
{
    class BaseTypes
    {
        float a;
        float b;
        float c;
        float d;

        int KLOC;

        public BaseTypes(int KLOC)
        {
            this.KLOC = KLOC;
        }

        public Result CalculateResults()
        {
            return new Result(GetEffort(), GetTimeOfDevelopment(), GetProductivity(), GetStaffingSize());
        }

        public double GetEffort()
        {
            return Math.Ceiling(a * Math.Pow(KLOC, b));
        }

        public double GetProductivity()
        {
            return Math.Ceiling((KLOC * 1000) / GetEffort());
        }
        public double GetTimeOfDevelopment()
        {
            return Math.Ceiling(c * Math.Pow(GetEffort(), d));
        }
        public double GetStaffingSize()
        {
            return Math.Ceiling(GetEffort() / GetTimeOfDevelopment());
        }

        public void setA(float a)
        {
            this.a = a ;
        }
        public void setB(float b)
        {
            this.b = b;
        }
        public void setC(float c)
        {
            this.c = c;
        }
        public void setD(float d)
        {
            this.d= d;
        }
    }
}
