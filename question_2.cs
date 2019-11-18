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
                    host[i, j] = false;
                }
            }
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
             

                    break;

                case 1:
                    bool flag = false, firstDay = false, lastDay = false;

                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 31; j++)
                        {
                            if (host[i, j])
                            {
                                if (!firstDay)
                                {
                                    firstDay = true;
                                    Console.WriteLine("{0}.{1}", j, i);
                                }
                                if(firstDay)
                                {
                                    if(host[i,j+1])
                                }
                            }
                        }
                    }
                    break;

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
