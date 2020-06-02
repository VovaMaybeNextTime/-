using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class Work
    {
        public static void WorkProgram()
        {
            bool exit = true;
            XmlWriter xmlWriter = XmlWriter.Create("Test.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Informations");
            xmlWriter.WriteStartElement("Description");
            xmlWriter.WriteString("  Для начала, вы вибираете, что вы хотите выполнить  ");
            xmlWriter.WriteString("  [1] - поиск необходимого каталога  ");
            xmlWriter.WriteString("  [2] - создание каталога  ");
            xmlWriter.WriteString("  [3] - удаление каталога  ");
            xmlWriter.WriteString("  [4] - перемещение каталога  ");
            xmlWriter.WriteString("  [5] - переименование каталога  ");
            xmlWriter.WriteString("  [6] - создание файла  ");
            xmlWriter.WriteString("  [7] - удаление файла  ");
            xmlWriter.WriteString("  [8] - перемещение файла  ");
            xmlWriter.WriteString("  [9] - переименование файла  ");
            xmlWriter.WriteString("  [10] - выход  ");
            xmlWriter.WriteEndElement();
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
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали поиск объекта, для поиска объекта необходимо передать его место нахождения по типу C:/Users/Home/Desktop  ");
                        xmlWriter.WriteEndElement();
                        GetDirectoryInformation.FindDirectory();
                        break;

                    case "[2]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали создание каталога, для создания каталога необходимо набрать место положения, где вы хотите создать этот каталог по типу C:/Users/Home/Desktop  ");
                        xmlWriter.WriteEndElement();
                        CreateCat.CreateCatalog();
                        break;

                    case "[3]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали удалить каталог, для удаления каталога необходимо набрать его место нахождения по типу C:/Users/Home/Desktop  ");
                        xmlWriter.WriteEndElement();
                        DeleteCat.DeleteCatalog();
                        break;

                    case "[4]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали переместить каталог, для перемещения каталога необходимо передать его старое место нахождения по типу C:/Users/Home/Desktop и новое по такому же типу  ");
                        xmlWriter.WriteEndElement();
                        CatMoveTo.CatalogMoveTo();
                        break;

                    case "[5]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали переименовать каталог, для переименования каталога необходимо передать его старое название по типу C:/Users/Home/Desktop и новое по такому же типу  ");
                        xmlWriter.WriteEndElement();
                        RenameCat.RenameCatalog();
                        break;

                    case "[6]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали создание файла, для создания файла необходимо набрать место положения, где вы хотите создать этот файл по типу C:/Users/Home/Desktop/program.txt  ");
                        xmlWriter.WriteEndElement();
                        CreateFl.CreateFile();
                        break;

                    case "[7]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали удалить файл, для удаления файла необходимо набрать его место нахождения по типу C:/Users/Home/Desktop/programa.txt  ");
                        xmlWriter.WriteEndElement();
                        DeleteFl.DeleteFile();
                        break;

                    case "[8]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали переместить файл, для перемещения файла необходимо передать его старое место нахождения по типу C:/Users/Home/Desktop/programa.txt и новое по такому же типу  ");
                        xmlWriter.WriteEndElement();
                        FileMoveTo.FileMoving();
                        break;

                    case "[9]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали переименовать файл, для переименования файла необходимо передать его старое название по типу C:/Users/Home/Desktop/programa.txt и новое по такому же типу  ");
                        xmlWriter.WriteEndElement();
                        RenameFl.RenameFile();
                        break;
                    case "[10]":
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Вы выбрали выйти из программы, спасибо за то, что пользуетесь нашими услугами:)  ");
                        xmlWriter.WriteEndElement();
                        exit = false;
                        break;
                    default:
                        xmlWriter.WriteStartElement("Info");
                        xmlWriter.WriteString("  Неверно введеное значение, введите по типу [1]  ");
                        xmlWriter.WriteEndElement();
                        Console.WriteLine("Неверно введеное значение");
                        string writePath = "C:/Users/Home/Desktop/hta.txt";
                        string text = "Неверно введеное значение!!!";
                        using (StreamWriter sw = new StreamWriter(writePath, false))
                        {
                            sw.WriteLine(text);
                        }
                        break;
                }
            } while (exit);
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
