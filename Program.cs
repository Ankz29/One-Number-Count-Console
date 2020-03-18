using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0,i, limit;
            Console.WriteLine(" Enter the numbers limit: ");
             limit = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[limit];
            Console.WriteLine("enter the numbers: ");
            for ( i = 0; i < limit; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] == 1)
                {
                    Count++;
                }
            }
            Console.WriteLine("the number of one's occurance: " + Count);
            Console.ReadLine();          
        }
    }
}
