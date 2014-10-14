using System;

class prb1025
{
    static void Main() {
        int K = int.Parse(Console.ReadLine());
        int[] numsVoters = new int[K];
        int numSupporters = 0;

        string[] input = Console.ReadLine().Split(' ');
        for (int i = 0; i < K; i++) {
            numsVoters[i] = int.Parse(input[i]);
        }

        Array.Sort(numsVoters);

        for (int i = 0; i <= K / 2; i++) {
            numSupporters += numsVoters[i] / 2 + 1;
        }

        Console.WriteLine(numSupporters);
    }
}
