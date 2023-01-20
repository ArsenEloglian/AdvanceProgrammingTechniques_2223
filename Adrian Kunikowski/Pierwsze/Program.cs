using System;

namespace Pierwsze
{
    class Program
    {
        public static string isPrime(int x)
        {
            for(int i=2; i*i<=x; i++)
            {
                if(x%i==0)
                {
                    return "NIE";
                }
            }
            if (x > 1)
                return "TAK";
            else
                return "NIE";
        }
        static void Main(string[] args)
        {
            bool czyTesty = false;
            int n = 0;
            while (!czyTesty)
            {
                czyTesty = Int32.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 0; i < n; i++)
            {
                bool czyLiczba = false;
                int x = 0;
                while (!czyLiczba)
                {
                    czyLiczba = Int32.TryParse(Console.ReadLine(), out x);
                }
                Console.WriteLine(isPrime(x));
            }
        }
    }
}
