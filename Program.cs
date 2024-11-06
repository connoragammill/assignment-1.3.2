using System;

namespace sort_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array Length");
            string[] food = { "pizza", "burger", "icecream", "hotdog" };
            Console.WriteLine(food.Length);
            Console.WriteLine();
            Array.Sort(food);
            foreach (string i in food)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            Console.WriteLine("Array Length");
            

            int[] TopFavorites = {4,2,1,3};
            Console.WriteLine(TopFavorites.Length);
            Console.WriteLine();
            Array.Sort(TopFavorites);
            foreach (int i in TopFavorites)
            {
                Console.WriteLine(i);
            }
            

            
            
            

            
        }
    }
}
