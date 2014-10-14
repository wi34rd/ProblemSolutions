using System;

class prb1877
{
    static void Main() {
        Console.WriteLine(int.Parse(Console.ReadLine()) % 2 == 0 | int.Parse(Console.ReadLine()) % 2 == 1 ? "yes" : "no");
    }
}
