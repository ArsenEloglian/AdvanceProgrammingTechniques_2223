class Test
{
    static int NonZeroFactorialDigit(int n)
    {
        if (n < 1) return 1;

        int mod = 10, lastNonZero = 1;

        for (int i = 2; i <= n; i++)
        {
            lastNonZero = lastNonZero * i;

            while ((lastNonZero % mod) == 0)
            {
                lastNonZero = lastNonZero / 10;
            }
                
            lastNonZero = lastNonZero % 10;
        }

        return lastNonZero;
    }

    public static void Main()
    {
        string line = Console.ReadLine();
        int n = int.Parse(line);

        string digit;
        int[] b = new int[n];
        for (int i = 0; i < n; i++)
        {
            digit = Console.ReadLine();
            b[i] = int.Parse(digit);
        }

        foreach (int j in b)
            Console.WriteLine(NonZeroFactorialDigit(j));
    }
}