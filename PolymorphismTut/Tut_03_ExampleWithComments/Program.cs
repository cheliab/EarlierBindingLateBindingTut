using System;
using Tut_03_ExampleWithComments.EarlierBinding;
using Tut_03_ExampleWithComments.LateBinding;

namespace Tut_03_ExampleWithComments
{
    class Program
    {
        static void Main(string[] args)
        {
            // EarlierBinding();
            LateBinding();
            
            Console.ReadLine();
        }

        /// <summary>
        /// Ранее связывание
        /// </summary>
        private static void EarlierBinding()
        {
            // 1. Объявляем переменную базового типа A
            A refA;
            
            // 2. Создаем экземпляры классов A, B
            A objA = new A();
            B objB = new B();
            
            // 3. Присваиваем переменной значение в виде объекта типа A
            refA = objA;
            
            // 3.1. Вызываем метод Print()
            // с помощью переменной базового типа
            refA.Print(); // Выводится: A.Print()
            
            // 4. Присваиваем переменной значение в виде объекта типа B
            refA = objB;
            
            // 4.1. Опять вызываем метод Print
            refA.Print(); // Выводится: A.Print()
        }

        /// <summary>
        /// Позднее связывание
        /// </summary>
        private static void LateBinding()
        {
            // 1. Создаем переменную базового типа
            C refC;
            
            // 2. Создаем экземпляры классов C, D
            C objC = new C();
            D objD = new D();
            
            // 3. Присваиваем переменной значение в виде объекта типа С
            refC = objC;
            
            // 3.1. Вызываем метод Print()
            refC.Print(); // Выводится: C.Print()

            // 4. Присваиваем переменой значение в виде объекта типа D
            refC = objD;
            
            // 4.1. Вызываем метод Print()
            refC.Print(); // Выводится: D.Print()
        }
    }
}