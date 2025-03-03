using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp11.Utility.Tasks
{
    public class Task13
    {
        private double Deposit;
        private double Term;

        public Task13(double deposit, double term)
        {
            Deposit = deposit;
            Term = term;
        }

        public string Payments()
        {
            double sum;
            if (Term <= 6) sum = Deposit + Math.Pow(1 + (0.06) / (12), Term);
            else sum = Deposit + Math.Pow(1 + (0.08) / (12), Term);

            return $"Сумма ежемесячных выплат по депозиту составляет {Math.Round(sum, 2)}";
        }
    }
}
