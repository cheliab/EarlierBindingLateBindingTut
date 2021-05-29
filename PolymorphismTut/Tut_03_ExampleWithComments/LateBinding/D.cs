using System;

namespace Tut_03_ExampleWithComments.LateBinding
{
    /// <summary>
    /// Унаследованный класс
    /// </summary>
    public class D : C
    {
        public override void Print()
        {
            Console.WriteLine("D.Print()");
        }
    }
}