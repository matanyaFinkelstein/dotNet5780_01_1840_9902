using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_1840_9902
{

    //it is so amazing!!

    class Program
    {
        public static int Main(string[] args)
        {
            Random r = new Random();
            int[] A, B, C;
            A = new int[20];
            B = new int[20];
            C = new int[20];
            for (int i = 0; i < 20; i++)
            {
                A[i] = r.Next(18, 122);
                B[i] = r.Next(18, 122);
                C[i] = Math.Abs(A[i]-B[i]);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}",A[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", B[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", C[i]);
            }
            Console.ReadKey();
            return 0;
        }
    }
}
