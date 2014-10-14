using System;

class prb1639
{
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');

        if (int.Parse(input[0]) * int.Parse(input[1]) % 2 == 0) {
            Console.WriteLine("[:=[first]");
        } else {
            Console.WriteLine("[second]=:]");
        }
    }
}
