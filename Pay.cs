using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    internal class Pay
    {
        private ShoppingMall payment;
        public Pay(ShoppingMall payment) { 
        this.payment = payment;
        }
        public void setShoppingMall(ShoppingMall payment)
        {
            this.payment = payment;
        }

        public void discount(double amount)
        {
            payment.discount(amount);
        }
    }
}
