﻿using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Курсач
{
    class DeleteCat
    {
        public static void DeleteCatalog()
        {
            Console.WriteLine("Вы выбрали удалить каталог");
            Console.WriteLine();
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
                string writePath = "C:/Users/Home/Desktop/hta.txt";
                using (StreamWriter sw = new StreamWriter(writePath, false))
                {
                    sw.WriteLine(ex.Message);
                }
            }
            //--------------------------------------------------------------------------------
        }
    }
}
