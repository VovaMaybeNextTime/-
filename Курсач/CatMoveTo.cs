using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class CatMoveTo
    {
        public static void CatalogMoveTo()
        {
                Console.WriteLine("Вы выбрали переместить каталог");
                Console.WriteLine();
                //Перемещение каталога------------------------------------------------------------
                Console.Write("Введите название старого каталога по типу C:/Users/Home/Desktop/programa");
                Console.WriteLine();
                string oldPath = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(oldPath);
                Console.Write("Введите название нового каталога по типу C:/Users/Home/Desktop/programa");
                Console.WriteLine();
                string newPath = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(newPath);
            try
            {
                DirectoryInfo dirInfo1 = new DirectoryInfo(oldPath);
                if (dirInfo1.Exists && Directory.Exists(newPath) == false)
                {
                    dirInfo1.MoveTo(newPath);
                }
                //--------------------------------------------------------------------------------
            }
            catch
            {
                string writePath = "C:/Users/Home/Desktop/hta.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false))
                {
                    sw.WriteLine("Данные введены не верно или не существует данного каталога");
                }
            }
        }
    }
}
