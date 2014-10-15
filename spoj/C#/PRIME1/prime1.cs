using System;
using System.Text;

class PRIME1
{
    static void Main() {
        bool[] isPrimes1 = new bool[31608];
        int[] primes = new int[3401];
        int en = 0;

        for (int i = 2; i < 31608; i++) {
            if (isPrimes1[i] == false) {
                for (int j = 2; j * i < 31608; j++) {
                    isPrimes1[j * i] = true;
                }

                primes[en++] = i;
            }
        }

        int t = int.Parse(Console.ReadLine());

        while (t-- > 0) {
            string[] numbers = Console.ReadLine().Split(' ');
            int m = int.Parse(numbers[0]);
            m = m < 2 ? 2 : m;
            int n = int.Parse(numbers[1]);

            bool[] isPrimes2 = new bool[n - m + 1];

            for (int i = 0; i < 3401 && primes[i] < Math.Sqrt(n); i++) {
                int start;

                if (primes[i] < m) {
                    start = m + ((primes[i] - m % primes[i]) % primes[i]);
                } else {
                    start = primes[i] * 2;
                }

                for (int j = start; j <= n; j += primes[i]) {
                    isPrimes2[j - m] = true;
                }
            }

            StringBuilder str = new StringBuilder();

            for (int i = m; i <= n; i++) {
                if (isPrimes2[i - m] == false) {
                    str.AppendLine(Convert.ToString(i));
                }
            }

            Console.WriteLine(str);
        }
    }
}
