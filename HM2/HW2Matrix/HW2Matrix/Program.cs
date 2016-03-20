﻿

namespace HW2Matrix
{
    using System;
    using System.Linq;
    using HW2Matrix.Classes;

    class Program
    {
        static void Main()
        {
            int row = 3, col = 3;

            var matrix1 = new Matrix<int>(row, col);

            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix1[r, c] = r + c + 2;
                }
            }

            row = 3;
            col = 3;
            var matrix2 = new Matrix<int>(row, col);
            for (int r = 0; r < row; r++)
            {
                for (int c = 0; c < col; c++)
                {
                    matrix2[r, c] = r + c;
                }
            }

            Console.WriteLine(matrix1);
            Console.WriteLine();
            Console.WriteLine(matrix2);

            //Console.WriteLine(matrix1+matrix2);
            //Console.WriteLine(matrix1- matrix2);

            Console.WriteLine(matrix1*matrix2);

            if (!matrix1)
            {
                Console.WriteLine("NO");
            }

            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
