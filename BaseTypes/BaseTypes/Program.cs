using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //long MyBigInt = 1234567891;
            //try
            //{
            //    With Convert lanza exception
            //    int MyInt = Convert.ToInt32(MyBigInt);
            //    Console.WriteLine(MyBigInt);
            //    Console.ReadLine();
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Unable to convert {0} to an integer.", MyBigInt);
            //    Console.ReadLine();
            //}
            //Ex1
            //string date = "04/06/1990";

            //try
            //{
            //    //With Convert lanza exception
            //    DateTime dateTime = Convert.ToDateTime(date);
            //    Console.WriteLine(dateTime);
            //    Console.ReadLine();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Unable to convert {0} to a date.", date);
            //    Console.ReadLine();
            //}
            //FinEx1


            //string test = "Hi world!!";
            //foreach (char c in test)
            //{
            //    Console.WriteLine(((int)c));
            //}
            //Console.ReadLine();
            //New example
            //int i = 0;
            //foreach (string s in args)
            //{
            //    i++;
            //    Console.WriteLine("{0} Argument: {1}", i,s);
            //}
            //Console.ReadLine();
            //
            //System Enviroment
            //foreach (var x in System.Environment.GetEnvironmentVariables()) {
            //    Console.WriteLine(x);
            //} 


            //Console.ReadLine();

            //Console.WriteLine(System.Environment.);
            //
            // 
            //String name;
            //String age;

            //name = Console.ReadLine();
            //age = Console.ReadLine();

            //System.Console.ForegroundColor = System.ConsoleColor.Red;
            //Console.WriteLine("{0} {1}", name, age);
            //Console.ReadLine(); 
            //

            int num = new int();
            bool bool1 = new bool();
            double double1 = new double();
            long long1 = new long();
            DateTime dateTime = new DateTime();
            Console.WriteLine(num, bool1, double1, long1, dateTime);
            Console.ReadLine();
        }
    }
}
