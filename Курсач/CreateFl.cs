using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

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
            try
            {
                FileInfo fileinfo = new FileInfo(nameoffile);
                if (!fileinfo.Exists)
                {
                    fileinfo.Create();
                }
                //--------------------------------------------------------------------------------
            }
            catch
            {
                string writePath = "C:/Users/Home/Desktop/hta.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false))
                {
                    sw.WriteLine("Данные введены не верно или такой файл уже создан");
                }
            }
        }
    }
}
