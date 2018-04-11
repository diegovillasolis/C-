using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassLibraryExamples
{
    public delegate int MyDelegado(int param1);
    public delegate MyDelegado MyDelegado2(int param1);

    [Flags]
    public enum MyEnum : long
    {
        Pair1 = 0x01,
        Pair2 = 0x02
    }

    struct PersonStructB
    {
        int legs;
        //PersonStructA a;
    }

    struct PersonStructA
    {
        int age;
        int hands;
        PersonStructB b;
    }

    public abstract class AbstractClass
    {
        public string HowToRun()
        {
            string steps = HowToCrawl();
            steps += HowToWalk();
            return steps;
        }

        public abstract string HowToCrawl();
        public abstract string HowToWalk();
    }

    public class MyDerivedClass : AbstractClass
    {
        public override string HowToCrawl()
        {
            return "..";
        }

        public override string HowToWalk()
        {
            return ";;";
        }
    }

    interface IMyInterface2
    {
        string GetLastName();
        string GetName();
    }
    interface IMyInterface
    {
        int MyProperty { get; set; }
        string GetName();
    }

    class Father : Person, IMyInterface, IMyInterface2
    {
        public MyDelegado Field;
        public event MyDelegado EventField;

        public string GetLastName()
        {
            Field = this.CualquierCosa;
            MyDelegado field2 = this.CualquierCosa;
            MyDelegado2 field3 = this.CualquierCosa2;

            this.EventField += this.CualquierCosa;
            this.EventField += this.CualquierCosa;

            this.EventField(1);

            field3(1)(2);
            field2(1);

            return "LastNAme";
        }

        public int CualquierCosa(int parametro1)
        {
            return 0;
        }

        public MyDelegado CualquierCosa2(int parametro1)
        {
            return this.CualquierCosa;
        }

        //public string GetName()
        //{
        //    return "Name";
        //}

        string IMyInterface.GetName()
        {
            return "Name1";
        }

        string IMyInterface2.GetName()
        {
            return "Name2";
        }
    }

    class Person2 { }

    //sealed class Person
    class Person
    {
        public event EventHandler MyEvent;

        public int GetMyField()
        {
            return myField;
        }

        public void SetMyField(int value)
        {
            this.myField = value;
        }

        private int myField = 2;

        public int MyField
        {
            get
            {
                return myField + 4;
            }
            set
            {
                myField = value;
            }
        }

        public int MyFieldAutoProperty { get; set; }

        public int MyProperty { get; set; }

        public Person()
        {
        }

        public Person(int age)
        {
        }

        public void Run()
        {
        }

        public void Run(int meters)
        { }

        public string Run(string meters)
        {
            return null;
        }
    }
}
