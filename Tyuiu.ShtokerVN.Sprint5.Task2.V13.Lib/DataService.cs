using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ShtokerVN.Sprint5.Task2.V13.Lib
{
    public class DataService : ISprint5Task2V13
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str1 = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str1 = str1 + matrix[i, j] + ";";
                    }
                    else
                    {
                        str1 = str1 + matrix[i, j];
                    }
                }
                
                if (i != rows - 1)
                {
                    File.AppendAllText(path, str1 + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, str1);
                }

                str1 = "";
            }
            return path;
        }
    }
}
