using System;
namespace SquareNumber
{
    public class DCP38MysteriousPond
    {
        static void Main()
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 0; t < T; t++)
            {
                int RobiFriends = int.Parse(Console.ReadLine());
                string minName = string.Empty;
                string maxName = string.Empty;
                int high = int.MinValue;
                int low = int.MaxValue;
                for (int i = 0; i < RobiFriends; i++)
                {
                    string input = Console.ReadLine();
                    var inputArray = input.Split(' ');
                    string name = inputArray[0];
                    var getValue = int.Parse(inputArray[1]);
                    if (getValue > high)
                    {
                        high = getValue;
                        maxName = name;
                    }
                    if (getValue < low)
                    {
                        low = getValue;
                        minName = name;
                    }
                }
                Console.WriteLine($"{maxName} {minName}");
            }
        }
    }
}
