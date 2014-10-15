using System;

namespace Test
{
    class Program
    {
        static void Main() {
            string number = Console.ReadLine();

            while (number != "42") {
                Console.WriteLine(number);
                number = Console.ReadLine();
            }
        }
    }
}
