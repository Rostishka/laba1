using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Masuv_2 : Masuv
    {
        private int cols;
        private int rows;

        public int Cols
        {
            get { return cols; }
            set { cols = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public void Creating_2(int[,] array)
        {
            array = new int[cols, rows];
        }

        public void Generation_2(int[,] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    array[i, j] = rnd.Next(-21, 21);
                }
            }
        }

        public void Showing_2(int[,] array)
        {
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public void Adding(int[,] array)
        {
            Size = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (array[i, j] > 0) Size++;
                }
            }

            int[] array_2_1 = new int[Size];

            Generation(array_2_1);
            Showing(array_2_1);
        }
    }
}
