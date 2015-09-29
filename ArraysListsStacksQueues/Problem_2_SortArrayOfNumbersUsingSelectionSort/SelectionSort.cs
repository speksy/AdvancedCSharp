using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_SortArrayOfNumbersUsingSelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            String[] array = Console.ReadLine().Split(' ').ToArray();
            
            //convert array to int[]
            int[] arrayOfInts = Array.ConvertAll(array, int.Parse);
            int selectedIndex, swapBuffer;
            //selection sort algorithm 
            for (int j = 0; j < arrayOfInts.Length - 1; j++)
            {
                selectedIndex = j;
                for (int i = j + 1; i < arrayOfInts.Length; i++)
                {
                    if (arrayOfInts[i] < arrayOfInts[selectedIndex])
                    {
                        selectedIndex = i;
                    }
                }
                swapBuffer = arrayOfInts[selectedIndex];
                arrayOfInts[selectedIndex] = arrayOfInts[j];
                arrayOfInts[j] = swapBuffer;
            }

            //array to string with spaces using string.join
            String output = string.Join(" ", arrayOfInts);
            Console.WriteLine(output);


        }
    }
}

