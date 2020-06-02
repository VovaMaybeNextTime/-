using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class CreateCat
    {
        public static void CreateCatalog()
        {
                Console.WriteLine("Вы выбрали создать каталог");
                Console.WriteLine();
                //Создание каталога---------------------------------------------------------------
                Console.Write("Введите необходимый путь по типу C:/Users/Home/Desktop");
                Console.WriteLine();
                string name = Console.ReadLine();
                Console.WriteLine("Ваше место назначения : ");
                Console.WriteLine(name);
                Console.Write("Введите название каталога по типу programa");
                Console.WriteLine();
                string nameofkat = Console.ReadLine();
                Console.WriteLine("Ваше название каталога : ");
                Console.WriteLine(nameofkat);
            try
            {
                DirectoryInfo dirinfo = new DirectoryInfo(name);
                if (!dirinfo.Exists)
                {
                    dirinfo.Create();
                }
                dirinfo.CreateSubdirectory(nameofkat);
                //--------------------------------------------------------------------------------
            }
            catch
            {
                string writePath = "C:/Users/Home/Desktop/hta.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false))
                {
                    sw.WriteLine("Данные введены не верно или такой каталог уже существует");
                }
            }
        }
    }
}
