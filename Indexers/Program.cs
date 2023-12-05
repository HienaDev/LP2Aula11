using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vec = new MyVector(0, 2);
            MyVector vecOther = new MyVector(5, 30);

            
            Console.WriteLine(vec[0]);
            Console.WriteLine(vec["x"]);
            Console.WriteLine(vec["a"]);
            Console.WriteLine(vec["0"]);

            Console.WriteLine();

            Console.WriteLine(vec[1]);
            Console.WriteLine(vec["y"]);
            Console.WriteLine(vec["b"]);
            Console.WriteLine(vec["1"]);

            Console.WriteLine();

            vec[0] = 5;
            Console.WriteLine(vec[0]);
            vec["x"] = 10;
            Console.WriteLine(vec[0]);
            vec["a"] = 15;
            Console.WriteLine(vec[0]);
            vec["0"] = 20;
            Console.WriteLine(vec[0]);
            Console.WriteLine();
            vec[1] = 4;
            Console.WriteLine(vec[1]);
            vec["y"] = 6;
            Console.WriteLine(vec[1]);
            vec["b"] = 8;
            Console.WriteLine(vec[1]);
            vec["1"] = 10;
            Console.WriteLine(vec[1]);

            Console.WriteLine();

            Console.WriteLine(vec[0]);
            Console.WriteLine(vec["x"]);
            Console.WriteLine(vec["a"]);
            Console.WriteLine(vec["0"]);
            
            Console.WriteLine();

            Console.WriteLine(vec[1]);
            Console.WriteLine(vec["y"]);
            Console.WriteLine(vec["b"]);
            Console.WriteLine(vec["1"]);

            Console.WriteLine();

            Console.WriteLine((vec + vecOther));
            Console.WriteLine((vec - vecOther));
            Console.WriteLine(vec > vecOther);
            Console.WriteLine(vec < vecOther);
            Console.WriteLine(vec >= vecOther);
            Console.WriteLine(vec <= vecOther);
            Console.WriteLine(vec);



        }
    }
}
