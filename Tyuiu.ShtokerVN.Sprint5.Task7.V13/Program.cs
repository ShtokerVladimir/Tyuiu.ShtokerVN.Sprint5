using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShtokerVN.Sprint5.Task7.V13.Lib;

namespace Tyuiu.ShtokerVN.Sprint5.Task7.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                                                                  *");
            Console.WriteLine("* Тема: Добавление к решеию итоговых проектов по спринту                                                                                                     *");
            Console.WriteLine("* Задание #7                                                                                                                                                 *");
            Console.WriteLine("* Вариант #13                                                                                                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                                                                          *");
            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                                                   *");
            Console.WriteLine("* Удалить все строчные латинские буквы из файла.Полученный результат сохранить в файл OutPutDataFileTask7V13.txt.                                            *");
            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                           *");
            Console.WriteLine("**************************************************************************************************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask7V13.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************************************************************");

            Console.WriteLine("Находится в файле: ");

            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
