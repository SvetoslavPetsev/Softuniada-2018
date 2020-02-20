using System;

namespace _2._Easter_Egg
{
    class Program
    {
        static void TopBottom(int n, int width)
        {
            for (int i = 1; i <= width; i++)
            {
                if (i > width / 2 - n / 2 && i <= width / 2 + n / 2)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        static void FirstTopPattern(int n, int width)
        {
            int lines = n / 2;
           
            for (int i = 1; i <= lines; i++)
            {
                int startPlus = width / 2 - n / 2 - i;
                int endPlus = width / 2 + n / 2 + i;

                for (int k = 1; k <= width; k++)
                {
                    if (k > startPlus && k <= endPlus)
                    {
                        Console.Write("+");
                    }
                    else if ((k > startPlus - i && k <= startPlus) || (k >= endPlus && k <= endPlus + i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static void SecondTopPattern(int n, int width)
        {
            int lines = n / 2;

            for (int i = lines; i >= 1; i--)
            {
                int startEqual = n / 2 + i + 2;
                int endEqual = width - n / 2 - i - 1;

                for (int k = 1; k <= width; k++)
                {
                    if (k >= startEqual && k <= endEqual)
                    {
                        Console.Write("=");
                    }
                    else if ((k >= startEqual - 2 && k < startEqual) || (k > endEqual && k <= endEqual + 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static void MidPart(int n, int width)
        {
            for (int i = 0; i < n /2; i++)
            {
                Console.Write(".");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < width / 2 - 6 - 2 - n/2; i++)
            {
                Console.Write("~");
            }
            Console.Write("HAPPY EASTER");
            for (int i = 0; i < width / 2 - 6 - 2 - n / 2; i++)
            {
                Console.Write("~");
            }
            for (int i = 0; i < 2; i++)
            {
                Console.Write("*");
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        static void SecondBottPattern(int n, int width)
        {
            int lines = n / 2;

            for (int i = 0; i < lines; i++)
            {
                int startEqual = n / 2 + i + 3;
                int endEqual = width - n / 2 - i - 2 ;

                for (int k = 1; k <= width; k++)
                {
                    if (k >= startEqual && k <= endEqual)
                    {
                        Console.Write("=");
                    }
                    else if ((k >= startEqual - 2 && k < startEqual) || (k > endEqual && k <= endEqual + 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static void FirstBottPattern(int n, int width)
        {
            int lines = n / 2;

            for (int i = lines; i >= 1; i--)
            {
                int startPlus = width / 2 - n / 2 - i;
                int endPlus = width / 2 + n / 2 + i;

                for (int k = 1; k <= width; k++)
                {
                    if (k > startPlus && k <= endPlus)
                    {
                        Console.Write("+");
                    }
                    else if ((k > startPlus - i && k <= startPlus) || (k >= endPlus && k <= endPlus + i))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int evenN = int.Parse(Console.ReadLine());
            int width = evenN * 5;

            TopBottom(evenN, width);
            FirstTopPattern(evenN, width);
            SecondTopPattern(evenN, width);
            MidPart(evenN, width);
            SecondBottPattern(evenN, width);
            FirstBottPattern(evenN, width);
            TopBottom(evenN, width);
        }
    }
}
