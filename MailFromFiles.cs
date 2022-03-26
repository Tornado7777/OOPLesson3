using System.IO;
using System;


    /*3.Работа со строками.Дан текстовый файл, содержащий ФИО и e-mail адрес. 
     * Разделителем между ФИО и адресом электронной почты является символ &: 
     * Кучма Андрей Витальевич & Kuchma @mail.ru Мизинцев Павел Николаевич & 
     * Pasha @mail.ru Сформировать новый файл, содержащий список адресов электронной 
     * почты.Предусмотреть метод, выделяющий из строки адрес почты.Методу в 
     * качестве параметра передается символьная строка s, e-mail возвращается в
     * той же строке s: public void SearchMail(ref string s).*/

namespace OOPLesson3
{
    internal class MailFromFiles
    {
        private string _path;
        private string _outFileName;
        public string Path { get { return _path; } set { _path = value; } }
        public string OutFileName { get { return _outFileName; } set { _outFileName = value;} }

        public MailFromFiles(string path, string outFileName)
        {
            _path = path;
            _outFileName = outFileName;
        }
        public void readFiles()
        {
            if (_path != null)
            {
                string[] mailAndFIO = File.ReadAllLines(_path); //@"C:\Cars.csv"
                for (int i = 0; i < mailAndFIO.Length; i++)
                {
                    SearchMail(ref mailAndFIO[i]);
                    WriteFiles(mailAndFIO[i]);
                }
            }
            else Console.WriteLine("Задайте путь к файлу") ;
            
        }

        public void SearchMail(ref string s)
        {
            string[] mailAndFioRow = s.Split('&');
            s = mailAndFioRow[1].Trim() +"\n";
        }

        private void WriteFiles(string s)
        {
            File.AppendAllText(_outFileName, s);
            //File.WriteAllText(_outFileName,s);
        }
    }
}
