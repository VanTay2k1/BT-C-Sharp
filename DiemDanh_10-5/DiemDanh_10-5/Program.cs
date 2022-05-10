using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh_10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr_150 = new int[100];
            int i_150, mx_150, mn_150;


            Console.Write("Nhap {0} phan tu vao trong mang:\n", 10);
            for (i_150 = 0; i_150 < 10; i_150++)
            {
                Console.Write("Phan tu - {0}: ", i_150);
                arr_150[i_150] = Convert.ToInt32(Console.ReadLine());
            }


            mx_150 = arr_150[0];
            mn_150 = arr_150[0];

            for (i_150 = 1; i_150 < 10; i_150++)
            {
                if (arr_150[i_150] > mx_150)
                {
                    mx_150 = arr_150[i_150];
                }


                if (arr_150[i_150] < mn_150)
                {
                    mn_150 = arr_150[i_150];
                }
            }
            Console.Write("Phan tu lon nhat la: {0}\n", mx_150);
            Console.Write("Phan tu nho nhat la: {0}\n\n", mn_150);

            for (i_150 = 0; i_150 < 10; i_150++)
            {
                for (int j = i_150 + 1; j < 10; j++)
                {
                    if (arr_150[i_150] > arr_150[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        int temp_122 = arr_150[i_150];
                        arr_150[i_150] = arr_150[j];
                        arr_150[j] = temp_122;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr_150[i] + " ");
            }

            Console.ReadKey();
        }
    }
}