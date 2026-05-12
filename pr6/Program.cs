namespace pr6;

using System;
using System.Threading;

class Program
{
    static volatile bool isRunning = true;
    static volatile bool isPaused = false;
    
    static int counter = 0;
    static readonly object lockObj = new object(); 

    static void Main()
    {
        Console.WriteLine("Програма запущена. Гарячі клавіші:");
        Console.WriteLine("P - Пауза | R - Скинути | C - Колір | Q - Вихід\n");

        Thread keyThread = new Thread(KeyHandler);
        keyThread.IsBackground = true;
        keyThread.Start();

        while (isRunning)
        {
            if (!isPaused)
            {
                lock (lockObj)
                {
                    counter++;
                    Console.WriteLine($"Counter: {counter}");
                }
            }
            
            Thread.Sleep(1000); 
        }
        
        Console.ResetColor();
        Console.WriteLine("Програму завершено.");
    }

    static void KeyHandler()
    {
        while (isRunning)
        {
            ConsoleKey key = Console.ReadKey(true).Key;

            switch (key)
            {
                case ConsoleKey.P:
                    isPaused = !isPaused;
                    break;
                
                case ConsoleKey.R:
                    lock (lockObj)
                    {
                        counter = 0;
                    }
                    break;
                
                case ConsoleKey.C:
                    if (Console.ForegroundColor == ConsoleColor.Green)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    break;
                
                case ConsoleKey.Q:
                    isRunning = false;
                    break;
            }
        }
    }
}