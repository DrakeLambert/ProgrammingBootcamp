using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = -30;

            if (height > 0)
            {
                // Height is positive. We need to loop over "i" until it reaches "height".
                for (var i = 0; i < height; i++)
                {
                    // Print "i" line segments.
                    for (var j = 0; j <= i; j++)
                    {
                        Console.Write("+---");
                    }
                    // End the line segment with a "+".
                    Console.WriteLine("+");

                    // Do the same with the walls of the boxes.
                    for (var j = 0; j <= i; j++)
                    {
                        Console.Write("|   ");
                    }
                    Console.WriteLine("|");
                }

                // Print the last line segment that the above loop doesn't cover.
                for (var j = 0; j < height; j++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");
            }
            else if (height < 0)
            {
                // Height is negative. We need to do everything in reverse order.

                // Print the first line segment.
                for (var i = height; i < 0; i++)
                {
                    Console.Write("+---");
                }
                Console.WriteLine("+");

                // Since we don't need to use "height" later on, we can loop over it until it reaches "0".
                while (height < 0)
                {
                    for (var i = height; i < 0; i++)
                    {
                        Console.Write("|   ");
                    }
                    Console.WriteLine("|");

                    for (var i = height; i < 0; i++)
                    {
                        Console.Write("+---");
                    }
                    Console.WriteLine("+");

                    // Increment "height" since it is negative.
                    height++;
                }
            }

            // In the case that "height" is not less than or greater than "0", we will print nothing.
        }
    }
}
