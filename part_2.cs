/*
 * 19.11.19
 * Daniel Posen 211801840
 * Matanya Finkelstein 211479902
 * ex 1.2
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace dotNet5780_01_1840_9902_2
{
    class part_2
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
            double occupancy;
            bool flag, flag1, firstDay, running = true;

            Console.WriteLine("HELLO!");

            while (running)
            {
                Console.WriteLine("enter 0 to make an order");
                Console.WriteLine("enter 1 to print list of all of the ordered days");
                Console.WriteLine("enter 2 to see hwo much days was ordered");
                Console.WriteLine("enter 3 to exit");
                choice = Convert.ToInt32(Console.ReadLine()); // get in the choice
                switch (choice)
                {
                    case 0:

                        Console.WriteLine("please enter the date of the visit");
                        string date = Console.ReadLine();
                        String[] s = date.Split(new char[] { '.', '/' }); // in case we put in the date like this: xx.yy xx/yy
                        int day = Convert.ToInt32(s[0]); // the first part was the days
                        int month = Convert.ToInt32(s[1]); // the second part was the months
                        if (day > 31 || month > 12 || day < 1 || month < 1) //check if the date is valid
                        {
                            Console.WriteLine("Invalid values. please try again");
                            break;
                        }
                        Console.WriteLine("please enter the duration of the visit");
                        int duration = Convert.ToInt32(Console.ReadLine());
                        if (duration < 2) //check if the duration is valid
                        {
                            Console.WriteLine("Invalid value. please try again");
                            break;
                        }
                        if ((month - 1) * 31 + day + duration > 372) //check if the order deviate from this year
                        {
                            Console.WriteLine("Invalid value. please try again");
                            break;
                        }
                        day--; //because the array start from 0 so this is the date minus 1
                        month--; //because the array start from 0 so this is the date minus 1

                        flag = true;
                        int days, months;
                        for (int i = 0; i < duration; i++) // cheks if all of the days that has been orderd is empty
                        {
                            days = day + i; // the day in the month
                            months = month; // the month in the year
                            if (days >= 31) // if we got to the end of the month
                            {
                                months += days / 31; // the next month
                                days = days % 31; // the days that left from the next month
                            }
                            if (host[month, day] == true) // if the day is orderd already
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag) // if the order can be ordered
                        {
                            for (int i = 0; i < duration - 1; i++) // puts in all of the days - true
                            {
                                days = day + i;
                                months = month;
                                if (days >= 31)
                                {
                                    months += days / 31;
                                    days = days % 31;
                                }
                                if (months >= 12)
                                    months = months % 12;
                                host[months, days] = true;
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
                                        Console.WriteLine("{0}.{1}", j + 1, i + 1);
                                    }
                                }
                                else if (firstDay) // if this is the last day of the order
                                {
                                    firstDay = false;
                                    Console.WriteLine("{0}.{1}", j + 1, i + 1);
                                }
                            }
                        }
                        break;

                    case 2:
                        counter = 0;
                        flag = false;
                        flag1 = false;
                        for (int i = 0; i < 12; i++)
                        {
                            for (int j = 0; j < 31; j++)
                            {
                                if (host[i, j]) // if the day was ordered
                                {
                                    counter++;
                                    flag = true;
                                    if (j == 30) //if we are at the last day of the month
                                        flag1 = true;
                                }
                                else if (flag1) //if the previous day was in the previous month and it was ordered
                                {
                                    counter++;
                                    flag1 = false;
                                    flag = false;
                                }
                                else if (flag) //if the previous day was order and this isn't, it mean's this is the last day of the order
                                {
                                    flag = false;
                                    flag1 = false;
                                    counter++;
                                }
                            }
                        }
                        Console.WriteLine("number of ordered days in this year: {0}", counter);
                        occupancy = ((double)(100 * counter) / 372); //calculate the percentage of the ordered days from the year
                        Console.WriteLine("yearly occupancy: {0}", occupancy);
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

