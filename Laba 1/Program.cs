using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Program
    {
    static void Main(string[] args)
        {
            
            Masuv masuv = new Masuv();
            masuv.Name = "my array";
            masuv.Size = 10;

            int[] arr1 = new int[masuv.Size];

            masuv.Creating(arr1);
            masuv.Generation(arr1);
            masuv.Showing(arr1);
            masuv.Sorting(arr1);
            masuv.ToSquare(arr1);
            masuv.Showing(arr1);

            Console.WriteLine();

            Masuv_2 masuv2 = new Masuv_2();
            masuv2.Name = "dvox";
            masuv2.Cols = 5;
            masuv2.Rows = 4;

            masuv2.GetName();

            int[,] arr2 = new int[masuv2.Cols, masuv2.Rows];

            masuv2.Creating_2(arr2);
            masuv2.Generation_2(arr2);
            masuv2.Showing_2(arr2);
            masuv2.Adding(arr2);
            masuv2.GetSize();


            Console.ReadKey();
        }
    }
}
