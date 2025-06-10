using System;
using  CSharp.Classes1;
namespace CSharp.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            //Console.WriteLine("Конструктор по умолчанию");
            Car myCar = new Car();
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }

            Console.WriteLine("\n\nКонструктор с параметрами");
            myCar = new Car("Рубенс Барикелло");

            Car obj = new Car(myCar);
            obj.PrintState();
            myCar.PrintState();
            for (int i = 0; i <= 10; i++)
            {
                myCar.SpeedUp(5);
                myCar.PrintState();
            }




        }
    }
}
