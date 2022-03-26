using System;


namespace OOPLesson3
{
    /* Урок 3
     * 2. Реализовать метод, который в качестве входного параметра принимает 
     * строку string, возвращает строку типа string, буквы в которой идут в 
     * обратном порядке. Протестировать метод.
     * 3. Работа со строками. Дан текстовый файл, содержащий ФИО и e-mail адрес. 
     * Разделителем между ФИО и адресом электронной почты является символ &: 
     * Кучма Андрей Витальевич & Kuchma@mail.ru Мизинцев Павел Николаевич & 
     * Pasha@mail.ru Сформировать новый файл, содержащий список адресов электронной 
     * почты. Предусмотреть метод, выделяющий из строки адрес почты. Методу в 
     * качестве параметра передается символьная строка s, e-mail возвращается в 
     * той же строке s: public void SearchMail (ref string s).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            //часть 2 урока 3
            Lesson3 revStr = new Lesson3();
            revStr.Str = "возвращает строку типа string, буквы в которой идут в обратном порядке.";
            Console.WriteLine(revStr.Str);
            revStr.Str = revStr.ReversString(revStr.Str);
            Console.WriteLine(revStr.Str);

            //часть 3 урока 3
            MailFromFiles mailFromFiles = new MailFromFiles(@"..\..\FIOAndMail.txt", @"..\..\mail.txt");
            mailFromFiles.readFiles();

            Console.ReadLine();

        }

        
    }
}
