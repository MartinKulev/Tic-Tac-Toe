using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe._2
{
    class Program
    {
        static void Main(string[] args)
        {           
            char symbol = ' ';
            int n = 0;
            List<char> firstRow = "│   │   │   │".ToList();
            List<char> secondRow = "│   │   │   │".ToList();
            List<char> thirdRow = "│   │   │   │".ToList();
            foreach (char c in firstRow)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in secondRow)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            foreach (char c in thirdRow)
            {
                Console.Write(c);
            }
            Console.WriteLine();
            for (int a = 0; a < 9; a++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                bool dontClear = false;
                try
                {
                    n = int.Parse(Console.ReadLine());

                }
                catch { ArgumentException er; }
                {

                }
                if (a % 2 == 0)
                {
                    symbol = 'X';
                }
                else
                {
                    symbol = 'O';
                }
                if (n == 1)
                {
                    if(firstRow[2] == 'X' || firstRow[2] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        firstRow[2] = symbol;
                    }                 
                }
                else if (n == 2)
                {
                    if (firstRow[6] == 'X' || firstRow[6] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        firstRow[6] = symbol;
                    }
                }
                else if (n == 3)
                {
                    if (firstRow[10] == 'X' || firstRow[10] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        firstRow[10] = symbol;
                    }
                }
                else if (n == 4)
                {
                    if (secondRow[2] == 'X' || secondRow[2] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        secondRow[2] = symbol;
                    }
                }
                else if (n == 5)
                {
                    if (secondRow[6] == 'X' || secondRow[6] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        secondRow[6] = symbol;
                    }
                }
                else if (n == 6)
                {
                    if (secondRow[10] == 'X' || secondRow[10] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        secondRow[10] = symbol;
                    }
                }
                else if (n == 7)
                {
                    if (thirdRow[2] == 'X' || thirdRow[2] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        thirdRow[2] = symbol;
                    }
                }
                else if (n == 8)
                {
                    if (thirdRow[6] == 'X' || thirdRow[6] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        thirdRow[6] = symbol;
                    }
                }
                else if (n == 9)
                {
                    if (thirdRow[10] == 'X' || thirdRow[10] == 'O')
                    {
                        a--;
                        dontClear = true;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You can't place it there, the box is already occupied. Type a number again: ");
                    }
                    else
                    {
                        thirdRow[10] = symbol;
                    }
                }
                else
                {
                    a--;
                    dontClear = true;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You can only type the numbers from 1 to 9");
                }
                if(dontClear == false)
                {
                    Console.Clear();
                }                
                foreach (char c in firstRow)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                foreach (char c in secondRow)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                foreach (char c in thirdRow)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
                if (firstRow[2] == symbol && firstRow[6] == symbol && firstRow[10] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│ {symbol} │ {symbol} │ {symbol} │");
                    Console.WriteLine("│   │   │   │");
                    Console.WriteLine("│   │   │   │");
                    break;
                }
                else if (secondRow[2] == symbol && secondRow[6] == symbol && secondRow[10] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine("│   │   │   │");
                    Console.WriteLine($"│ {symbol} │ {symbol} │ {symbol} │");
                    Console.WriteLine("│   │   │   │");
                    break;
                }
                else if (thirdRow[2] == symbol && thirdRow[6] == symbol && thirdRow[10] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine("│   │   │   │");
                    Console.WriteLine("│   │   │   │");
                    Console.WriteLine($"│ {symbol} │ {symbol} │ {symbol} │");
                    break;
                }
                else if (firstRow[2] == symbol && secondRow[2] == symbol && thirdRow[2] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│ {symbol} │   │   │");
                    Console.WriteLine($"│ {symbol} │   │   │");
                    Console.WriteLine($"│ {symbol} │   │   │");
                    break;
                }
                else if (firstRow[6] == symbol && secondRow[6] == symbol && thirdRow[6] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│   │ {symbol} │   │");
                    Console.WriteLine($"│   │ {symbol} │   │");
                    Console.WriteLine($"│   │ {symbol} │   │");
                    break;
                }
                else if (firstRow[10] == symbol && secondRow[10] == symbol && thirdRow[10] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│   │   │ {symbol} │");
                    Console.WriteLine($"│   │   │ {symbol} │");
                    Console.WriteLine($"│   │   │ {symbol} │");
                    break;
                }
                else if (firstRow[2] == symbol && secondRow[6] == symbol && thirdRow[10] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│ {symbol} │   │   │");
                    Console.WriteLine($"│   │ {symbol} │   │");
                    Console.WriteLine($"│   │   │ {symbol} │");
                    break;
                }
                else if (firstRow[10] == symbol && secondRow[6] == symbol && thirdRow[2] == symbol)
                {
                    Console.WriteLine();
                    Console.WriteLine("-------------");
                    Console.WriteLine($"│   │   │ {symbol} │");
                    Console.WriteLine($"│   │ {symbol} │   │");
                    Console.WriteLine($"│ {symbol} │   │   │");
                    break;
                }

            }
        }
    }
}
