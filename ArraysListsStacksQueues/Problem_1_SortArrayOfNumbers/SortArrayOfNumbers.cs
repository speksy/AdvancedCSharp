using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_SortArrayOfNumbers
{
    class SortArrayOfNumbers
    {
        static void Main()
        {
            //split array on spaces
            String[] input = Console.ReadLine().Split(' ').ToArray();

            //convert array to int[]
            int[] arrayOfInts = Array.ConvertAll(input, int.Parse);
            int buff;
            //bubble sort
            for (int j = 0; j < arrayOfInts.Length; j++)
            {
                for (int i = 0; i < arrayOfInts.Length - 1; i++)
                {
                    if (arrayOfInts[i] > arrayOfInts[i + 1])
                    {
                        buff = arrayOfInts[i];
                        arrayOfInts[i] = arrayOfInts[i + 1];
                        arrayOfInts[i + 1] = buff;
                    }
                }

            }
            //array to string with spaces using string.join
            String output = string.Join(" ", arrayOfInts);
            Console.WriteLine(output);

        }
    }
}
