using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Bingo_Generator
{
    class Program
    {
        static int CreateFirstNum(string input)
        {
            return int.Parse(input[0].ToString() + input[2].ToString());
        }
        static int CreateSecondNum(string input)
        {
            return int.Parse(input[1].ToString() + input[3].ToString());
        }
        static int CreateFourDigitNumber(int[] arr)
        {
            return int.Parse(arr[0].ToString() + arr[1].ToString());
        }
        static void Main()
        {
            string input = Console.ReadLine();
            
            int firstN = CreateFirstNum(input);
            int secondN = CreateSecondNum(input);
            int ceiling = firstN + secondN;
            int[] startArr = new int[] { firstN, secondN };

            List<int> validNumbers = new List<int>();
            int start = secondN;

            for (int i = start; i <= ceiling + 1; i++)
            {
                if (startArr[0] == ceiling + 1)
                {
                    break;
                }
                int currNumber = CreateFourDigitNumber(startArr);
   
                if (ceiling >= 99)
                {
                    validNumbers.Add(currNumber);
                }
                else
                {
                    validNumbers.Add(currNumber);
                }

                startArr[1]++;
                if (startArr[1] == ceiling + 1)
                {
                    startArr[0]++;
                    startArr[1] = secondN;
                    i = start;
                }
            }

            List<int> divTo12 = new List<int>();
            List<int> divTo15 = new List<int>();

            foreach (var number in validNumbers)
            {
                if (number % 12 == 0)
                {
                    divTo12.Add(number);
                }
                if (number % 15 == 0)
                {
                    divTo15.Add(number);
                }
            }

            Console.Write("Dividing on 12: ");
            Console.Write(string.Join(" ", divTo12));
            Console.WriteLine();
            Console.Write("Dividing on 15: ");
            Console.Write(string.Join(" ", divTo15));
            Console.WriteLine();
            if (divTo12.Count == divTo15.Count)
            {
                Console.WriteLine("!!!BINGO!!!");
            }
            else
            {
                Console.WriteLine("NO BINGO!");
            }
        }
    }
}
