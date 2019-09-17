using System;

namespace square {
    class Program {

        static void Main (string[] args) 
        {
            int a, b, c, d;
            a = Int32.Parse(Console.ReadLine ());
            b = Int32.Parse(Console.ReadLine ());
            c = Int32.Parse(Console.ReadLine ());
            d = b * b - 4 * a * c;
            if (d >= 0)
            {
                Console.WriteLine ((-b + Math.Sqrt (d)) / 2 / a);

                Console.WriteLine ((-b - Math.Sqrt (d)) / 2 / a);
            } 
            else 
            {
                Console.WriteLine ("error");
            }
        }
    }
}