using System;
namespace SquareNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                var numberToCheck = int.Parse(Console.ReadLine());
                double result = Math.Sqrt(numberToCheck);
                bool isSquare = result % 1 == 0;
                if (isSquare)
                {
                    Console.WriteLine($"Case {t}: YES");
                }
                else
                {
                    Console.WriteLine($"Case {t}: NO");
                }
            }
        }
    }
}
