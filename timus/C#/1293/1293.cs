using System;

class prb1293
{
    static void Main() {
        string[] numbrs = Console.ReadLine().Split(' ');

        Console.WriteLine(int.Parse(numbrs[0]) * int.Parse(numbrs[1]) * int.Parse(numbrs[2]) * 2);
    }
}
