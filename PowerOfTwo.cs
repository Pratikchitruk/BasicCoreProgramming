using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramming
{
    public class Power
    {
       public static void PowerOfTwo()
        {
            Console.WriteLine(IsPowerOfTwo(9223372036854775809));
            Console.WriteLine(IsPowerOfTwo(4));
            Console.ReadLine();
        }
        static bool IsPowerOfTwo(ulong n)
        {
            if (n == 0)
                return false;
            while (n != 1)
            {
                if (n % 2 != 0)
                    return false;
                n = n / 2;
            }
            return true;
        }
    }
}
