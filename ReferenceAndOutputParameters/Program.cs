using System;
using System.Xml;


namespace ReferenceAndOutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b;

            Console.WriteLine("square ref: {0}",FindSquareRef(ref a));
            Console.WriteLine("find square out: {0}", FindSquareOut(out b));
            Console.WriteLine("{0}\n{1}", FindSquare(a), FindSquare(b));
            Console.ReadKey(true);

        }

        static int FindSquareRef(ref int n)
        {
            return n*n;
        }

        static int FindSquareOut(out int n)
        {
            n = 6;
            return n*n;
        }

        static int FindSquare(int n)
        {
            return n*n;
        }
    }
}
