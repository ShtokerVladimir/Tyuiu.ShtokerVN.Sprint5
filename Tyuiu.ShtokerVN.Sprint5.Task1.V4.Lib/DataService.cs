using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtokerVN.Sprint5.Task1.V4.Lib
{
    public class DataService : ISprint5Task1V4
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double y;
            string str1;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    y = Math.Round((Math.Cos(x) / x + 1) - Math.Cos(x) * 1.3 + 3 * x, 2);
                    str1 = Convert.ToString(y);
                }
                else
                {
                    str1 = "0";
                }

                if (x != stopValue)
                {
                    File.AppendAllText(path, str1 + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str1);
                }
            }
            return path;
        }
    }
}
