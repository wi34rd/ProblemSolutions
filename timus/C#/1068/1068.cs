using System;

class prb1068
{
    static void Main() {
        int sum = 0;
        int N = int.Parse(Console.ReadLine());

        if (N > 1) {
            for (int i = 1; i <= N; i++) {
                sum += i;
            }
        } else {
            for (int i = N; i <= 1; i++) {
                sum += i;
            }
        }

        Console.WriteLine(sum);
    }
}
