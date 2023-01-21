using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoneyLibrary
{
    //класс Грошова сума
    public class Money
    {   
        //розмір суми
        private double count;
        //код валюти
        private string code;
        //купс по відношенню до долара
        private double dollar_rate;

        //властивості класу
        public double Count
        {
            get { return count; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Count must be greater than or equal to 0");
                else count = value;
            }
        }
        public string Code
        {
            get { return code; }
            set
            {
                if (value.Length < 3 || value.Length > 3)
                    throw new ArgumentOutOfRangeException("The number of characters must be 3");
                else code = value;
            }
        }
        public double DollarRate
        {
            get { return dollar_rate; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Value must be greater than 0");
                else dollar_rate = value;
            }
        }
        //функція порівняння об'єктів на рівність
        public static bool ReferenceEquals(Money money1, Money money2)
        {
            return money1 == money2;
        }
        //конструктор за замовчуванням
        public Money()
        {
            Init(0.0, "USD", 1.0);
        }
        //ініціалізуючий конструктор
        public Money(double count, string code, double dollar_rate)
        {
            Init(count, code, dollar_rate);
        }
        //копіюючий конструктор
        public Money(Money money)
        {
            Init(money.Count, money.Code, money.DollarRate);
        }
        //ініціалізуючий метод
        private void Init(double count, string code, double dollar_rate)
        {
            Count = count;
            Code = code;
            DollarRate = dollar_rate;
        }

        //метод порівняння двох сум
        public string CountsComparison(Money money)
        {
            if (Count > money.Count) return (Count + " greater than " + money.Count);
            else if (Count < money.Count) return (money.Count + " greater than " + Count);
            else return "Counts are equal";

        }
        //сума двох сум
        public double SumOfCounts(Money money)
        {
            double sum = Count + money.Count;
            return sum;
        }
        //обчислення значення суми в доларах
        public double CountInDollar()
        {
            double dollar_count = Count * DollarRate;
            return dollar_count;
        }



        

        //функція введення в консоль
        public void Input()
        {
            double count = Convert.ToDouble(Console.ReadLine());
            string code = Console.ReadLine();
            double dollar_rate = Convert.ToDouble(Console.ReadLine());

            Init(count, code, dollar_rate);
        }
        //функція виведення з консолі
        public void Print()
        {
            Console.WriteLine("Count = " + Count + "\n" + "Code = " + Code +
                "\n" + "Dollar rate = " + DollarRate + "\n");
        }


        

    }
}
