using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_1840_9902_2
{
    class question_2
    {
        public static int Main(string[] args)
        {
            bool[,] host;
            host = new bool[12, 31];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    host[i, j] = false; // initialization the whole array with false
                }
            }


            int choice , counter;
            bool flag , firstDay , running = true;

            Console.WriteLine("HELLO!");

            while (running)
            {
                Console.WriteLine("enter 0 to make aמ order");
                Console.WriteLine("enter 1 to print list of all of the ordered days");
                Console.WriteLine("enter 2 to see hwo much days was ordered");
                Console.WriteLine("enter 3 to exit");
                choice = Convert.ToInt32(Console.ReadLine()); // get in the choice
                switch (choice)
                {
                    case 0:


<<<<<<< HEAD
=======
                    Console.WriteLine("please enter the date of the visit");
                    string date = Console.ReadLine();
                    String[] s = date.Split(new char[] { '.' ,'/' });
                    int day = Convert.ToInt32(s[0]);
                    int month = Convert.ToInt32(s[1]);
                    Console.WriteLine("please enter the duration of the visit");
                    int duration = Convert.ToInt32(Console.ReadLine());
                    if (host[month, day] == true)
                    {
                        if (host[month, day + 1] == true)
                            break;

                    }
                    for (int i = 1; i < duration; i++)
                    {
                        if (host[month, day + i] == true)
                        {
                            if (host[month, day + i - 1] == true)
                            {
                                add
                            }
                        }
                    }

>>>>>>> 8899002002d17eecd4abc47043693ba3c93c0923
                        break;

                    case 1:
                        firstDay = false;

                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 31; j++)
                            {
                                if (host[i, j]) // if this day is ordered
                                {
                                    if (!firstDay) // if this is the first day of the order
                                    {
                                        firstDay = true; 
                                        Console.WriteLine("{0}.{1}", j, i);
                                    }
                                }
                                else if (firstDay) // if this is the last day of the order
                                {
                                    firstDay = false;
                                    Console.WriteLine("{0}.{1}", j, i);
                                }
                            }
                        }
                        break;

                    case 2:
                        counter = 0;
                        flag = false;
                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 31; j++)
                            {
                                if (host[i, j])
                                {
                                    counter++;
                                    if (j == 30)
                                        flag = true;
                                }
                                else if (flag)
                                {
                                    counter++;
                                    flag = false;
                                }
                                else if (host[i, j - 1])
                                    counter++;
                            }
                        }
                        Console.WriteLine("number of ordered days in this year: {0}", counter);
                        Console.WriteLine("yearly occupancy: {0}", counter / 372);
                        break;

                    case 3:
                        Console.WriteLine("Goodbye");
                        running = false;
                        break;

                    default:
                        break;
                }
            }


            return 0;
        }
    }
}
