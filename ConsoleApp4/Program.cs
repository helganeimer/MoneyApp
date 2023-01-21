using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyLibrary;

namespace MainNameSpace
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Money money1 = new Money();
            Money money2 = new Money(123.0, "UAH", 0.027);
            Console.WriteLine("Insert Money1 parameters " + "\n");
            
            money1.Input();
            Console.WriteLine("Money1 parameters are \n");
            money1.Print();
            Console.WriteLine("Money2 parameters are \n");
            money2.Print();
            Console.WriteLine("Which count is greater? " + money1.CountsComparison(money2) + "\n");
            Console.WriteLine("The sum of counts is " + money1.SumOfCounts(money2) + "\n");
            Console.WriteLine("Money1 in dollars is " + money1.CountInDollar() + "\n");
            Console.WriteLine("Money2 in dollars is " + money2.CountInDollar() + "\n");
            Console.ReadKey();
        }
    }
}
