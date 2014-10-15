using System;

class prb1313
{
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[,] image = new int[n, n];

        for ( int i = 0; i < n; i++ ) {
            string[] input = Console.ReadLine().Split(' ');

            for ( int j = 0; j < n; j++ ) {
                image[j, i] = int.Parse(input[j]);
            }
        }

        for ( int i = 0; i < n; i++ ) {
            for ( int j = 0; j <= i; j++ ) {
                Console.Write("{0} ", image[j, i - j]);
            }
        }

        for ( int i = 1; i < n; i++ ) {
            for ( int j = 1; j <= n - i; j++ ) {
                Console.Write("{0} ", image[i + j - 1, n - j]);
            }
        }

        Console.WriteLine();
    }
}
