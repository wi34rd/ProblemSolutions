using System;

class prb1197
{
    static void Main() {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++) {
            string square = Console.ReadLine();

            int x = (int)square[0] - 96;
            int y = (int)square[1] - 48;

            int counter = 0;

            if (x + 2 < 9 && y - 1 > 0) {
                counter++;
            }
            if (x + 2 < 9 && y + 1 < 9) {
                counter++;
            }
            if (x + 1 < 9 && y + 2 < 9) {
                counter++;
            }
            if (x - 1 > 0 && y + 2 < 9) {
                counter++;
            }
            if (x - 2 > 0 && y - 1 > 0) {
                counter++;
            }
            if (x - 2 > 0 && y + 1 < 9) {
                counter++;
            }
            if (x + 1 < 9 && y - 2 > 0) {
                counter++;
            }
            if (x - 1 > 0 && y - 2 > 0) {
                counter++;
            }

            Console.WriteLine(counter);
        }
    }
}
