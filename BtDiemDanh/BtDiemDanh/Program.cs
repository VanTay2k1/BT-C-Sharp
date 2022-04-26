using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtDiemDanh
{
    class Program
    {
            public class Animal_150
            {

                public void Eat_150()
                {
                    Console.WriteLine("đang ăn. . .");
                }
                public void MakeSound()
                {
                    Console.WriteLine("đang phát ra tiếng kêu.");
                }
            }
            class Cat_150 : Animal_150
            {
                public void Run_150()
                {
                    Console.WriteLine("Mèo đang chạy trên đường.");
                }
                Animal_150 animal = new Animal_150();

            }
            class Bird : Animal_150
            {
                public void Fly()
                {
                    Console.WriteLine("Chim đang bay trên trời.");
                }

            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Cat_150 cat = new Cat_150();
                cat.Run_150();
                cat.Run_150();
                Bird bird = new Bird();
                bird.Fly();
                bird.MakeSound();
                Console.ReadKey();
            }
        }
}

