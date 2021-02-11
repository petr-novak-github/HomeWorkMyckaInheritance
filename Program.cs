using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DU3_inheritance
{

    public class Auto
    {
    }

    public class Mycka
    {
        public Auto a;
        public double Umyj (Auto a)
        {
            return 100;
        }

        public double Navoskovat(Auto a) {
            return 200;
        }

        public virtual double KompletniProgram(Auto a) {
            double umyjj = Umyj(a);
            double navoskujj = Navoskovat(a);
            return  (umyjj + navoskujj) - ((umyjj + navoskujj) * 0.2);
        }
    }

    class RucniMycka:Mycka
    {
        public double VycistiInterier(Auto a) {

            return 500;
        }

        public override double KompletniProgram(Auto a)
        {

            double myckaKP = base.KompletniProgram(a);
            double vycistiInt = VycistiInterier(a);
            double slevaInt = vycistiInt - vycistiInt * 0.2;

            //double umyjj = umyj(a);
            //double navoskujj = navoskovat(a);

            return myckaKP + slevaInt;

        }

    }

    class MyckaSudrzbou:RucniMycka
    {
        public double provedUdrzbuSpodku(Auto a) {
            return 300;
        }

        public override double KompletniProgram(Auto a)
        {
            double slevaUdrzbaSpodek =provedUdrzbuSpodku(a) - provedUdrzbuSpodku(a)*0.2;
            double rucniMyckaKompletniPrg = base.KompletniProgram(a);
            return rucniMyckaKompletniPrg + slevaUdrzbaSpodek;
        }
    }

    public class Demo
    {
       public static void Main(string[] args)
        {
            Auto a1 = new Auto();
            double umyti;
            //  umyti = Umyj(1); tohle nejde musim prvni vytvorit objetk mycky
            
            Mycka m1 = new Mycka();
            umyti = m1.Umyj(a1);
            Console.WriteLine($"Umyti stoji: {umyti}");
            double navoskovani;
            navoskovani = m1.Navoskovat(a1);
            Console.WriteLine($"Navoskovani stoji: {navoskovani}");
            double kompletMycka;
            kompletMycka = m1.KompletniProgram(a1);
            Console.WriteLine($"Kompletni program (umyti a navoskovani - sleva 20%) {kompletMycka}");

            RucniMycka m2 = new RucniMycka();
            double vycistitInterier;
            vycistitInterier = m2.VycistiInterier(a1);
            Console.WriteLine($"Vycisteni interieru na rucni mycce stoji: {vycistitInterier}");
            double kompletUmytNavoskovatInterier;
            kompletUmytNavoskovatInterier = m2.KompletniProgram(a1);
            Console.WriteLine($"Umyti, navoskovani, vycisteni interieru (sleva 20%) stoji: {kompletUmytNavoskovatInterier}");

            MyckaSudrzbou m3 = new MyckaSudrzbou();
            double udrzbaSpodku;
            udrzbaSpodku = m3.provedUdrzbuSpodku(a1);
            Console.WriteLine($"Provedeni udrzby spodku stoji: {udrzbaSpodku}");
            double kompletUmytNavoskovatInterierSpodek;
            kompletUmytNavoskovatInterierSpodek = m3.KompletniProgram(a1);
            Console.WriteLine($"Super komplet, navoskovat, umyt, iterier vycistit a provest udrzbu spodku stoji (20procent dolu ze zakladnich cen): {kompletUmytNavoskovatInterierSpodek}");

            Console.ReadLine();
       }

        
    }
}
