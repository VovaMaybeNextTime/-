using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Курсач
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool exit = true;
            do
            {
                Console.WriteLine("Выберите, что вы хотите выполнить");
                Console.WriteLine("[1] - поиск необходимого каталога");
                Console.WriteLine("[2] - создание каталога");
                Console.WriteLine("[3] - удаление каталога");
                Console.WriteLine("[4] - перемещение каталога");
                Console.WriteLine("[5] - переименование каталога");
                Console.WriteLine("[6] - создание файла");
                Console.WriteLine("[7] - удаление файла");
                Console.WriteLine("[8] - перемещение файла");
                Console.WriteLine("[9] - переименование файла");
                Console.WriteLine("[10] - выход");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "[1]":
                        GetDirectoryInformation.FindDirectory();
                        break;

                    case "[2]":
                        CreateCat.CreateCatalog();
                        break;

                    case "[3]":
                        DeleteCat.DeleteCatalog();
                        break;

                    case "[4]":
                        CatMoveTo.CatalogMoveTo();
                        break;

                    case "[5]":
                        RenameCat.RenameCatalog();
                        break;

                    case "[6]":
                        CreateFl.CreateFile();
                        break;

                    case "[7]":
                        DeleteFl.DeleteFile();
                        break;

                    case "[8]":
                        FileMoveTo.FileMoving();
                        break;

                    case "[9]":
                        RenameFl.RenameFile();
                        break;
                    case "[10]":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Неверно введеное значение");
                        break;
                }
            } while (exit);
        }
    }
}
