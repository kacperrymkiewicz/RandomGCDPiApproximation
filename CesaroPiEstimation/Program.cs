using System;

class Program
{
    static void Main(string[] args)
    {
        const int iterations = 1000000;
        Random random = new Random();
        int coprimeCount = 0;

        for (int i = 0; i < iterations; i++)
        {
            int x = random.Next(1, int.MaxValue);
            int y = random.Next(1, int.MaxValue);

            if (GCD(x, y) == 1)
            {
                coprimeCount++;
            }
        }

        double probability = (double)coprimeCount / iterations;
        double piApproximation = Math.Sqrt(6 / probability);

        Console.WriteLine($"Liczba iteracji: {iterations}");
        Console.WriteLine($"Prawdopodobieństwo NWD(x, y) = 1: {probability}");
        Console.WriteLine($"Aproksymacja PI: {piApproximation}");
    }

    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
