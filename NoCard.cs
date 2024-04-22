using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyDesignPattern.ShoppingMall;

namespace StrategyDesignPattern
{
    public class NoCard : ShoppingMall
    {
        //double dis = 0.2;
        public void discount(double amount)
        {
            Console.WriteLine("No Card");
            Console.WriteLine(amount);
        }
    }
}
