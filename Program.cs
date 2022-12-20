using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_1_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the n2");
            int n2 = int.Parse(Console.ReadLine());

            for (int a = n1; a < n2; a++)
            {

                bool prime = true;

                for (int x = 2; x < a; x++)


                    if (a % x == 0)
                        prime = false;

                if (prime && a != 1)
                    Console.Write(a + " ");

            }




            Console.ReadKey();


        }
    }
}
