using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task11
    {
        private int _a;

        public Task11(int a)
        {
            _a = a;
        }

        public string Exp()
        {
            if (_a % 2 == 0) return "Число А четное";
            else if (_a % 10 == 3) return "Число А оканчивается на 3";
            else return "Число А не соответсувет условию";
        }
    }
}
