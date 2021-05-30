using System;

namespace Tut_05_NewKeywordWithVirtualMethod
{
    /// <summary>
    /// Базовый класс иерархии
    /// </summary>
    public class A1
    {
        public virtual void Print()
        {
            Console.WriteLine("A1.Print()");
        }
    }
}