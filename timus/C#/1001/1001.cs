using System;

class prb1001
{
    static void Main() {
        string[] input = Console.In.ReadToEnd().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = input.Length - 1; i >= 0; i--) {
            Console.WriteLine("{0:F4}", Math.Sqrt(double.Parse(input[i])));
        }
    }
}
