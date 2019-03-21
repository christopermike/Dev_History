using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole2D_mapa
{
    class Program
    {
        static void Main(string[] args)
        {
            //vytvoríme dvourozměrné pole
            //row - řádek, collum- sloupec
            string[,] mapa = new string[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //naplnime prvek na pozici [i,j]
                    mapa[i, j] = "X";
                }
            }


            for (int i = 0; i < 10; i++)
            {
               
                for (int j = 0; j < 10; j++)
                {
                    //vypíšeme prvek na pozici i,j
                    Console.Write(mapa[i,j]);
                }
                Console.WriteLine("");
            }

            Random rnd = new Random();
            Console.WriteLine();
            int mina = rnd.Next(1,8);

            for (int i = 0; i < 10; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    //vypíšeme prvek na pozici i,j
                    if (i==j)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        
                    }
                    else if (i<j)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(mapa[i, j]+" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i==0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if(i==9)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (j == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (j == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                    else if (i == mina || j==mina)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write(mapa[i,j]);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();





        }
    }
}
