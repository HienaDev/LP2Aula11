using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread T_One = new Thread(FrogJump);
            T_One.Name = "T_One";

            Thread T_Two = new Thread(FrogJump);
            T_Two.Name = "T_Two";

            Thread T_Three = new Thread(FrogJump);
            T_Three.Name = "T_Three";

            T_One.Start(1);
            T_Two.Start(2);
            T_Three.Start(3);
            T_One.Join();
            T_Two.Join();
            T_Three.Join();
        }

        public static void FrogJump(object obj)
        {
            Random rng = new Random((int)obj);

            for (int jump = 1; jump < 11; jump++)
            {

                Thread.Sleep((int)(rng.NextSingle() * 1000));

                Console.WriteLine($"Rã {obj} deu salto {jump} (thread {Thread.CurrentThread.Name})");
   
            }

            Console.WriteLine($"Rã {obj} terminou!");
            
        }
    }   
}
