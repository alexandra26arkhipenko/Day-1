using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static QuickSort.SortArray;
using static SortMerge.Sortmerge;

namespace Test
{
    class Program
    {
        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rd = new Random();
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rd.Next(1, 20);
            }
            Console.WriteLine("Массив до сортировки: ");
            Print(array);


            Console.WriteLine("\nQuickSorting : ");
            QuickSorting(array, 0, array.Length - 1);

            Print(array);

            int[] array1 = new int[10];
       
            for (int i = 0; i < array1.Length; ++i)
            {
                array1[i] = rd.Next(1,20);
            }
            Console.WriteLine("\nМассив до сортировки: ");
            Print(array1);

            Console.WriteLine("\nСортровка слиянием");

            SortMergeMethod(array1, 0, array1.Length - 1);
            Print(array1);
            Console.ReadKey();
        }


        
    }
}
