﻿using System;

namespace CSharp.Params
{
    class Min
    {
        public int minVal(params int[] nums)  /////   int[] args = { 45, 67, 34 };  or  45, 67, 34
        {
            int m;
            if (nums.Length == 0)
            {
                Console.WriteLine("Ошибка: нет аргументов.");
                return 0;
            }
            m = nums[0];
            for (int i = 1; i < nums.Length; i++)
                if (nums[i] < m) m = nums[i];
            return m;

        }
    }

    class MyClass
    {
        public void showArgs(string msg, params int[] nums)
        {
            Console.Write(msg + ": ");
            foreach (int i in nums)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }

    class ParamsDemo
    {
        public static void Main()
        {
            Min ob = new Min();
            int min;
            int a = 10, b = 20;
            // Вызываем метод с двумя значениями

            min = ob.minVal(a, b);

            //Console.WriteLine("Минимум равен " + min);
            //// Вызываем метод с тремя значениями
            ///
            min = ob.minVal(a, b, -1);

            //Console.WriteLine("Минимум равен " + min);
            //// Вызываем метод с пятью значениями
            min = ob.minVal(18, 23, 3, 14, 25);
            Console.WriteLine("Минимум равен " + min);
            // Вызываем метод с int-массивом.


            int[] args = { 45, 67, 34, 9, 112, 8 };
            min = ob.minVal(args);
            Console.WriteLine("Минимум равен " + min);

            // Использование обычного параметра вместе с params-параметром
            //MyClass obj2 = new MyClass();
            //obj2.showArgs("Вот несколько целых чисел", 1, 2, 3, 4, 5);
            //obj2.showArgs("А вот еще два числа", 17, 20);
        }
    }
}
