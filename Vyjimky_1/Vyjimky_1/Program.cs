using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//pouziva input output

namespace Vyjimky_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //uzivatel zada polomer kruhu
            //program vypocita a zobrazi obsah kruhu
            //program zapise zadany prumer a vypocitany obsah
            try//hlida
            {
                Console.WriteLine("Zadejte polomer kruhu");
                double polomer = Convert.ToDouble(Console.ReadLine());
                double obsah = Math.PI * Math.Pow(polomer,2);
                using (StreamWriter sw = new StreamWriter("Obsah.txt", true))//zacina txt a pise do nej
                {
                    sw.WriteLine(polomer);
                    sw.WriteLine(obsah);
                    sw.WriteLine("_________________________");

                }
            }
            catch (Exception exChyba)//chyta
            {

                Console.WriteLine(exChyba.Message);//zprava chyby
            }
            finally
            {
                Console.WriteLine("Vysledek je napsan v txt v debug, pokud nevypadla ");

            }










            Console.ReadLine();
        }
    }
}
