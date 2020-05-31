using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Text;

namespace Курсач
{
    class DeleteFl
    {
        public static void DeleteFile()
        {
            Console.WriteLine("Вы выбрали удалить файл");
            Console.WriteLine();
            //Удаление файла------------------------------------------------------------------
            Console.Write("Введите необходимый путь по типу C:/Users/Home/Desktop/programa.txt");
            Console.WriteLine();
            string fileName = Console.ReadLine();
            Console.WriteLine("Ваше место назначения : ");
            Console.WriteLine(fileName);
            try
            {
                FileInfo fileInfo = new FileInfo(fileName);
                fileInfo.Delete();
                Console.WriteLine("Файл удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //--------------------------------------------------------------------------------
        }
    }
}
