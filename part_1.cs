/*
 * 19.11.19
 * Daniel Posen 211801840
 * Matanya Finkelstein 211479902
 * ex 1.1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNet5780_01_1840_9902_1
{
    class part_1
    {
        public static int Main(string[] args)
        {
            Random r = new Random();

            int[] A, B, C; // the arrays
            A = new int[20];
            B = new int[20];
            C = new int[20];
            for (int i = 0; i < 20; i++)
            {
                A[i] = r.Next(18, 122); // fill up the arrays with random numbers
                B[i] = r.Next(18, 122);
                C[i] = Math.Abs(A[i] - B[i]); // calculate the difference between the numbers in every array
            }
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", A[i]); // print the first array
            }
            Console.WriteLine(); // print enter
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", B[i]); // print the second array
            }
            Console.WriteLine(); // print enter
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0,5}", C[i]); // print the thired array
            }
            Console.ReadKey();
            return 0;
        }
    }
}
