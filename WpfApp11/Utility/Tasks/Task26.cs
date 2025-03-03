using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task26
    {
        private double M_Venera;
        private double R_Venera;
        private double M_Saturn;
        private double R_Saturn;

        public Task26(double venera, double r_Venera, double saturn, double r_Saturn)
        {
            M_Venera = venera;
            R_Venera = r_Venera;
            M_Saturn = saturn;
            R_Saturn = r_Saturn;
        }

        public bool More()
        {
            double G = 6.7 * Math.Pow(10, -8);
            double graviry_v = G * M_Venera / Math.Pow(M_Venera, 2);
            double graviry_s = G * M_Saturn / Math.Pow(M_Saturn, 2);

            return graviry_s > graviry_v;
        }
    }
}
