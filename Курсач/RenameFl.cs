using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class RenameFl
    {
        public static void RenameFile()
        {
                Console.WriteLine("Вы выбрали переименовать файл");
                Console.WriteLine();
                //Переименование файла------------------------------------------------------------
                Console.Write("Введите название старого пути по типу C:/Users/Home/Desktop/programa.txt");
                Console.WriteLine();
                string oldPath3 = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(oldPath3);
                Console.Write("Введите название нового пути по типу C:/Users/Home/Desktop/programa.txt");
                Console.WriteLine();
                string newPath3 = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(newPath3);
            try
            {
                FileInfo fileInfo2 = new FileInfo(oldPath3);
                if (fileInfo2.Exists && Directory.Exists(newPath3) == false)
                {
                    fileInfo2.MoveTo(newPath3);
                }
                //--------------------------------------------------------------------------------
            }
            catch
            {
                string writePath = "C:/Users/Home/Desktop/hta.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false))
                {
                    sw.WriteLine("Данные введены не верно или не существует данного файла");
                }
            }
        }
    }
}
