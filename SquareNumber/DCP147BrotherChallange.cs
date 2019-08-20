using System;
namespace SquareNumber
{
    public class DCP147BrotherChallange
    {
        static void Main()
        {
            uint input = uint.Parse(Console.ReadLine());
            uint sum = 0;
            for (uint i = 0; i < input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
