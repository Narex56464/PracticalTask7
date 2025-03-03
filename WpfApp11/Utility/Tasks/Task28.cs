using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task28
    {
        private double Lititude;
        private double Longtitude;

        public Task28(double lititude, double longtitude)
        {
            Lititude = lititude;
            Longtitude = longtitude;
        }

        public string Exp()
        {
            if ((Lititude >= -90 && Lititude <= 90) && (Longtitude >= -180 && Longtitude <= 0)) return "Восточное полушарие";
            else if ((Lititude >= -90 && Lititude <= 90) && (Longtitude >= 0 && Longtitude <= 180)) return "Западное полушарие";
            else return "Указаны неверные координаты";
        }
    }
}
