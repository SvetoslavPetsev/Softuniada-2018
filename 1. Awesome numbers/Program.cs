using System;

namespace _1._Awesome_numbers
{
    class Program
    {
        static void Main()
        {
            int testNumber = int.Parse(Console.ReadLine());
            int favoriteNumber = int.Parse(Console.ReadLine());

            int conditionCounter = 0;

            if (Math.Abs(testNumber) % 2 == 1)
            {
                conditionCounter++;
            }
            if (testNumber < 0)
            {
                conditionCounter++;
            }
            if (Math.Abs(testNumber) % favoriteNumber == 0)
            {
                conditionCounter++;
            }

            if (conditionCounter == 3)
            {
                Console.WriteLine("super special awesome");
            }
            else if (conditionCounter == 2)
            {
                Console.WriteLine("super awesome");
            }
            else if (conditionCounter == 1)
            {
                Console.WriteLine("awesome");
            }
            else
            {
                Console.WriteLine("boring");
            }
        }
    }
}
