using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_Project
{
    class Prog_Project
    {
        static void Main(string[] args)
        {


            /*  
             *  Gurk Asahan - Knights Tour Project
             *  
             * This Project is the Knights Tour Problem where it takes
             * in the users selected grid size and starting position
             * to determine how many times the Knight can move in the
             * grid randomly before it cannot move anymore
             * 
             */



            //username and password
            Console.WriteLine("Please enter username (hint: gurk or jaskaran) : ");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter password (hint 1234) : ");
            int password = int.Parse(Console.ReadLine());


            //authentication condition
            if (username == "gurk" || username=="jaskaran" && password == 1234)
            {


                //initial grid
                Console.WriteLine("Enter number of rows for the grid: ");
                int r = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter number of columns for the grid: ");
                int c = int.Parse(Console.ReadLine());


                //initial coords
                Console.WriteLine("Enter starting x coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter starting y coordinate: ");
                int y = int.Parse(Console.ReadLine());

                //


                //setting grid to user input
                int[,] array = new int[r, c];


                //counter for testing the 8 different options
                int counter = 0;

                //for loop for number of times to rerun
                Console.WriteLine("Enter the number of times you want to rerun");
                int rerun = int.Parse(Console.ReadLine());


                for (int trial = 0; trial < rerun; trial++)
                {
                    //create an arraylist to track visited coords
                    ArrayList visited = new ArrayList();

                    //while loop for if you can move to a spot we have not seen
                    //Does not fall out the grid
                    while (visited.Count < r * c)
                    {
                        counter = 0;

                        //i is x values (-2 bc lowest value x can be)
                        for (int i = -2; i < 3; i++)
                        {

                            //j is y values (-2 bc lowest value y can be)
                            for (int j = -2; j < 3; j++)
                            {
                                //Absolute x + y always equals to 3 according to all possible knight moves
                                if (Math.Abs(i) + Math.Abs(j) == 3)


                                {

                                    //if new coordinates is within bounds
                                    //get length(0) for row
                                    //get length(1) for columns
                                    if (0 <= x + i && x + i < array.GetLength(0) && 0 <= y + j && y + j < array.GetLength(1))
                                    {
                                        //create a counter for moves not visited before
                                        if (!visited.Contains((x + i, y + j)))
                                        {
                                            visited.Add((x + i, y + j));

                                            //assigns the visited count to the grid
                                            array[x + i, y + j] = visited.Count;

                                            x += i;
                                            y += j;

                                        }
                                        else
                                        {
                                            //increase counter if its visited spot already
                                            counter += 1;
                                        }

                                    }
                                    else
                                    {
                                        //increase counter if falls out of bound
                                        counter += 1;

                                    }

                                }

                            }


                        }
                        //break if counter reaches 8 bc only 8 possible moves knight can make
                        //Console.WriteLine(counter);
                        if (counter == 8)
                        {
                            break;
                        }

                    }

                    //print each coordinate from arraylist
                    foreach (var item in visited)
                    {
                        //   Console.WriteLine(item);
                    }

                    if (rerun == 1)
                    {

                        //print out grid according to spots visited
                            for (int row = 0; row < r; row++)
                            {
                                for (int column = 0; column < c; column++)
                                    Console.Write(array[row, column] + " ");
                                Console.WriteLine();
                            }


                        Console.WriteLine("Trial " + (trial + 1) + ": " + "The Knight was able to successfully touch " + visited.Count + " Squares");
                    }
                    else
                    {
                        Console.WriteLine("Trial " + (trial + 1) + ": " + "The Knight was able to successfully touch " + visited.Count + " Squares");

                    }

                }


                Console.Read();
            }
        }

    }

}