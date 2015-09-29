using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3_CategorizeNumbersAndFindMinMaxAverage
{
    class CategirizedAvgMinMaxFinder
    {
        static void Main()
        {

            String input = Console.ReadLine();
            //Replace dots
            input = input.Replace(".", ",");
            String intNumbers = "";
            String floatNumbers = "";

            //split string to string array
            var array = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            //convert array to int[]
            foreach (var item in array)
            {
                if (item.Contains(".") || item.Contains(","))
                {
                    floatNumbers += item + " ";
                }
                else
                {
                    intNumbers += item + " ";
                }
            }
            //Convert to int array
            var splitInts = intNumbers.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            int[] arrayOfInts = Array.ConvertAll(splitInts, int.Parse);
            //Convert to float array
            var splitFloats = floatNumbers.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            float[] arrayOfFloats = Array.ConvertAll(splitFloats, float.Parse);

            //arrays to string with spaces using string.Join
            intNumbers = string.Join(", ", arrayOfInts);
            floatNumbers = string.Join(", ", arrayOfFloats);
            
            //Result
            Console.WriteLine("[" + floatNumbers + "] -> min:" + arrayOfFloats.Min() + " , max: "
                + arrayOfFloats.Max() + ", sum: " + arrayOfFloats.Sum() + ", avg: " + arrayOfFloats.Average().ToString("0.00"));

            Console.WriteLine("[" + intNumbers + "] -> min:" + arrayOfInts.Min() + " , max: "
                + arrayOfInts.Max() + ", sum: " + arrayOfInts.Sum() + ", avg: " + arrayOfInts.Average().ToString("0.00"));
        }
    }
}
