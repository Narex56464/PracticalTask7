using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task20
    {
        private double sp1;
        private double sp2;

        public Task20(double speed1, double speed2)
        {
            sp1 = speed1;
            sp2 = speed2;
        }

        public bool Exp()
        {
            sp1 *= 0.001;

            return sp1 > sp2;
        }
    }
}
