using System;

class prb1264
{
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');

        Console.WriteLine(int.Parse(input[0]) * (int.Parse(input[1]) + 1));
    }
}
