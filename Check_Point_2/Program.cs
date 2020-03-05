using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Point_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburger ham = new Hamburger("Base Hamburger", "roll", "beaf", 10);
            HealthyBurger health = new HealthyBurger("Health Burger", "Brown rye bread roll", 10);
            DeluxeBurger delux = new DeluxeBurger("Delux Burger", 10);

            ham.Addtop1("lectuce", 5);
            ham.Addtop2("tomato", 6);
            ham.Addtop3("carot", 7);
            ham.Addtop4("bacon", 8);

            health.Addtop5("cheese", 9);
            health.Addtop6("chili", 8);
            delux.Extra1("chips", 10);
            delux.Extra2("drinks", 20);

            Console.WriteLine("Information of Hamburger:");
            Console.WriteLine(ham.Print());
            Console.WriteLine();
            Console.WriteLine("Information of topping:");
            Console.WriteLine(ham.PrintTopping());
            Console.WriteLine();
            Console.WriteLine("Total price: {0}", ham.TotalPrice());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Information of Hamburger:");
            Console.WriteLine(health.Print());
            Console.WriteLine();
            Console.WriteLine("Information of topping:");
            Console.WriteLine(ham.PrintTopping());
            Console.WriteLine(health.PrintTopping());
            Console.WriteLine();
            Console.WriteLine("Total price: {0}", ham.TotalPrice() - ham.Baseprice() + health.TotalPrice());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Information of Hamburger:");
            Console.WriteLine(delux.Print());
            Console.WriteLine();
            Console.WriteLine("Information of topping:");
            Console.WriteLine(delux.PrintTopping());
            Console.WriteLine();
            Console.WriteLine("Total price: {0}", delux.TotalPrice());

        }
    }
}
