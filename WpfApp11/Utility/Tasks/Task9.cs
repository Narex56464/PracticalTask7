using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task9
    {
        private double _a;
        private double R;

        public Task9(double a, double r)
        {
            _a = a;
            R = r;
        }

        public bool More()
        {
            return (Math.Pow(_a, 2)) > (Math.PI * Math.Pow(R, 2));
        }
    }
}
