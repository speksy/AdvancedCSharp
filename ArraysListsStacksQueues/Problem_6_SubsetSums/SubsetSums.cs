using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetSums
{
    static void Main()
    {
        int searchedSum = int.Parse(Console.ReadLine());
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] sequence = numbers.Distinct().ToArray();

        double combinations = Math.Pow(2, sequence.Length);

        List<int> listOfInts = new List<int>();
        int count = 0;

        for (int i = 1; i < combinations; i++)
        {
            int sum = 0;
            FindCombinations(i, sequence, ref listOfInts);
            sum = listOfInts.Sum();

            if (sum == searchedSum)
            {
                Console.WriteLine("{0} = {1}",
                    string.Join(" + ", listOfInts.Select(x => x.ToString()).ToArray()),
                    listOfInts.Sum()
                    );
                count++;
            }

            listOfInts = new List<int>();
        }
        if (count == 0)
        {
            Console.WriteLine("No matching subsets.");
        }
    }

    private static void FindCombinations(int mask, int[] intArr, ref List<int> intList)
    {
        int sumOfComb = 0;
        for (int i = 0; i < intArr.Length; i++)
        {
            if (mask % 2 != 0)
            {
                sumOfComb += intArr[i];
                intList.Add(intArr[i]);
            }
            mask >>= 1;

        }
    }
}