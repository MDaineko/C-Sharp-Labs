using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A(3, 5);
            B classB = new B(6,3);
            Console.WriteLine("Свойство с2: " + classB.c2);
        }
    }
    class A
    {
        public int a;
        public int b;
        public int c
        {
            get { return a *= (a + b); }
            set{ a = value; }
        }
        public A(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public A () {}
    }
    
    class B : A
    {
        public int d;
        public int i;
        public int[] arr;
        
        public int c2 
        {
            get { 
                while(d < 15)
                    d = d + a + b;
                return d;
            }
            set{ c2 = value; }
        }
        
        public B (int var1, int var2)
        {
            a = var1;
            d = var2;
            arr = new int[a];
             
            for (i = 0; i < arr.Length; i++){
                arr[i] = c2 * i;
            }
            foreach(int i in arr) 
                Console.WriteLine(i);
        }
    }
}