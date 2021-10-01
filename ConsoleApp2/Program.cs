using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyClass
    {
        int myField;
        public MyClass(int x)
        {

        }
        public MyClass(string x)
        {

        }
        public void MyMethod(int x)
        {
            if (MyEvent != null)
                MyEvent(x);
        }
        public void MyMethod(string x)
        {
            this.x = x;
        }
        string x = null;
        public string MyProperty
        {
            set { if (x == null) x = value; }
            get { return x; }
        }
        public char this[int index]
        {
            get { return this.x[index]; }
        }

        public delegate void MyDelehate(int x);
        public event MyDelehate MyEvent;
        public static MyClass operator + (MyClass a, MyClass b)
        {
            return new MyClass(a.myField + b.myField);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass(3);
            MyClass b = new MyClass("6");
            MyClass c = a + b;

            a.MyEvent += A_MyEvent;
            a.MyMethod(3);
            Console.ReadKey();

        }

        private static void A_MyEvent(int x)
        {
            Console.WriteLine(x);
        }
    }
}
