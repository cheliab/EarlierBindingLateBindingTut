using System;
using Tut_01_SimpleExample.EarlierBinding;
using Tut_01_SimpleExample.LateBinding;

namespace Tut_01_SimpleExample
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
        private static void EarlierBinding() {
            A refA; // ссылка на А
            B objB = new B(); // ссылка на объект класса B
            refA = objB; // приведение объекта в базовому типу
            refA.Print(); // вызовется метод Print из класса A
        }

        /// <summary>
        /// Позднее связывание
        /// </summary>
        private static void LateBinding()
        {
            C refC; // ссылка на тип С
            D objD = new D(); // ссылка на объект класса D
            refC = objD; // приведение объекта к базовому типу
            refC.Print(); // вызовется метод Print класса D (т.е. дочернего класса)
            
            // Класс D переписывает метод Print родительского класса
        }
    }
}