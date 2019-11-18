﻿using System;
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
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
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
                

                case 2:
                    break;

                case 3:
                    break;
                default:
                    break;
            }



            return 0;
        }
    }
}
