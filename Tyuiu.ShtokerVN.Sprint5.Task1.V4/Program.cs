using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.ShtokerVN.Sprint5.Task1.V4.Lib;

namespace Tyuiu.ShtokerVN.Sprint5.Task1.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Штокер В.Н. | ИИПб-23-1";

            Console.WriteLine("******************************************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                                                      *");
            Console.WriteLine("* Тема: Запись набора данных в текстовый файл                                                                    *");
            Console.WriteLine("* Задание #1                                                                                                     *");
            Console.WriteLine("* Вариант #4                                                                                                     *");
            Console.WriteLine("* Выполнил: Штокер Владимир Николаевич  | ИИПб-23-1                                                              *");
            Console.WriteLine("******************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                       *");
            Console.WriteLine("* Дана функция, F(x) = cos(x)/x + 1 - cos(x) * 1,3 + 3 * x (произвести табулирование) f(x) на заданном           *");
            Console.WriteLine("* диапазоне [-5; 5] с шагом 1 Произвести проверку деления на 0. При делении на ноль вернуть значение 0          *");
            Console.WriteLine("* результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу. Значения округлить    *");
            Console.WriteLine("* до двух знаков после запятой                                                                                   *");
            Console.WriteLine("******************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                               *");
            Console.WriteLine("******************************************************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("******************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                     *");
            Console.WriteLine("******************************************************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            double[] ValueArray;
            int len = (stopValue - startValue) + 1;
            ValueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                ValueArray[count] = Math.Round((Math.Cos(x) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x, 2);
                count++;
            }

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|     X    |    F(x)   ");
            Console.WriteLine("+----------+-----------");

            for (int i = 0; i <= ValueArray.Length - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1,6:f2}   |", startValue, ValueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");
            Console.ReadLine();
        }
    }
}
