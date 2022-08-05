using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApostilaDeCSharp.ParadigmaEstruturado
{
    internal class Paradigm
    {
        static void Main(string[] args)
        {
            /*
             * Sequêncial - TopDown
             * 
             * Step 1
             * Step 2
             * Step 3
             * Step 4
             * 
             */

            string repeat;

            do {
                // Step 1 - Data Entry
                string name = Console.ReadLine();

                // Step 2 - Processing
                string answer;
                if (name.Equals("Regys"))
                {
                    answer = "Our class representative";
                }
                else
                {
                    answer = "Call the class representative!";
                }

                // Step 3 - Exit

                Console.WriteLine(answer);
                Console.ReadKey();

                // Step 4 - Structuring an iteration (looping)
                Console.WriteLine("Deseja sair? Y-N");
                repeat = Console.ReadLine().ToUpper();

            } while (!repeat.Equals("Y"));

            int[] grades = new int[4];
            grades[0] = 9;
            grades[1] = 21;
            grades[2] = 7;
            grades[3] = 15;
            Console.WriteLine("Show the grades of Class Representative.");

            double sum = 0;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(grades[i]);
                sum = sum + grades[i];
            }
            double avarage = sum / grades.Length;
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Avarage: {avarage}");
            Console.ReadKey();

        }
    }
}

