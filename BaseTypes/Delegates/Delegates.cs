using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public delegate void MyDelegate1(string param1);
    public delegate int MyDelegate2();
    public delegate int MyDelegate3();
    public delegate string MyDelegate4(out string param1);
    //Functors that are defined in the .net framework
    public delegate TResult Func1<TParam1, TResult>(TParam1 param1);
    public delegate TResult Func1<TParam1, TParam2, TResult>(TParam1 param1, TParam2 param2);

    //Actions ""
    public delegate void Action1<TParam1, TParam2>();
    //""

    //Predicates
    public delegate bool Predicate<TParam1>();
    //""

    class SubDelegates : Delegates<string> { }
    class SubDelegates<T> : Delegates<T> { }

    class Delegates<T>
    {
        MyDelegate1 myDelegate;

        public Delegates()
        {
            this.myDelegate = this.MyDelegateInstance;
            //Anonymous function (method)
            this.myDelegate = delegate (string param1) { };
            //Lambda expressions
            this.myDelegate = (string param1) => Console.WriteLine();
            MyDelegate2 myDelegate2 = () => 1;
            MyDelegate2 myDelegate21 = () =>
                {
                    return 1;
                };
            Func1<int, Delegates<string>, string> a = (age, delegatesInstance) => delegatesInstance(1);
            string result = a(1,(myInt) => "");
            Func1<int, int, string> b;
            //MyDelegate3
            MyDelegate4 myd4 = 


        }

        public void MyMethod(out string myString)
        {
            myString = "";
        }

        public void MyDelegateInstance(string param2)
        {

        }


        public static void Main()
        {
            Delegates<string> d = new Delegates<string>();
            Console.WriteLine("d.MyDelegate: {0}", d.myDelegate);
            Console.ReadLine();
        }
    }
}
