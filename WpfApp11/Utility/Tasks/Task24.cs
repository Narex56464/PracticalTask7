using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task24
    {
        private double Sk;
        private double Sc;

        public Task24(double sk, double sc)
        {
            Sk = sk; 
            Sc = sc;
        }

        public string ExpA()
        {
            if (Sk / Sc < 0.604) return "a) Круг можно вписать в треугольник";
            else return "a) Круг нельзя вписать в треугольник";
        }

        public string ExpB()
        {
            if (Sk / Sc < 0.416) return "\nб) Треугольник можно вписать в круг";
            else return "\nб) Треугольник нельзя вписать в круг";
        }
    }
}
