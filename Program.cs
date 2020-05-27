using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;

namespace Курсач
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод объекта, который необходимо найти------------------------------------------
            Console.Write("Введите необходимый путь по типу C:/Users/Home/Desktop");
            Console.WriteLine();
            string line = Console.ReadLine();
            Console.WriteLine("Ваш путь : ");
            Console.WriteLine(line);

            DirectoryInfo dir = new DirectoryInfo(line);
            DirectoryInfo[] dirs = dir.GetDirectories();
            Console.WriteLine();
            foreach (DirectoryInfo currentDir in dirs)
            {
                Console.WriteLine(currentDir);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo currentFile in files)
            {
                Console.WriteLine(currentFile);
            }
            //--------------------------------------------------------------------------------

            //Если хотим пройтись глубже в выбранный объект-----------------------------------
            Console.Write("Введите необходимый путь по типу /English");
            Console.WriteLine();
            string line2 = Console.ReadLine();
            line = line + Convert.ToString(line2);
            DirectoryInfo dir2 = new DirectoryInfo(line);
            DirectoryInfo[] dirs2 = dir2.GetDirectories();
            Console.WriteLine();
            foreach (DirectoryInfo currentDir in dirs2)
            {
                Console.WriteLine(currentDir);
            }

            FileInfo[] files2 = dir2.GetFiles();
            foreach (FileInfo currentFile in files2)
            {
                Console.WriteLine(currentFile);
            }
            //--------------------------------------------------------------------------------

            //Если хотим вернуться на шаг выше------------------------------------------------
            Console.Write("Введите true, если хотите вернуться назад");
            Console.WriteLine();
            bool returnif = Convert.ToBoolean(Console.ReadLine());
            if (returnif == true)
            {
                foreach (DirectoryInfo currentDir in dirs)
                {
                    Console.WriteLine(currentDir);
                }

                foreach (FileInfo currentFile in files)
                {
                    Console.WriteLine(currentFile);
                }
            }
            //--------------------------------------------------------------------------------

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
            DirectoryInfo dirinfo = new DirectoryInfo(name);
            if(!dirinfo.Exists)
            {
                dirinfo.Create();
            }
            dirinfo.CreateSubdirectory(nameofkat);
            //--------------------------------------------------------------------------------

            //Удаление каталога---------------------------------------------------------------
            Console.Write("Введите необходимый путь по типу C:/Users/Home/Desktop/programa");
            Console.WriteLine();
            string dirName = Console.ReadLine();
            Console.WriteLine("Ваше место назначения : ");
            Console.WriteLine(dirName);
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //--------------------------------------------------------------------------------

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
            DirectoryInfo dirInfo1 = new DirectoryInfo(oldPath);
            if (dirInfo1.Exists && Directory.Exists(newPath) == false)
            {
                dirInfo1.MoveTo(newPath);
            }
            //--------------------------------------------------------------------------------
        }
    }
}
