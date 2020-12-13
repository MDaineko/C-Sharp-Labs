using System;

namespace Lab1
{
    class A
    {
        private int a = 3;
        private int b = 5;
        public int c
        {
            get
            {
                return a *= (a + b);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            Console.WriteLine(classA.c);
            Console.ReadKey();
        }
    }
}