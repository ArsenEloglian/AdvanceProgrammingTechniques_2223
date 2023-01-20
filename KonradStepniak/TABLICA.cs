class Program
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var splitted = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

        double vOut = Convert.ToDouble(input.Length);
        double x = Math.Floor(vOut / 2);
        int y = Convert.ToInt32(x);

        int[] arr = new int[y];
        List<double> d = new List<double>(); 
        d.AddRange(splitted.Select(double.Parse));
        double[] values = d.ToArray();
        arr = values.Select(d => (int)d).ToArray();

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int tmp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = tmp;
        }

        for (int j=0; j < arr.Length; j++) {
           
            if (j<arr.Length-1) Console.Write($"{arr[j]} ");
            else Console.Write($"{arr[j]}");
        }
    }
}