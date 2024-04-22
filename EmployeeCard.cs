using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyDesignPattern.ShoppingMall;

namespace StrategyDesignPattern
{
    public class EmployeeCard : ShoppingMall
    {
        double dis = 0.2;
        public void discount(double amount)
        {
            Console.WriteLine("Employee Card");
            Console.WriteLine(amount*(1 - dis));
        }
    }
}
