using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShtokerVN.Sprint5.Task0.V10.Lib;

namespace Tyuiu.ShtokerVN.Sprint5.Task0.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                     *");
            Console.WriteLine("* Тема: Обработка файлов                                                                                        *");
            Console.WriteLine("* Задание #0                                                                                                    *");
            Console.WriteLine("* Вариант #10                                                                                                   *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                             *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                      *");
            Console.WriteLine("* Дано выражение, вычислить его значение при x = 2, результат сохранить  в текстовый файл OutPutFileTask0.txt и *");
            Console.WriteLine("* вывести на консоль. Округлить до трёх знаков после запятой                                                    *");
            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                              *");
            Console.WriteLine("*****************************************************************************************************************");

            Console.WriteLine("F(x) = 1.6x^3 - 2.1x^2 + 7x");
            Console.WriteLine("x = 2");

            Console.WriteLine("*****************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                    *");
            Console.WriteLine("*****************************************************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
