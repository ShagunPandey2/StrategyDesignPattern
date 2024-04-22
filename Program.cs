using static StrategyDesignPattern.ShoppingMall;



namespace StrategyDesignPattern
{ 
internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Shopping Mall");
            Console.WriteLine();
            Console.WriteLine("Enter the Total Amount");
            string am = Console.ReadLine();
            int amount = Convert.ToInt32(am);

            Console.WriteLine();
            Console.WriteLine("Enter the type of Card");
            Console.WriteLine("Membership Card");
            Console.WriteLine("Employee Card");
            Console.WriteLine("No Card");

            string card = Console.ReadLine();

            Console.WriteLine("You have to pay");

            if (card=="Membership Card") {
                Pay payment = new Pay(new MembershipCard());
                payment.discount(amount);
            }
            else if(card=="Employee Card")
            {
                Pay payment = new Pay(new EmployeeCard());
                payment.discount(amount);

            }
           else
            {
                Pay payment = new Pay(new NoCard());
                payment.discount(amount);
            }

            
            
        }
    }
}
