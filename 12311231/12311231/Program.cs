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


            double[] heights = { 174.2, 170.3, 164.2, 179.7, 168.8 };
            double averageHeight = 0.0;
            for (int i=0; i<heights.Length; i++)
            {
                averageHeight += heights[i];
            }

            Console.WriteLine("Средний рост студента");
            





        }
    }
}
