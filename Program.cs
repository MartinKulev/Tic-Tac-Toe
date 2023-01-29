using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstRow  = "   |   |  ";
            string secondRow = "   |   |  ";
            string thirdRow  = "   |   |  ";
            Console.WriteLine(firstRow);
            Console.WriteLine(secondRow);
            Console.WriteLine(thirdRow);
            string currentChar = string.Empty;
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if(i % 2 == 0)
                {
                    currentChar = "X";

                }
                else if(i % 2 == 1)
                {
                    currentChar = "0";
                }
                    if (x == 1)
                    {
                        firstRow = firstRow.Insert(2, currentChar);
                        firstRow = firstRow.Remove(0, 1);
                    }
                    else if (x == 2)
                    {
                        firstRow = firstRow.Insert(6, currentChar);
                        firstRow = firstRow.Remove(5, 1);
                    }
                    else if (x == 3)
                    {
                        firstRow = firstRow.Insert(9, currentChar);

                    }
                    else if (x == 4)
                    {
                        secondRow = secondRow.Insert(2, currentChar);
                        secondRow = secondRow.Remove(0, 1);
                    }
                    else if (x == 5)
                    {
                        secondRow = secondRow.Insert(6, currentChar);
                        secondRow = secondRow.Remove(5 , 1);
                    }
                    else if (x == 6)
                    {
                        
                        secondRow = secondRow.Insert(9, currentChar);
                        
                    }
                    else if (x == 7)
                    {
                        
                        thirdRow = thirdRow.Insert(2, currentChar);
                        thirdRow = thirdRow.Remove(0, 1);
                    }
                    else if (x == 8)
                    {
                        thirdRow = thirdRow.Insert(6, currentChar);
                        thirdRow = thirdRow.Remove(5 , 1);
                    }
                    else if (x == 9)
                    {
                        thirdRow = thirdRow.Insert(9, currentChar);

                }
                Console.WriteLine(firstRow);
                Console.WriteLine(secondRow);
                Console.WriteLine(thirdRow);
                if(firstRow[1] == 'X' & firstRow[5] == 'X' & firstRow[9] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" X | X | X ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   |   |   ");
                    break;
                }
                else if(firstRow[1] == '0' & firstRow[5] == '0' & firstRow[9] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" 0 | 0 | 0 ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   |   |   ");
                    break;
                }
                if (secondRow[1] == 'X' & secondRow[5] == 'X' & secondRow[9] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" X | X | X ");
                    Console.WriteLine("   |   |   ");
                    break;
                }
                else if (secondRow[1] == '0' & secondRow[5] == '0' & secondRow[9] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" 0 | 0 | 0 ");
                    Console.WriteLine("   |   |   ");
                    break;
                }
                if (thirdRow[1] == 'X' & thirdRow[5] == 'X' & thirdRow[9] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" X | X | X ");
                    break;
                }
                else if (thirdRow[1] == '0' & thirdRow[6] == '0' & thirdRow[9] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine("   |   |   ");
                    Console.WriteLine(" 0 | 0 | 0 ");
                    break;
                }
                if(firstRow[1] == 'X' & secondRow[1] == 'X' & thirdRow[1] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" X |   |    ");
                    Console.WriteLine(" X |   |    ");
                    Console.WriteLine(" X |   |    ");
                    break;
                }
                else if(firstRow[1] == '0' & secondRow[1] == '0' & thirdRow[1] == '0')
                {
                    Console.WriteLine("----------");
                    Console.WriteLine(" 0 |   |   ");
                    Console.WriteLine(" 0 |   |   ");
                    Console.WriteLine(" 0 |   |   ");
                    break;
                }
                if (firstRow[5] == 'X' & secondRow[5] == 'X' & thirdRow[5] == 'X')
                {
                    Console.WriteLine("----------");
                    Console.WriteLine("   | X |  ");
                    Console.WriteLine("   | X |  ");
                    Console.WriteLine("   | X |  ");
                    break;
                }
                else if (firstRow[5] == '0' & secondRow[5] == '0' & thirdRow[5] == '0')
                {
                    Console.WriteLine("----------");
                    Console.WriteLine("   | 0 |  ");
                    Console.WriteLine("   | 0 |  ");
                    Console.WriteLine("   | 0 |  ");
                    break;
                }
                if (firstRow[9] == 'X' & secondRow[9] == 'X' & thirdRow[9] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   | X ");
                    Console.WriteLine("   |   | X ");
                    Console.WriteLine("   |   | X ");
                    break;
                }
                else if (firstRow[9] == '0' & secondRow[9] == '0' & thirdRow[9] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   | 0 ");
                    Console.WriteLine("   |   | 0 ");
                    Console.WriteLine("   |   | 0 ");
                    break;
                }
                if(firstRow[1] == 'X' & secondRow[5] == 'X' & thirdRow[9] == 'X')
                {
                    Console.WriteLine("---------- ");
                    Console.WriteLine(" X |   |   ");
                    Console.WriteLine("   | X |   ");
                    Console.WriteLine("   |   | X ");
                    break;
                }
                else if(firstRow[1] == '0' & secondRow[5] == '0' & thirdRow[9] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine(" 0 |   |   ");
                    Console.WriteLine("   | 0 |   ");
                    Console.WriteLine("   |   | 0 ");
                    break;
                }
                if (firstRow[9] == 'X' & secondRow[5] == 'X' & thirdRow[1] == 'X')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   | X ");
                    Console.WriteLine("   | X |   ");
                    Console.WriteLine(" X |   |   ");
                    break;
                }
                else if (firstRow[9] == '0' & secondRow[5] == '0' & thirdRow[1] == '0')
                {
                    Console.WriteLine("-----------");
                    Console.WriteLine("   |   | 0 ");
                    Console.WriteLine("   | 0 |   ");
                    Console.WriteLine(" 0 |   |   ");
                    break;
                }


                x = int.Parse(Console.ReadLine());

            }



        }
    }
}
