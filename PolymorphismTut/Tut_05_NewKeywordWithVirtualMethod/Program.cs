using System;

namespace Tut_05_NewKeywordWithVirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ссылка на базовый класс
            A1 refA1;

            // Создание экзепляров классов
            A1 objA1 = new A1();
            A2 objA2 = new A2();
            A3 objA3 = new A3();
            A4 objA4 = new A4();
            
            // Вызов метода Print у экзепляров

            refA1 = objA1;
            refA1.Print(); // Выводится: A1.Print() (Метод базового класса)

            Console.WriteLine(new string('-' , 20));
            
            refA1 = objA2;
            refA1.Print(); // Выводится: A2.Print() (Полиморфизм - вызывается переопределенный метод)

            Console.WriteLine(new string('-' , 20));

            refA1 = objA3;
            refA1.Print(); // Выводится: A2.Print() (Не полиморфизма - new прервало переопределение виртуальных методов)
            (refA1 as A3).Print(); // Выводится: A3.Print() (Статический полиморфизм)
            ((A3) refA1).Print(); // Так же: A3.Print()
            
            Console.WriteLine(new string('-' , 20));

            refA1 = objA4;
            refA1.Print(); // Выводится: A2.Print() (Так же нет полиморфизма)
            (refA1 as A4).Print(); // Выводится: A4.Print() (Статический полиморфизм)
            ((A4) refA1).Print(); // Выводится: A4.Print()
            
            Console.ReadLine();
        }
    }
}