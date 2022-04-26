using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtDiemDanh
{
    class Program
    {
            public class Animal
            {

                public void Eat()
                {
                    Console.WriteLine("đang ăn. . .");
                }
                public void MakeSound()
                {
                    Console.WriteLine("đang phát ra tiếng kêu.");
                }
            }
            class Cat : Animal
            {
                public void Run()
                {
                    Console.WriteLine("Mèo đang chạy trên đường.");
                }
                Animal animal = new Animal();

            }
            class Bird : Animal
            {
                public void Fly()
                {
                    Console.WriteLine("Chim đang bay trên trời.");
                }

            }
            static void Main(string[] args)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Cat cat = new Cat();
                cat.Run();
                cat.Run();
                Bird bird = new Bird();
                bird.Fly();
                bird.MakeSound();
                Console.ReadKey();
            }
        }
}

