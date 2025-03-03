using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task3
    {
        private int _x0;
        private int _y0;
        private int _x1;
        private int _y1;

        public Task3(int x0, int y0, int x1, int y1)
        {
            _x0 = x0;
            _y0 = y0;
            _x1 = x1;
            _y1 = y1;
        }

        public string Distance()
        {
            if ((_x0 > _x1 || _y0 > _y1) && (_x0 > _y1 || _y0 > _x1)) return "Точка А наиболее удалена";
            else if ((_x0 < _x1 || _y0 < _y1) && (_x0 < _y1 || _y0 < _x1)) return "Точка B наиболее удалена";
            else return "Точка A и B на одинаковом расстоянии";
        }
    }
}
