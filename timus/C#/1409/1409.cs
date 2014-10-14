using System;

class prb1409
{
    static void Main() {
        string[] numTins = Console.ReadLine().Split(' ');

        Console.WriteLine("{0} {1}", int.Parse(numTins[1]) - 1, int.Parse(numTins[0]) - 1);
    }
}
