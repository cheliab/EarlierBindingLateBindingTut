using System;

namespace Tut_05_NewKeywordWithVirtualMethod
{
    /// <summary>
    /// Класс, производный от А2
    /// </summary>
    public class A3 : A2
    {
        /// <summary>
        /// Невиртуальный метод Print()
        ///  
        /// new разрывает цепочку переопределения виртуальных методов
        ///
        /// В случае использования типа базового класса
        /// будет использован последний переопределенны метод
        /// т.е. A2.Print()
        /// </summary>
        public new void Print()
        {
            Console.WriteLine("A3.Print()");
        }
    }
}