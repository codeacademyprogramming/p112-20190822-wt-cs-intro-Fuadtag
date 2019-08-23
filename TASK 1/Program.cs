using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._22._2019_weekend_task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Ededler daxil edin");

            string[] readlinenum = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            
            int[] numbers = new int[readlinenum.Length];
            for (int j = 0; j < readlinenum.Length; j++)
            {
                numbers[j] = int.Parse(readlinenum[j]);
            }
            Console.WriteLine($"En boyuk eded = {numbers.Max()}");
            Console.WriteLine($"En kichik eded = {numbers.Min()}");
            Console.WriteLine($"Ededlerin cemi = {numbers.Sum()}");

             Array.Reverse(numbers);
            Console.Write("[");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]}");
                
            }
            Console.Write("]");




            Console.ReadLine();
           }
    }
}
