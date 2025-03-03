using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task10
    {
        private double _a;
        private double _b;
        private double _c;

        public Task10(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string Exp()
        {
            if (_a >= 0) _a = Math.Pow(_a, 3);
            else _a = 0;
            if (_b >= 0) _b = Math.Pow(_b, 3);
            else _b = 0;
            if (_c >= 0) _c = Math.Pow(_c, 3);
            else _c = 0;
            return $"a = {_a}\nb = {_b}\nc = {_c}";
        }
    }
}
