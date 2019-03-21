using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Licha_App18
{
    class Program
    {
        static void Main(string[] args)
        {
            //vygenerujte náhodné liché číslo a zobrazte ho


            Random rnd = new Random();
            int nahdone = rnd.Next(1, 999);
            #region Varianta modulo
            //otestujeme, zda je sude tak pricteme 1/odecist 1
            //MODULO je zbytek po delení, značí se %
            //12 % 3 --> 0
            //16 % 7 --> 2
            //22 % 5 --> 2
            //8 % 2 -->0
            //17 % 2 --> 1
            if (nahdone % 2 == 0) //je cislo sude? zbytek po deleni je 0
            {
                nahdone++;//pricteme 1
                //nahdone--;//odecteme 1

            }
            Console.WriteLine(nahdone); 
            #endregion

            #region Varianta do,while
            //cyklus s podmínkou na konci
            //probíha dokut pada sude cislo
            do
            {
                nahdone = rnd.Next(1, 999);
            } while (nahdone % 2 == 0);

            Console.WriteLine(nahdone);
            
            #endregion

            int[] lichaCisla = new int[499];
            lichaCisla[0] = 1;
            for (int i = 1; i < lichaCisla.Length; i++)
            {

                lichaCisla[i] = lichaCisla[i-1] + 2;

            }



            for (int i = 0; i < lichaCisla.Length; i++)
            {
                Console.WriteLine(lichaCisla[i]);
            }
          











            Console.ReadLine();
        }
    }
}
