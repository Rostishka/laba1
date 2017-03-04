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

            int[] arr1 = new int[10];

            masuv.Creating(arr1);
            masuv.Generation(arr1);
            masuv.Showing(arr1);
            masuv.Sorting(arr1);


            Console.ReadKey();
        }
    }
}
