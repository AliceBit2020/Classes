namespace _4._1_Autoprop
{

    public class TestAutoProp
    {
        public string? Name_g_s/////  автовластивість ---->  автоматично створиться поле(данні)  до якого ми звертаємось через автовластивість
        {
            get;
            set;
        }
        public string? Name_g_i////   ЗАДАЄМО ЗНАЧЕННЯ ЛИШЕ НА МОМЕНТ СТВОРЕННЯ:  а) в конструкторі  b) через ініціалізатори на момент створення
        {
            get;
            init;
        }
        public string? Name_g///  ЗАДАЄМО ЗНАЧЕННЯ ЛИШЕ НА МОМЕНТ СТВОРЕННЯ:  а) в конструкторі
        {
            get;
        }
        public string Name_g_sprivat///  можемо задати значення в конструкторі, і задаємо значення в середині методів класу
        {
            get;
            private set;//// set працює в пиватній частині
        } = "default";

        //public TestAutoProp(string n)
        //{
        //    Console.WriteLine("Ctor  public TestAutoProp(string n)");
        //    Name_g = n;
        //    Name_g_i = n;
        //    Name_g_s = n;
        //    Name_g_sprivat = n;
        //}
        //public TestAutoProp()////  default
        //{
        //    string n = "default ctor";
        //    Name_g = n;
        //    Name_g_i = n;
        //    Name_g_s = n;
        //    Name_g_sprivat = n;
        //}


        public void Func()
        {
            //Name_g = "new ";///error
            //Name_g_i = "new";//error
            Name_g_s = "new";//ok
            Name_g_sprivat = "new";//ok
        }




    }

        internal class Program
    {
        static void Main(string[] args)
        {
            //////Сtor

            //TestAutoProp obj = new TestAutoProp("test");

            //Console.WriteLine(obj.Name_g);
            //Console.WriteLine(obj.Name_g_i);
            //Console.WriteLine(obj.Name_g_s);
            //Console.WriteLine(obj.Name_g_sprivat);


            ////obj.Name_g_sprivat = "new";//error
            //// obj.Name_g_i = "new";//error


            //////get set
            ////obj.Name_g_s = "new";//ok   бо є set
            ////Console.WriteLine(obj.Name_g_s);  //  бо є set

            /////////////////////////////////////////////////////////////////////////////

            ///Ініціалізатори

            //TestAutoProp obj1 = new TestAutoProp { Name_g_i = "get_init", Name_g_s = "get_set" };////  ctor default TestAutoProp()



            TestAutoProp obj1 = new TestAutoProp { };////  ctor default TestAutoProp()

            Console.WriteLine($"Name_get_init: {obj1.Name_g_i}");
            Console.WriteLine($"Name_get : {obj1.Name_g}");
            Console.WriteLine($"Name_get_private_set : {obj1.Name_g_sprivat}");
            Console.WriteLine($"Name_get_set : {obj1.Name_g_s}");


        }
    }
}
