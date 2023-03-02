using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZaIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi 4isla na spisuka");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            PrintCount(numbers);

            Console.Write("vuvedi 4isla na masiv 1 ");
            int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            AddArrayTolist(numbers,arr1);

            Console.Write("4isloto koeto iskash da se tursi: ");
            int num = int.Parse(Console.ReadLine());
            IsNumInList(numbers, num);

            Console.Write("vuvedi 4isla na 2 list ");
            int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            AddArrayTolistTwo(numbers,arr2);

            Console.WriteLine();    
        }

        private static void AddArrayTolistTwo(List<int> numbers, int[] arr2)
        {
            numbers.InsertRange(3,arr2);
            numbers.Sort();
            Console.Write($"dobavqme vtori masiv kum purviq spisuk{string.Join("*",numbers)}");
        }

        private static void IsNumInList(List<int> numbers, int num)
        {
            if (numbers.Contains(num))
            {
                Console.WriteLine($"4isloto {num} e na {numbers.IndexOf(num)}");
            }
            else
            {
                Console.WriteLine($"4isloto {num} ne e v spisaka");    
            }
        }

        private static void AddArrayTolist(List<int> numbers, int[] arr1)
        {
            numbers.AddRange(arr1);
            numbers.Sort();
            Console.WriteLine($"dobqvqne na 1 masiv kum spisuka{string.Join(" ",numbers)}");
        }

        private static void PrintCount(List<int> numbers)
        {
            Console.WriteLine($"broq na elementite v lista{numbers.Count}");
        }
    }
}
