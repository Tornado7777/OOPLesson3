using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson3
{
    /* Урок 3
     * 2. Реализовать метод, который в качестве входного параметра принимает 
     * строку string, возвращает строку типа string, буквы в которой идут в 
     * обратном порядке. Протестировать метод.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Lesson3 revStr = new Lesson3();
            revStr.Str = "возвращает строку типа string, буквы в которой идут в обратном порядке.";
            Console.WriteLine(revStr.Str);
            revStr.Str = revStr.ReversString(revStr.Str);
            Console.WriteLine(revStr.Str);
            Console.ReadLine();

        }

        
    }
}
