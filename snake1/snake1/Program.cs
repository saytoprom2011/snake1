using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<char> myNameList = new List<char>();
            myNameList.Add('A');
            myNameList.Add('B');
            myNameList.Add('C');
            myNameList.Add('D');

            foreach (char i in myNameList)
            {
                Console.WriteLine(i);
            }

            List<char> charList = new List<char>();
            charList.Add('@');
            charList.Add('#');
            charList.Add('$');
            charList.Add('%');
            charList.Add('&');
            charList.Add('*');

            foreach (char c in charList)
            {
                Console.WriteLine(c);
            }


            Point p1 = new Point(1, 7, '*');
            Point p2 = new Point(4, 9, '#');
            Point p3 = new Point(8, 10, '&');
            Point p4 = new Point(6, 8, '%');
            Point p5 = new Point(4, 12, '$');
            Point p6 = new Point(6, 10, '@');

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);

            foreach (Point p in pList)
            {
                p.Draw();
            }

            Console.ReadLine();
        }

    }
}