using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShtokerVN.Sprint5.Task6.V12.Lib;

namespace Tyuiu.ShtokerVN.Sprint5.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                                                                  *");
            Console.WriteLine("* Тема: Обработка текстовых файлов                                                                                                                           *");
            Console.WriteLine("* Задание #6                                                                                                                                                 *");
            Console.WriteLine("* Вариант #12                                                                                                                                                *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                                                                          *");
            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                                                   *");
            Console.WriteLine("* Найти количество удвоенных букв нн в заданной строке.                                                                                                      *");
            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                                                           *");
            Console.WriteLine("**************************************************************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V12.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**************************************************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
