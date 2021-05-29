using System;
using Tut_02_ThreeClassesExample.EarlierBinding;
using Tut_02_ThreeClassesExample.LateBinding;

namespace Tut_02_ThreeClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EarlierBinding();
            LateBinding();
            
            Console.ReadLine();
        }

        /// <summary>
        /// Позднее связывание (вызывается метод объекта, который передали по ссылке базового типа)
        /// </summary>
        private static void LateBinding()
        {
            D refD;
            F objF = new F();
            refD = objF;
            refD.Print();
        }

        /// <summary>
        /// Ранее связывание (вызывается метод базового класса)
        /// </summary>
        private static void EarlierBinding()
        {
            A refA;
            C objC = new C();
            refA = objC;
            refA.Print();
        }
    }
}