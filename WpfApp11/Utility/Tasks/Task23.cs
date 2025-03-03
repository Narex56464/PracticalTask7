using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task23
    {
        private double _km;
        private double _m;

        public Task23(double km, double m)
        {
            _km = km;
            _m = m;
        }

        public bool More()
        {
            _m *= 3.6;
            return _m > _km;
        }
    }
}
