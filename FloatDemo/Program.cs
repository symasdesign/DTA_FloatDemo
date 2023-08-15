using System;
using System.Threading;

namespace FloatDemo {
    class Program {
        static void Main(string[] args) {
            
            double val1 = 0.1;
            double val2 = 0.2;

            double result = val1 + val2;

            if(result == 0.3) {
                Console.WriteLine("richtig\n\n");
            } else {
                Console.WriteLine("falsch\n\n");
            }

            Console.WriteLine($"val1:    {val1}\n");
            Console.WriteLine($"val2:    {val2}\n");
            Console.WriteLine($"result:  {result}\n");

            Console.ReadKey();

        }

        
    }
}
