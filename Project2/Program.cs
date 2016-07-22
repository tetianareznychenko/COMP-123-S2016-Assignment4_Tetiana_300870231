using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Program
    {
        /**
         * Author: Tetiana Reznychenko
         * Student number: 300870231
         * Date: July,22, 2016 
         * Description: This program is to assign seats on each flight of the airline’s only plane. 
         */
        static void Main(string[] args)
        {
            //declair the list of seats
            List<int> seatingChart = new List<int>(10);
            List<int> assignedSeats = new List<int>();

            //create a menu 

            int menuchoice = 0;
            while (menuchoice != 3)
            {

                Console.WriteLine("Choose your option");
                Console.WriteLine();
                Console.WriteLine("1. First Class seats");
                Console.WriteLine("2. Economy Class seats");
                Console.WriteLine("3. Exit");
                Console.WriteLine();

                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        //assign the seats in the first class
                        Random random = new Random();
                        int seat = 0;
                        while (seat == random.Next(1, 6))
                        {
                            seatingChart.Add(seat);
                            assignedSeats.RemoveAt(seat);
                            seat++;
                        }
                        Console.WriteLine("Your seat is {0}", seat);
                        break;
                    case 2:
                        //assign the seats in the ecomony class
                        Random rand = new Random();
                        int seatEcomomy = 0;
                        while (seatEcomomy == rand.Next(6, 11))
                        {
                            seatingChart.Add(seatEcomomy);
                            assignedSeats.RemoveAt(seatEcomomy);
                            seatEcomomy++;
                        }
                        Console.WriteLine("Your seat is {0}", seatEcomomy);
                        break;
                    case 3:

                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
