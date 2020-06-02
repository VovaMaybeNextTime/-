using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class FileMoveTo
    {
        public static void FileMoving()
        {
                Console.WriteLine("Вы выбрали переместить файл");
                Console.WriteLine();
                //Перемещение файла---------------------------------------------------------------
                Console.Write("Введите название старого пути по типу C:/Users/Home/Desktop/programa.txt");
                Console.WriteLine();
                string oldPath2 = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(oldPath2);
                Console.Write("Введите название нового пути по типу C:/Users/Home/Desktop/programa.txt");
                Console.WriteLine();
                string newPath2 = Console.ReadLine();
                Console.WriteLine("Введенные данные : ");
                Console.WriteLine(newPath2);
            try
            {
                FileInfo fileInfo1 = new FileInfo(oldPath2);
                if (fileInfo1.Exists && Directory.Exists(newPath2) == false)
                {
                    fileInfo1.MoveTo(newPath2);
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
