using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task6
    {
        private int _x;
        private int _y;

        public Task6(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Exp()
        {
            if (_x > 0 && _y > 0) return "Точка А находится в правой верхней части координат";
            else if (_x > 0 && _y < 0) return "Точка А находится в правой нижней части координат";
            else if (_x < 0 && _y > 0) return "Точка А находится в левой верхней части координат";
            else if (_x < 0 && _y < 0) return "Точка А находится в левой нижней части координат";
            else return "Точка А находится на нулевых координатах";
        }
    }
}
