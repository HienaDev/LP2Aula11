using System;
using System.Threading;
using System.Collections.Concurrent;
using Microsoft.VisualBasic;

namespace InputSystem
{
    public class Program
    {
        // Coleção thread-safe, usa internamente uma Queue (primeira tecla a
        // entrar é a primeira a sair)
        //--> Declarar coleção thread-safe aqui
        public static BlockingCollection<ConsoleKey> keyCollection;

        private static void Main()
        {

            

            Thread producer = new Thread(ReadKeys);
            Thread consumer = new Thread(ShowKeyOnScreen);

            //--> Inicializar coleção thread-safe aqui
            keyCollection = new BlockingCollection<ConsoleKey>();

            Console.WriteLine("Podes começar a carregar nas teclas");

            //--> Código para começar execução das threads aqui
            producer.Start();
            consumer.Start();

            //--> Código para esperar que as threads terminem aqui
            producer.Join();
            consumer.Join();

            Console.WriteLine("Obrigado!");
        }

        // Método produtor:
        // Lé as teclas do teclado e coloca-as na fila
        private static void ReadKeys()
        {
            ConsoleKey key;

            do
            {
                key = Console.ReadKey(true).Key;
                keyCollection.Add(key);

            } while (key != ConsoleKey.Escape);
        }

        // Método consumidor:
        // Obtém/retira as teclas da fila, e apresenta informação no ecrã
        private static void ShowKeyOnScreen()
        {

            ConsoleKey key;

            //--> Completa este código
            while ((key = keyCollection.Take()) != ConsoleKey.Escape)
            {
                
            
                if (key == ConsoleKey.W)
                {
                    Console.WriteLine("Cima");
                }

                if (key == ConsoleKey.A)
                {
                    Console.WriteLine("Esquerda");
                }

                if (key == ConsoleKey.S)
                {
                    Console.WriteLine("Baixo");
                }

                if (key == ConsoleKey.D)
                {
                    Console.WriteLine("Direita");
                }
            
                
            }
        }
    }
}