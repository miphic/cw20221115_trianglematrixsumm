#define TYPO
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace cw20221115_trianglematrixsumm
{
    public static class K1
    {
        static private Dictionary<int, long> s = testinitD();
        static private int current = -1;
        static private int[] keys = new int[1000000 / 100];

        private static Dictionary<int, long> testinitD()
        {
            var d = new Dictionary<int, long>();
            d.Add(0, 1);
            d.Add(1, 7);
            d.Add(2, 22);
            d.Add(5, 161);
            d.Add(9, 485);
            return d;
        }

        [Obsolete("", true)]
        private static void showD()
        {
            for (int i = 100; i < 1000000; i += 100)
            {
                var gsi = gs(i);
                Console.WriteLine($@"s.Add({i},{gsi});");
                s.Add(i, gsi);
            }
        }



        private static long vertsumm(int n)
        {
            Console.WriteLine(s[search(n)]);
            var k = search(n);
            var summ = s[k];



            Console.WriteLine(s[search(4)]);
            Console.WriteLine(s[search(5)]);
            Console.WriteLine(s[search(6)]);
            Console.WriteLine(s[search(7)]);
            Console.WriteLine(s[search(8)]);
            Console.WriteLine(s[search(9)]);
            Console.WriteLine(s[search(10)]);
            Console.WriteLine(s[search(11)]);


            return 0L;
        }



        private static int search(int n)
        {
            if (keys.Count() != s.Count())
                keys = s.Select(p => p.Key).ToArray();

            int low = 0, high = keys.Count() - 1;
            //n  = 3 

            if (keys[high] < n) return keys[high];

            do
            {
                if (keys[current] > n)
                    high = current;
                else
                    low = current;
                current = low + (high - low) / 2;
            }
            while (high - low > 1);
            current = (keys[high] < n) ? high : low;
            return keys[current];
        }



        private static long gs(int n)
        {
            vertsumm(n);
            long summ = 0L;
            for (int j = 0; j <= n; j++)
                for (int i = j; i <= n; i++)
                    summ += 2 * j + i + 1;
            return summ;
        }

        public static long GetSum(int n)
        {
            return gs(n);
        }
    }

    public static class Kata
    {
        static long rowsum(long j, long n)
        {
            long summ = 0, i=j;
            long start = 2 * j + j + 1;
            long end = start + n - j;
            summ = (start + end) * (n - j + 1) / 2;
            return summ;
        }
        public static long GetSum(int n)
        {
#if TYPO
            long summ = 0;
            for (long j = 0; j <= n; j++) 
            {
                summ += rowsum(j, n);
            }
            return summ;
#endif
        }
    }
}
