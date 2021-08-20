//1
using System;
namespace CalculatorExample
{
    class Program
    {
        static void Main2()
        {
            Calc c= new Calc();
            int ans = c.Add(10,80);
            Console.WriteLine("10+80 is {0}.",ans);

            //Wait for user to press the Enter key before shutting down
            Console.ReadLine();
        }
    }
    class Calc
    {
        public int Add(int x ,int y)
        {
            return(x+y);
        }
    }
    
}

