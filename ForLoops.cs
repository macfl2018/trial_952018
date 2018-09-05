using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            int tUnits, gUnits, solution, total;
            char doAgain;
            bool decision = true;


            while (decision == true)
            {
                solution = 1;
                Console.WriteLine("Please enter the total number of units ( the 'n' in npr)");
                tUnits = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Please enter the grouping of units from the total ( the 'r' in nPr)");
                gUnits = Convert.ToInt16(Console.ReadLine());

                total = tUnits - gUnits;

                for (int temp = tUnits; temp > total; temp--)
                {
                    solution *= temp;
                }

                Console.WriteLine("The solution to your permutation is: " + solution + ".");
                Console.ReadLine();
                Console.WriteLine("Would you like to run this program again? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain != 'y' && doAgain != 'Y')
                {
                    decision = false;
                }
         
                

            }   

        }
    }
}
