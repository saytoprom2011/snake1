﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine lineV = new VerticalLine(3, 12, 13, '%');
            lineV.DrowV();

            Console.ReadLine();
        }

    }
}