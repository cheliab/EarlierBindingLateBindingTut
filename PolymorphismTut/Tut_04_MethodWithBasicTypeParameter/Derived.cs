using System;

namespace Tut_04_MethodWithBasicTypeParameter
{
    /// <summary>
    /// Дочерный класс
    /// </summary>
    public class Derived : Base
    {
        /// <summary>
        /// Переопределяем унаследованный метод Info()
        /// </summary>
        public override void Info()
        {
            Console.WriteLine("Derived.Info()");
        }
    }
}