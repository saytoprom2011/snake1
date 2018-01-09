using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            // Отрисовка рамки

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            /*HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine lineV = new VerticalLine(3, 12, 13, '%');
            lineV.DrowV();*/

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }

            // Простое движение змейки
            /*snake.Move();

            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();*/

            Console.ReadLine();
        }

    }
}
 