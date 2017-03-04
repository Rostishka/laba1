using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Masuv
    {
        public int size;
        public string name;


        public int Size
            {
                get { return size; }
                set { size = value; }
            }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                else
                {
                    name = value;
                }
            }
        }

        public void Creating(int[] array)
        {
           array = new int[size];
        }

        public void Generation(int[] array)
        { 
            Random rnd = new Random();

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 21);
            }
        }

        public void Showing(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        public void Sorting(int[] array)
        {
            int temp, tem, indexMin = 0, indexMax = 0;
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                
                if (array[i] > max)
                {
                    max = array[i];
                    indexMax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    indexMin = i;
                }
            }

            if (indexMin != array.Length - 1)
            {
            temp = array[0];
            array[0] = min;
            array[indexMin] = temp;
            }

            if (indexMax != 0)
            {
                tem = array[array.Length - 1];
                array[array.Length - 1] = max;
                array[indexMax] = tem;
            }

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

        }
    }
}

