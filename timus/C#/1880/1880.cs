using System;

class prb1880
{
    static void Main() {
        string[][] input = new string[3][];

        for (int i = 0; i < 3; i++) {
            int n = int.Parse(Console.ReadLine());
            input[i] = Console.ReadLine().Split(' ');
        }

        int counter = 0;

        for (int i = 0; i < input[0].Length; i++) {
            for (int j = 0; j < input[1].Length; j++) {
                if (input[0][i] == input[1][j]) {
                    for (int k = 0; k < input[2].Length; k++) {
                        if (input[0][i] == input[2][k]) {
                            counter++;
                        }
                    }
                }
            }
        }

        Console.WriteLine(counter);
    }
}
