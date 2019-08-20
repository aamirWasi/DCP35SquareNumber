using System;
namespace SquareNumber
{
    public class DCP254CubeGame
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            var high = int.MinValue;
            for (int t = 1; t <= T; t++)
            {
                string input = Console.ReadLine();
                var inputArray = input.Split(' ');
                int blue, silver, gold, red;
                var sum = 0;
                blue = int.Parse(inputArray[0]);
                silver = int.Parse(inputArray[1]);
                gold = int.Parse(inputArray[2]);
                red = int.Parse(inputArray[3]);
                sum += blue * 1 + silver * 3 + gold * 10 + red * (-5);
                if(sum>0)
                {
                    Console.WriteLine($"Player {t}: {sum}");
                    high = Math.Max(sum, high);
                }
                else
                {
                    Console.WriteLine($"Player {t}: 0");
                    high = Math.Max(sum, high);
                }
            }
            Console.WriteLine($"High Score = {high}");
        }
    }
}
