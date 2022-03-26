using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvausPeli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arvausLista = new List<int>();                        //Luodaan int-arvoja saava lista
            Boolean loytyi = false;
            Random r = new Random();                                        //Random-toiminnallisuus
            int arvottuLuku = r.Next(1, 100);                               //Random-toiminnallisuus (arvotun luvun luonti ja sijoitus muuttujaan)
            int intLuku = 0;                                                //muuttujien alustus
            string kayttajanLuku = "0", uusiArvaus = "0";                   //muuttujien alustus


            Console.WriteLine("Tervetuloa pelaamaan luvun arvauspeliä!", Console.ForegroundColor = ConsoleColor.White, Console.BackgroundColor = ConsoleColor.Magenta);   //tervetulotoivotus
            Console.ResetColor();
            Console.Write("Arvaa mitä lukua ajattelen yhden ja sadan väliltä: ");     //pyydetään käyttäjää arvaamaan luku
            kayttajanLuku = Console.ReadLine();                             //luetaan käyttäjän antama luku ja sijoitetaan muuttujaan
            intLuku = int.Parse(kayttajanLuku);                             //muunnetaan käyttäjän luku int-muotoon
            
            while (kayttajanLuku != "" && loytyi == false)                  //suoritetaan mikäli käyttäjä ei anna tyhjää ja niin kauan kuin loytyi on totta
            {
                    if (intLuku < arvottuLuku)
                    {
                        arvausLista.Add(intLuku);                           //lisätään luku listalle
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Ajattelemani luku on suurempi kuin arvaamasi luku. Arvaa uudestaan: ");    //annetaan ohje
                        uusiArvaus = Console.ReadLine();
                        intLuku = int.Parse(uusiArvaus);                    //tallennetaan uusi arvaus listalle

                    }else if(intLuku > arvottuLuku)
                    {
                        arvausLista.Add(intLuku);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Ajattelemani luku on pienempi kuin arvaamasi luku. Arvaa uudestaan: ");
                        uusiArvaus = Console.ReadLine();
                        intLuku = int.Parse(uusiArvaus);    
                    }
                    else
                    {
                        loytyi = true;                                     //oikea luku löytyi
                        arvausLista.Add(intLuku);
                        
                        Console.WriteLine("Onneksi olkoon! Arvaamasi luku ({0}) oli oikein!",intLuku, Console.ForegroundColor = ConsoleColor.White, Console.BackgroundColor = ConsoleColor.Magenta);
                        Console.WriteLine("Arvasit yhteensä {0} kertaa.", arvausLista.Count, Console.ForegroundColor = ConsoleColor.Magenta, Console.BackgroundColor = ConsoleColor.White);
                            for (int i = 0; i < arvausLista.Count; i++)   //tulostetaan kaikki arvaukset
                            {
                               Console.WriteLine("Arvaus {0}: " + arvausLista[i], i+1);
                            }
                    }
            }
            Console.ResetColor();
            Console.WriteLine("Paina enter lopettaaksesi pelin.");        //ohjeistetaan miten peli lopetetaan
            Console.ReadLine();
        }
    }
}
