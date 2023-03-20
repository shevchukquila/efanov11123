using System;

namespace _12311231
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] masses = { 10.5, 20.1, 7.8, 15.3, 12.6 };
            double totalMass = 0.0;
            for (int i=0; i<masses.Length; i++)
            {
                totalMass += masses[i];
            }
            Console.WriteLine("Общая масса груза:" + totalMass + "kg");
            1 3aDaHuE


            double[] heights = { 174.2, 170.3, 164.2, 179.7, 168.8 };
            double averageHeight = 0.0;
            for (int i=0; i<heights.Length; i++)
            {
                averageHeight += heights[i];
            }

            Console.WriteLine("Средний рост студента");
            2 3aDaHue
            
                        int[] arr = new int[14];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-10, 11);
            }
            int negativeCount = 0;
            int pozitiveCount = 0;
            int zeroCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negativeCount++;
                }
                else if (arr[i] > 0)
                {
                    pozitiveCount++;
                }
                else
                {
                    zeroCount++;
                }
            }
            Console.WriteLine("Количество отрицательных элементов :" + negativeCount);
            Console.WriteLine("Количество положительных элементов :" + pozitiveCount);
            Console.WriteLine("Количество нулевых элементов:" + zeroCount);
            
            3 3aDaHue
            





        }
    }
}
