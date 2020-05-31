using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Курсач
{
    class GetDirectoryInformation
    {
        public static void FindDirectory()
        {
            Console.WriteLine("Вы выбрали поиск объекта");
            Console.WriteLine();
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
                Console.WriteLine(" " + currentDir);
                DirectoryInfo[] currdirs = currentDir.GetDirectories();
                foreach (DirectoryInfo currdir in currdirs)
                {
                    Console.WriteLine(" ├ " + currdir);
                    FileInfo[] currfiles1 = currdir.GetFiles();
                    foreach (FileInfo currfile1 in currfiles1)
                    {
                        Console.WriteLine("   ├ " + currfile1);
                    }
                }
                FileInfo[] currfiles = currentDir.GetFiles();
                foreach (FileInfo currfile in currfiles)
                {
                    Console.WriteLine(" ├ " + currfile);
                }
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo currentFile in files)
            {
                Console.WriteLine(" ├ " + currentFile);
            }
            //--------------------------------------------------------------------------------


            Console.Write("Введите true, если хотите пройтись глубже в каталоге");
            Console.WriteLine();
            bool goon = Convert.ToBoolean(Console.ReadLine());
            if (goon == true)
            {
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
                    Console.WriteLine("  ├ " + currentDir);
                }

                FileInfo[] files2 = dir2.GetFiles();
                foreach (FileInfo currentFile in files2)
                {
                    Console.WriteLine("  ├ " + currentFile);
                }
                //--------------------------------------------------------------------------------
            }

            //Если хотим вернуться на шаг выше------------------------------------------------
            Console.Write("Введите true, если хотите вернуться назад");
            Console.WriteLine();
            bool returnif = Convert.ToBoolean(Console.ReadLine());
            if (returnif == true)
            {
                foreach (DirectoryInfo currentDir in dirs)
                {
                    Console.WriteLine(" " + currentDir);
                    DirectoryInfo[] currdirs = currentDir.GetDirectories();
                    foreach (DirectoryInfo currdir in currdirs)
                    {
                        Console.WriteLine(" ├ " + currdir);
                        FileInfo[] currfiles1 = currdir.GetFiles();
                        foreach (FileInfo currfile1 in currfiles1)
                        {
                            Console.WriteLine("   ├ " + currfile1);
                        }
                    }
                    FileInfo[] currfiles = currentDir.GetFiles();
                    foreach (FileInfo currfile in currfiles)
                    {
                        Console.WriteLine(" ├ " + currfile);
                    }
                }
            }
            //--------------------------------------------------------------------------------
        }
    }
}
    
