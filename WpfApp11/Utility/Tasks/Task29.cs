using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task29
    {
        private double DistanceSirius;
        private double DistanceArcturusParsecs;
        private double ParsecToLightYears;
        private double LightYearToKm;

        public Task29(double distanceSirius, double distanceArcturusParsecs, double parsecToLightYears, double lightYearToKim)
        {
            DistanceSirius = distanceSirius;
            DistanceArcturusParsecs = distanceArcturusParsecs;
            ParsecToLightYears = parsecToLightYears;
            LightYearToKm = lightYearToKim;
        }

        public string Exp()
        {
            double distanceArcturus = DistanceArcturusParsecs * ParsecToLightYears * LightYearToKm;

            if (distanceArcturus > DistanceSirius) return "Арктур находится дальше Сириуса";
            else if (distanceArcturus < DistanceSirius) return "Сириус находится дальше Арктура";
            else return "Обе звезды на одинаковом расстоянии";
        }
    }
}
