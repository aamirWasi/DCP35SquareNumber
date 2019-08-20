using System;
namespace SquareNumber
{
    public class DCP243The9thPower
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            double result;
            for (int t = 0; t < T; t++)
            {
                double input = double.Parse(Console.ReadLine());
                double ninthPower = Math.Pow(9, input);
                result = ninthPower % 10;
                Console.WriteLine($"{result}");
            }
        }
    }
}
