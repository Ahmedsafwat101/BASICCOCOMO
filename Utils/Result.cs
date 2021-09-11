using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASIC_COCOMO
{
    class Result
    {
         double effort;
         double timeOfDevelopment;
         double productivity;
         double staffingSize;



        public Result(double _Effort, double _TimeOfDevelopment, double _Productivity, double _StaffingSize)
        {
            this.effort = _Effort;
            this.timeOfDevelopment = _TimeOfDevelopment;
            this.productivity = _Productivity;
            this.staffingSize = _StaffingSize;

        }

        public double getEffort()
        {
            return this.effort;
        }

        public double getTimeOfDevelopment()
        {
            return this.timeOfDevelopment;
        }
        public double getProductivity()
        {
            return this.productivity;
        }

        public double getStaffingSize()
        {
            return this.staffingSize;
        }


    }
}
