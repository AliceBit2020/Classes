using System;

namespace CSharp.Classes1
{
    class Car
    {
        private string driverName;		// Имя водителя
        private int currSpeed;			// Текущая скорость

        public Car() : this("Нет водителя", 0)
        {

        }
        public Car(Car obj)/////  нет по умолчанию
        {
            driverName = obj.driverName;
            currSpeed = obj.currSpeed;
        }
        public Car(string driverName) : this(driverName, 0)
        {
        }
        public Car(string driverName, int speed) // Главный конструктор
        {
            this.driverName = driverName;
            currSpeed = speed;
        }
        public void SetDriver(string driverName) =>
            this.driverName = driverName;

        public void PrintState()		// Распечатка текущих данных
        {
            Console.WriteLine("{0} едет со скоростью {1} км/ч.",
                driverName, currSpeed);
        }   
        public void SpeedUp(int delta)	// Увеличение скорости
        {
            currSpeed += delta;
        }
    }

}
