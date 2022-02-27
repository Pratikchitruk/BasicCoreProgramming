using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicCoreProgramming

{
    public class factors
    {
       public static void findThefactors()
        {
            int num, x;
            Console.WriteLine("Enter the Number ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The Factors are : ");
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();

        }
    }
}
