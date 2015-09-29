using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_SequencesOfEqualStrings
{
    class SequencesOfEqualStrings
    {
        static void Main()
        {
            //read and convert to array of strings
            string[] input = Console.ReadLine().Split(' ').ToArray();
            
            //print sequences
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                if (i < input.Length - 1 && (input[i] == input[i + 1]))
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
