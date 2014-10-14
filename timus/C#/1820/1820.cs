using System;

class prb1820
{
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');
        int n = int.Parse(input[0]);
        int k = int.Parse(input[1]);

        if (k > n) {
            Console.WriteLine(2);
        } else {
            Console.WriteLine(Math.Ceiling(n * 2.0 / k));
    }
}
