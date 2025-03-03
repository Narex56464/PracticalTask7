using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task21
    {
        private double Sk;
        private double Sc;
        private double R;

        public Task21(double sk, double sc, double r)
        {
            Sk = sk;
            Sc = sc;
            R = r;
        }

        public string AnsA()
        {
            if (R >= 1 / 2 * Math.Sqrt(2 * Sk)) return "a)Квадрат уместиться в круге";
            else return "а)Квадрат не уместиться в круге";
        }

        public string AnsB()
        {
            if (Sk >= 4 * (Sc) / (Math.PI)) return "\nб)Круг уместиться в квадрате";
            else return "\nб)Круг не уместиться в квадрате";
        }
    }
}
