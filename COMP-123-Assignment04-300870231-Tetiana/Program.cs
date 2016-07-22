using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP_123_Assignment04_300870231_Tetiana
{
    class Program
    {
        /**
         * Author: Tetiana Reznychenko
         * Student number: 300870231
         * Date: July,22, 2016 
         * Description: This program is to simulate the rolling of two dice and
         * displaying how many times each result was rolled
         */

        static void Main(string[] args)
        {
            //variables 
            int firstDie = 0;
            int secondDie = 0;
            int[,] dieValues;
            int[] sums;
            int sum = 0;

            dieValues = new int[7, 7]; 
            sums = new int[13];
            Random random = new Random();

            for (int index = 0; index < 36000; index++)
            {
                //assign the dies: it will randomly pick numbers from 1 to 6
                firstDie = random.Next(1, 7); 
                secondDie = random.Next(1, 7);
                //calculate sum. The minimum sum must be 2, maximum = 12
                sum = firstDie + secondDie; 
                
                dieValues[firstDie, secondDie] += 1;
                sums[sum] += 1;
            }


            //this shows how many times each option was rolled (like, first die was rolled 1 time and second die 2 times) 

            Console.WriteLine("        1       2       3       4       5       6");
            Console.WriteLine("*********************************************************************");
            //rows (for the table)
            for (int r = 1; r <= 6; r++)
            {
                Console.Write(" {0} *", r);

                for (int c = 1; c <= 6; c++)
                {
                    Console.Write("   {0:D4} ", dieValues[r, c]); 
                    if (c == 6)
                        Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //this is for showing sum of two dies. Number 7 appears more often. 
            Console.WriteLine("   2     3     4     5     6     7     8     9     10     11    12");
            Console.WriteLine("********************************************************************"); 
            for (int i = 2; i <= 12; i++)
            {
                Console.Write("  {0:D4}", sums[i]);
            }
            Console.ReadLine();
        }
    }
}
