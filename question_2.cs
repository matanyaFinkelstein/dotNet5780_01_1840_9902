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
            int choice, counter;
            bool flag1, firstDay, running = true;

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

                    Console.WriteLine("please enter the date of the visit");
                    string date = Console.ReadLine();
                    String[] s = date.Split(new char[] { '.', '/' });
                    int day = Convert.ToInt32(s[0]);
                    int month = Convert.ToInt32(s[1]);
                    day--; //because the array start from 0 so this is the date minus 1
                    month--; //because the array start from 0 so this is the date minus 1
                    Console.WriteLine("please enter the duration of the visit");
                    int duration = Convert.ToInt32(Console.ReadLine());

                    bool flag = true;
                    for (int i = 0; i < duration; i++)
                    {
                        int days = day + i;
                        int months = month;
                        if (days >= 31)
                        {
                            months += days / 31;
                            days = days % 31;
                        }
                        if (host[month, day] == true)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        for (int i = 0; i < duration - 1; i++)
                        {
                            int days = day + i;
                            int months = month;
                            if (days >= 31)
                            {
                                months += days / 31;
                                days = days % 31;
                            }
                            host[month, day] = true;
                        }
                        Console.WriteLine("The request has been approved");
                    }
                    else
                        Console.WriteLine("The request has been rejected");
                    

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
                    flag1 = false;
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 31; j++)
                        {
                            if (host[i, j])
                            {
                                counter++;
                                if (j == 30)
                                    flag1 = true;
                            }
                            else if (flag1)
                            {
                                counter++;
                                flag1 = false;
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



            return 0;
        }
    }
}
