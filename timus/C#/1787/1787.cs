using System;

class prb1787
{
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');

        int k = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        input = Console.ReadLine().Split(' ');

        int result = 0;

        for (int i = 0; i < n; i++) {
            result += int.Parse(input[i]) - k;

            if (result < 0) {
                result = 0;
            }
        }

        Console.WriteLine(result);
    }
}
