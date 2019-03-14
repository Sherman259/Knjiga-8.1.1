using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiga_8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite naziv proizvoda");
            Proizvod proizvod = new Proizvod(Console.ReadLine);

            Console.Write("Unesite cijenu proizvoda:");
            prozvod.Cijena = double.Parse(Console.ReadLine());
            Console.Write("Unesite marzu proizvoda:");
            proizvod.marza = double.Parse(Console.ReadLine());
            Console.Write("Unesite porez na proizvoda:");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena za proizvoda {0} je {1}.", proizvod.Naziv,proizvod.MPC());

           Console.ReadKey();











        }
    }

    internal class Proizvod
    {
        //Polja
        public string Naziv = "ime";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;

        // Metode
        public Proizvod(string naziv);
     {
        Naziv = naziv;
     }
    public double MPC()
    {
        return Cijena + Marza + Porez;
    }

       
    
}
