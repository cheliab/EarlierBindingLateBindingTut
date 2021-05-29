using System;

namespace Tut_04_MethodWithBasicTypeParameter
{
    /// <summary>
    /// Базовый класс
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Виртуальный метод Info
        /// </summary>
        public virtual void Info()
        {
            Console.WriteLine("Base.Info()");
        }
    }
}