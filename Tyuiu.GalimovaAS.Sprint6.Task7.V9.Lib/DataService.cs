﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.GalimovaAS.Sprint6.Task7.V9.Lib
{
    public class DataService : ISprint6Task7V9
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, 2] >= 1 && matrix[r, 2] <= 5)
                {
                    matrix[r, 2] = 7;
                }
            }
            return matrix;
        }
    }
}
