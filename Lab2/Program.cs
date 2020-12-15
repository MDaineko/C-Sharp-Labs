using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(2,3);
            B classB = new B(3,5,10);
            
            Console.WriteLine("Свойство с2 = " + classB.c2);
        }
    }
    
    class A
    {
        public int a;
        public int b;

        public int c
        {
            get { return a *= (a + b); }
            set { a = value; }
        }

        

        public A() {}
    }
    
    class B : A
    {
        public int d;
        
        public B(int a, int b, int d) : base(a, b)
        {
            this.d = d;
            Console.WriteLine("B: a + b + d = " + (a + b + d));
        }

        public B(int d)
        {
            this.d = d;
            Console.WriteLine("B: d = " + d);
        }

        public int c2
        {
            get
            {
                while (d < 20)
                    d = d + a + b;
                return d;
            }
            set { c2 = value; }
        }
    }
}