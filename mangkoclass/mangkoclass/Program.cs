using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Numerics;

namespace mangkoclass
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 5;
            int[,] m;
            int column = 20;
            int row = 10;
            m = new int[column, row];
            Random r = new Random();
            while (true)
            {
                char n;
                n = Console.ReadKey(true).KeyChar;
                if (n == 'w')
                {
                    y = y + 1;
                }
                if (n == 's')
                {
                    y = y - 1;
                }
                if (n == 'a')
                {
                    x = x - 1;
                }
                if (n == 'd')
                {
                    x = x + 1;
                }
                if (n == 'q')
                {
                    break;
                }
                Console.Clear();
                for (int j = 0; j < row; j++)
                {
                    for (int i = 0; i < column; i++)
                    {
                        if (n == 'f')
                        {
                            m[i, j] = r.Next(0, 2);
                            x = 5;
                            y = 5;
                        }
                        if (x == i && y == row - 1 - j)
                        {
                            Console.Write("o");
                        }
                        if (m[i, j] == 0)
                        {
                            Console.Write("-");
                        }
                        if (m[i, j] == 1)
                        {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
