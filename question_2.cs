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
            host = new bool[12,31];
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 31; j++)
                {
                    host[i, j] = false;
                }
            }
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
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
                        if (host[month,day+i] == true)
                        {
                            if(host[month, day + i-1] == true)
                                {

                                }
                        }
                    }
                    

                    break;
                case 1:
                case 2:
                case 3:
                    break;
                default:
                    break;
            }



            return 0;
        }
    }
}
