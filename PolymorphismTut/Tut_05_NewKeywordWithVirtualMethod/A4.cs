using System;

namespace Tut_05_NewKeywordWithVirtualMethod
{
    public class A4 : A3
    {
        /// <summary>
        /// Опять не виртуальный метод Print()
        ///
        /// Установить ключевое слово override уже нельзя
        /// Так, как цепочка была разорвана использованием new
        /// Далее при наследовании можно использовать только new
        /// </summary>
        public new void Print()
        {
            Console.WriteLine("A4.Print()");
        }
    }
}