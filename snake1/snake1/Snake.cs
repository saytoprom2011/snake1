﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }


        //Функция определяет положение головы змейки, вычисляет в какой точке окажеться в следующий момент
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    if (direction != Direction.RIGHT)
                        direction = Direction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    if (direction != Direction.LEFT)
                        direction = Direction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    if (direction != Direction.DOWN)
                        direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    if (direction != Direction.UP)
                        direction = Direction.DOWN;
                    break;
                default: break;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                food.Draw();
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
