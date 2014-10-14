using System;

class prb2001
{
    static void Main() {
        int[,] a = new int[3, 2];
        int[] weight = new int[2];

        for (int i = 0; i < 3; i++) {
            string[] input = Console.ReadLine().Split(' ');

            a[i, 0] = int.Parse(input[0]);
            a[i, 1] = int.Parse(input[1]);
        }

        weight[0] = a[0, 0] - a[2, 0];
        weight[1] = a[0, 1] - a[1, 1];

        Console.WriteLine("{0} {1}", weight[0], weight[1]);
    }
}
