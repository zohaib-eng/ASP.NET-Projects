using System;

namespace Average_Numbers_of_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers;
            float average = 0.0F;
            int sum = 0;
            numbers = new int[5];
            Console.WriteLine("Enter Five Numbers:");
            numbers[0] = Int32.Parse(Console.ReadLine());
            numbers[1] = Int32.Parse(Console.ReadLine());
            numbers[2] = Int32.Parse(Console.ReadLine());
            numbers[3] = Int32.Parse(Console.ReadLine());
            numbers[4] = Int32.Parse(Console.ReadLine());
            
            for(int i = 0; i < numbers.Length; i++)
            {
                sum+= numbers[i];
            }
            average = sum / numbers.Length;
            Console.WriteLine("Average of Array Elements: " + average);
        }
    }
}
