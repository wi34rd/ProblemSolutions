using System;

class prb1910
{
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');

        int[] pows = new int[n];

        for (int i = 0; i < n; i++) {
            pows[i] = int.Parse(input[i]);
        }

        int maxSum = pows[0] + pows[1] + pows[2];
        int midNo = 2;

        for (int i = 1; i < n - 2; i++) {
            if (maxSum < pows[i] + pows[i + 1] + pows[i + 2]) {
                maxSum = pows[i] + pows[i + 1] + pows[i + 2];
                midNo = i + 2;
            }
        }

        Console.WriteLine("{0} {1}", maxSum, midNo);
    }
}
