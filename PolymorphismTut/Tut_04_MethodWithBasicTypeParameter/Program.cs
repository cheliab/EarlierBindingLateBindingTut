using System;

namespace Tut_04_MethodWithBasicTypeParameter
{
    /// <summary>
    /// Пример передачи в метод ссылки на базовый класс
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Полиморфизм и позднее связывание
            
            // 1. Создаем экземпляры классов Base и Derived
            Base objBase = new Base();
            Derived objDerived = new Derived();
            
            // 2. Вызов метода с параметром базового типа
            // Передаем в метод объекты разных типов
            ShowInfo(objBase); // Выводится: Base.Info()
            ShowInfo(objDerived); // Выводится: Derived.Info()
            
            // Вывод:
            // Использование для параметра тип базового класса
            // позволяет сделать вызов метода Info всех классов
            // в иерархии наследования единообразным
            // Такой подход еще называется "один интерфейс"
            
            Console.ReadLine();
        }

        /// <summary>
        /// Статический метод с параметром базового типа
        /// </summary>
        /// <param name="refBase"></param>
        private static void ShowInfo(Base refBase)
        {
            // При вызове метода Info
            // Во время вызовы неизвестно, на экземпляр какого класса указывет параметр refBase
            // Это может быть как Base так и Derived
            // Из-за этого компилятор сможет сгенерировать окончательный код только во время выполнения
            // Этот процесс и называется поздним связыванием
            
            refBase.Info(); // единый интерфейс (вызов) для экзепляров дочерних классов 
        }
    }
}