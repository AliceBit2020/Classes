using System;
namespace Overload
{
    class A
    {
        public void test(int a)
        {
            Console.WriteLine("int");
        }
        public void test(int a, int b = 10, int c = 20)//////  ok
        {
            Console.WriteLine("default parametr: {0}, {1}, {2} ", a, b, c);
        }

        public void test(short a)
        {
            Console.WriteLine("short");
        }
        public void test(double a)
        {
            Console.WriteLine("double");
        }
        public void test(ref int a)
        {
            Console.WriteLine("ref int");
        }

       /*
        public void test(out int a)//������ ������� ��� ���������� � ref � out �� ����   � ��� �� ���.
        {
            Console.WriteLine("out int");
            a = 10;
        }
       */

        public void test(params int[] a)///  any count of params
        {
            Console.WriteLine("params");
            foreach (var i in a)
                Console.Write(" "+i);

            Console.WriteLine();
        }

     

    }
    class Sample
    {
        public static void Main()
        {
            int a = 45;
            A r = new A();
            r.test(a); // ��������� � int
            r.test(ref a); // ref int
            //r.test(2.4); // double
            //short d = 1;
            //r.test(d); // short
            //byte x = 1;
            //r.test(x); // short
            //r.test('A'); // int


            r.test(1); // int
            r.test(1, 2); // default parametr
            r.test(1, 2, 3); // default parametr
            r.test(1, 2, 3, 4); // params
        }
    }
}
