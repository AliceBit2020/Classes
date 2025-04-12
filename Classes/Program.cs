using System;
using  CSharp.Classes1;
namespace CSharp.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student();
            st1.studentID = 1;  ////  екземплярне поле
            //st1.ShowAcademy();
            //st1academyName;




            Student.ShowAcademy(); // статический метод
            //Console.WriteLine("Оценка: {0}", st1.GetMark());

            //Console.WriteLine("Конструктор по умолчанию");
            Car myCar = new Car();
            //for (int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}

            //Console.WriteLine("\n\nКонструктор с параметрами");
            //myCar = new Car("Рубенс Барикелло");

            //Car obj = new Car(myCar);
            //obj.PrintState();
            //myCar.PrintState();
            //for (int i = 0; i <= 10; i++)
            //{
            //    myCar.SpeedUp(5);
            //    myCar.PrintState();
            //}

            //string s1 = "ddd";
            //string s2 = s1;

            //s1= "kkk";

            //Console.WriteLine("{0}  {1} ",s1, s2);


        }
    }
}
