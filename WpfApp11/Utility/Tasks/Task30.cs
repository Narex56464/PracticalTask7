using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task30
    {
        private int _a;

        public Task30(int a)
        {
            _a = a;
        }

        public string Exp()
        {
            if (_a % 2 == 0) return "Число А четное";
            else if (_a % 10 == 7) return "Число А оканчивается на 7";
            else return "Число А не соответсувет условию";
        }
    }
}
