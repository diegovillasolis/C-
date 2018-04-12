using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        [Flags]
        enum MyEnum
        {
            A = 0x0001,
            B = 0x0002,
            C = 0x0004,
            D = 0x0008,
            E = 0x0010,
            F = 0x0020,
            G = 0x0040,
            H = 0x0080,
            I = 0x0100,
            J = 0x0200,
            K = 0x0400,
            L = 0x0800,
            M = 0x1000,
            N = 0x2000,
            O = 0x4000,
            P = 0x8F00
        }

        static void Main(string[] args)
        {
            M1(MyEnum.B);
            M2(MyEnum.A);
            M2(MyEnum.B);
            M1(MyEnum.H);
            M2(MyEnum.G);
            M(MyEnum.B);
            M(MyEnum.F);
            Console.WriteLine(MyEnum.P);
            Console.WriteLine(((int)MyEnum.B).ToString("X"));
            Console.ReadLine();
        }

        private static void M(MyEnum n)
        {
            if (n.Equals(MyEnum.B))
            {
                Console.WriteLine("{0}: B", ((int)MyEnum.B).ToString("X"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private static void M1(MyEnum n)
        {
            if ((n & MyEnum.B) == MyEnum.B)
            {
                Console.WriteLine("{0}: B", ((int)MyEnum.B).ToString("X"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        private static void M2(MyEnum n)
        {
            if ( ( n & ( MyEnum.A | MyEnum.B ) ) != 0 )
            {
                Console.WriteLine("{0} o {1}: A o B", ((int)MyEnum.A).ToString("X"), ((int)MyEnum.B).ToString("X"));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
