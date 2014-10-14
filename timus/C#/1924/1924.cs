using System;

class prb1924
{
    static void Main() {
        if ( (int)(int.Parse(Console.ReadLine()) / 2.0 + .5) % 2 == 0 ) {
            Console.WriteLine("black");
        } else {
            Console.WriteLine("grimy");
        }
    }
}
