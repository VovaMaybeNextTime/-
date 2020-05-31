using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Курсач
{
    class RenameCat
    {
        public static void RenameCatalog()
        {
            Console.WriteLine("Вы выбрали переименовать каталог");
            Console.WriteLine();
            //Переименование каталога---------------------------------------------------------
            Console.Write("Введите старое название по типу C:/Users/Home/Desktop/programa");
            Console.WriteLine();
            string oldPath1 = Console.ReadLine();
            Console.WriteLine("Введенные данные : ");
            Console.WriteLine(oldPath1);
            Console.Write("Введите новое название по типу C:/Users/Home/Desktop/programa");
            Console.WriteLine();
            string newPath1 = Console.ReadLine();
            Console.WriteLine("Введенные данные : ");
            Console.WriteLine(newPath1);
            DirectoryInfo renInfo = new DirectoryInfo(oldPath1);
            if (renInfo.Exists && Directory.Exists(newPath1) == false)
            {
                renInfo.MoveTo(newPath1);
            }
            //--------------------------------------------------------------------------------
        }
    }
}
