using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Курсач
{
    class CreateFl
    {
        public static void CreateFile()
        {
            Console.WriteLine("Вы выбрали создать файл");
            Console.WriteLine();
            //Создание файла------------------------------------------------------------------
            Console.Write("Введите путь и название файла по типу C:/Users/Home/Desktop/programa.txt");
            Console.WriteLine();
            string nameoffile = Console.ReadLine();
            Console.WriteLine("Ваше название файла : ");
            Console.WriteLine(nameoffile);
            FileInfo fileinfo = new FileInfo(nameoffile);
            fileinfo.Create();
            //--------------------------------------------------------------------------------
        }
    }
}
