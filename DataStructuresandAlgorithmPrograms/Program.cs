using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulate Banking Cash Counter");
            CashCounter<string> BC1 = new CashCounter<string>();
            BC1.CashCounter();
        }
    }
}