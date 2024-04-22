using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StrategyDesignPattern.ShoppingMall;

namespace StrategyDesignPattern
{
    public class MembershipCard : ShoppingMall
    {
        double dis = 0.1;
        public void discount(double amount)
        {
            Console.WriteLine("You Have MemberShip Card");
            Console.WriteLine(amount*(1 - dis));

        }

    }
}
