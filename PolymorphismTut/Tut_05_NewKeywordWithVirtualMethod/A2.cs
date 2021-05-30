using System;

namespace Tut_05_NewKeywordWithVirtualMethod
{
    /// <summary>
    /// Класс, производный от А1
    /// </summary>
    public class A2 : A1
    {
        /// <summary>
        /// Переопределенный метод
        /// </summary>
        public override void Print()
        {
            Console.WriteLine("A2.Print()");
        }
    }
}