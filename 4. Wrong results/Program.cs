using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Wrong_results
{
    class Program
    {
        static int GetCorrectValue(List<int[,]> layers, int layerIndex, int rowIndex, int columnIndex, int size)
        {
            int sum = 0;
            int incorrectValue = layers[layerIndex][rowIndex, columnIndex];

            if (layerIndex - 1 >= 0)
            {
                int currValue = layers[layerIndex - 1][rowIndex, columnIndex];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            if (layerIndex + 1 < layers.Count)
            {
                int currValue = layers[layerIndex + 1][rowIndex, columnIndex];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            if (rowIndex - 1 >= 0)
            {
                int currValue = layers[layerIndex][rowIndex - 1, columnIndex];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            if (rowIndex + 1 < size)
            {
                int currValue = layers[layerIndex][rowIndex + 1, columnIndex];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            if (columnIndex - 1 >= 0)
            {
                int currValue = layers[layerIndex][rowIndex, columnIndex - 1];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            if (columnIndex + 1 < size)
            {
                int currValue = layers[layerIndex][rowIndex, columnIndex + 1];
                if (currValue != incorrectValue)
                {
                    sum += currValue;
                }
            }
            return sum;
        }
        private static List<int[,]> CloneList(List<int[,]> originalLayers, int size)
        {
            List<int[,]> temp = new List<int[,]>();
            for (int i = 0; i < size; i++)
            {
                int[,] newArr = new int[size, size];
                temp.Add(newArr);
            }
            for (int i = 0; i < originalLayers.Count; i++)
            {
                int[,] currLayer = originalLayers[i];
                for (int j = 0; j < currLayer.GetLength(0); j++)
                {
                    for (int k = 0; k < currLayer.GetLength(1); k++)
                    {
                        int currValue = currLayer[j, k];
                        temp[i][j, k] = currValue;
                    }
                }
            }
            return temp;
        }
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            List<int[,]> originalLayers = new List<int[,]>(size);

            for (int i = 0; i < size; i++)
            {
                int[,] newArr = new int[size, size];
                originalLayers.Add(newArr);
            }

            for (int i = 0; i < size; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int j = 0; j < input.Length; j++)
                {
                    int[] currLayer = input[j].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                    for (int k = 0; k < currLayer.Length; k++)
                    {
                        int currNumber = currLayer[k];
                        originalLayers[j][i, k] = currNumber;
                    }
                }
            }

            int[] coordinates = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int indexLayer = coordinates[0];
            int indexRow = coordinates[1];
            int indexColumn = coordinates[2];

            int counterCorrection = 0;
            int incorrectValue = originalLayers[indexLayer][indexRow, indexColumn];

            List<int[,]> temp = CloneList(originalLayers, size);

            for (int i = 0; i < temp.Count; i++)
            {
                int[,] currLayer = temp[i];
                for (int j = 0; j < currLayer.GetLength(0); j++)
                {
                    for (int k = 0; k < currLayer.GetLength(1); k++)
                    {
                        int currValue = currLayer[j, k];
                        if (currValue == incorrectValue)
                        {
                            int correctValue = GetCorrectValue(temp, i, j, k, size);
                            originalLayers[i][j, k] = correctValue;
                            counterCorrection++;
                        }
                    }
                }
            }
            Console.WriteLine($"Wrong values found and replaced: {counterCorrection}");
            for (int i = 0; i < originalLayers.Count; i++)
            {
                int[,] currlayer = originalLayers[i];
                for (int j = 0; j < currlayer.GetLength(0); j++)
                {
                    for (int k = 0; k < currlayer.GetLength(1); k++)
                    {
                        int currValue = originalLayers[i][j, k];
                        Console.Write(currValue + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
