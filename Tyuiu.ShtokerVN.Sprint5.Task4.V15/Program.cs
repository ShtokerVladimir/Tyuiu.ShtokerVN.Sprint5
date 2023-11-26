﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShtokerVN.Sprint5.Task4.V15.Lib;

namespace Tyuiu.ShtokerVN.Sprint5.Task4.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                                      *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                                                                        *");
            Console.WriteLine("* Задание #4                                                                                                                     *");
            Console.WriteLine("* Вариант #15                                                                                                                    *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                                              *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                                       *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле: y = sin(x) + x^2/2 и округлить до трех знаков                     *");
            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                               *");
            Console.WriteLine("**********************************************************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask4V15.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("**********************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                                     *");
            Console.WriteLine("**********************************************************************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
