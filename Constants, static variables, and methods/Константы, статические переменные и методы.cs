using System;

class SomeClass
{
    // ���������� ��������� ������������� ����� static !
    // ����� ���������� ��������� ��������������� 
    const int a = 2000;
    public readonly string s;
    // const string t = DateTime.Now.ToString(); // ������������� ��������� �� ���������
    static int i = 100;
    public static int GetI()
    {
        return i;
    }
    public static void SetI(int k)
    {
        i = k;
    }

    public void SetS(string k) => s = k;
    public SomeClass()
    {
        Console.WriteLine("����������� �� ���������");
       // s = DateTime.Now.ToString();
       // a = 9;
    }
    static SomeClass()
    {
        Console.WriteLine("Static constructor");
        Console.WriteLine("������� �����: ");
        i = Convert.ToInt32(Console.ReadLine());
    }
    public static int GetA()
    {
        return a;
    }
}

class Test
{
    static void Main()
    {
        SomeClass obj = new SomeClass();

        SomeClass obj2 = new SomeClass();


        //Console.WriteLine(obj.s);
        //Console.WriteLine(SomeClass.GetI());
        //Console.WriteLine(SomeClass.GetA());
        //SomeClass.SetI(5);
        //Console.WriteLine(SomeClass.GetI());
        //SomeClass.SetI(500);
        //Console.WriteLine(SomeClass.GetI());
    }
}


