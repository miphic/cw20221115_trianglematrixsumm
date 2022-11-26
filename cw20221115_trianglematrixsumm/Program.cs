using System;

namespace cw20221115_trianglematrixsumm
{
    class Program
    {
        static void Main(string[] args)
        {
            var t0 = DateTime.Now;
            Console.WriteLine($@"{50} {Kata.GetSum(3)}");
            Console.WriteLine($@"{90} {Kata.GetSum(4)}");
            Console.WriteLine($@"{666691666950001L} {Kata.GetSum(100000)}");

            //Console.WriteLine($@"{666691666950001L} {Kata.GetSum(100000)}");
            Console.WriteLine($@"{666669166669500001L} {Kata.GetSum(1000000)}");


            Console.WriteLine($@"{DateTime.Now.Subtract(t0)}");
        }
    }
}
