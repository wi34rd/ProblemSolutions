using System;

class District
{
    private bool[,] blocks;

    public District(int width, int height) {
        blocks = new bool[width, height];
    }

    public void MarkBlock(int x, int y) {
        blocks[x - 1, y - 1] = true;
    }

    public void Display() {
        for (int y = blocks.GetLength(1) - 1; y >= 0; y--) {
            for (int x = 0; x < blocks.GetLength(0); x++) {
                if (blocks[x, y]) {
                    Console.Write('/');
                } else {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }

    public int ShortestPathLength {
        get {
            double[,] distances = new double[blocks.GetLength(0) + 1, blocks.GetLength(1) + 1];

            for (int x = 0; x < distances.GetLength(0); x++) {
                for (int y = 0; y < distances.GetLength(1); y++) {
                    if (x > 0 && y > 0) {
                        if (blocks[x - 1, y - 1]) {
                            distances[x, y] += Math.Min(distances[x - 1, y - 1] + Math.Sqrt(2), Math.Min(distances[x, y - 1] + 1, distances[x - 1, y] + 1));
                        } else {
                            distances[x, y] += Math.Min(distances[x, y - 1] + 1, distances[x - 1, y] + 1);
                        }
                    } else {
                        distances[x, y] = Math.Max(x, y);
                    }
                }
            }

            return (int)Math.Round(distances[distances.GetLength(0) - 1, distances.GetLength(1) - 1] * 100);
        }
    }
}

class prb1119
{
    static void Main() {
        string[] input = Console.ReadLine().Split(' ');

        District district = new District(int.Parse(input[0]), int.Parse(input[1]));

        int K = int.Parse(Console.ReadLine());

        for (; K > 0; K--) {
            input = Console.ReadLine().Split(' ');

            district.MarkBlock(int.Parse(input[0]), int.Parse(input[1]));
        }

        Console.WriteLine(district.ShortestPathLength);
    }
}