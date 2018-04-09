using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        [Flags]
        enum MyEnum
        {
            a = 0x0001,
            b = 0x0002,
            c = 0x0004,
            d = 0x0008,
            e = 0x0010,
            f = 0x0020,
            g = 0x0040,
            h = 0x0080,
            i = 0x0100,
            j = 0x0200,
            k = 0x0400,
            l = 0x0800,
            m = 0x1000,
            n = 0x2000,
            o = 0x4000,
            p = 0x8000
        }

        static void Main(string[] args)
        {
            m1(MyEnum.b);
            m1(MyEnum.f);
            m2(MyEnum.a);
            m2(MyEnum.b);
            m2(MyEnum.j);
            Console.ReadLine();
        }

        private static void m1(MyEnum n)
        {
            if ((n & MyEnum.b) == MyEnum.b)
            {
                Console.WriteLine("n: {0}", n.ToString("X"));
            }
            else
            {
                Console.WriteLine("Error n: {0}", n.ToString("X"));
            }
        }

        private static void m2(MyEnum n)
        {
            if ((n & (MyEnum.a | MyEnum.b)) != 0)
            {
                Console.WriteLine("n: {0}", n.ToString("X"));
            }
            else
            {
                Console.WriteLine("Error n: {0}", n.ToString("X"));
            }
        }
    }
}
