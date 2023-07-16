using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AutoMotors
{
    public class Makina
    {
        public string Marka;
        public string Modeli;
        public int Viti;
        public string Ngjyra;
        public double Fuqia;
        public double Kapaciteti;
        public double KapacitetiTotal;
        public string Karburant;
        public double CmimiEuro;
        public double Harxhimi;


        public Makina(string marka, string modeli, string ngjyra, int viti, double fuqia, double kapaciteti, double kapacitetiTotal, string karburant, double harxhimi, double cmimiEuro) 
        {
            Marka = marka;
            Modeli = modeli;
            Ngjyra = ngjyra;
            Viti = viti;
            Fuqia = fuqia;
            Kapaciteti = kapaciteti;
            KapacitetiTotal = kapacitetiTotal;
            Karburant = karburant;
            Harxhimi = harxhimi;
            CmimiEuro = cmimiEuro;
        }

        public void ShfaqOpsionet()
        {
            Console.WriteLine("1. Bej Xhiro     2. Laj Makinen      3. Parko        4. Furnizo          0. Dil");
        }
        public void Specifikimi(Makina makina)
        {
            Console.WriteLine($"Ju zgjodhet {makina.Marka} {makina.Modeli} . Parametrat e makines jane keto:");
            Console.WriteLine($"Viti i Prodhimit: {makina.Viti}");
            Console.WriteLine($"Lloji i Karburantit: {makina.Karburant}");
            Console.WriteLine($"Motorri: {makina.Fuqia}");
        }

        public void Xhiro(Makina makina)

        {
            Console.WriteLine("Ti po ben nje xhiro!");
            Random rnd = new Random();
            int km = rnd.Next(1, 200);


            double l = km * makina.Harxhimi;
            if (makina.Kapaciteti > l)
            {
                makina.Kapaciteti -= l;

                double cmimi = Cmimi (makina.Karburant) * l;


                Console.WriteLine($"Ke bere {km} kilometra dhe jane kosumuar {Math.Round(l, 2)} litra nafte!");
                Console.WriteLine($"Per kete udhetim jane shpenzuar {Math.Round(cmimi, 2)} LEK");
                Console.WriteLine($"Kane mbetur {Math.Round(makina.Kapaciteti, 2)} litra");
            }


            else
            {
                Console.WriteLine("Furnizo");
            }
        }
        public void Parko()
        {
            Console.WriteLine(" Ti parkove makinen!");
        }
        public void Laje()
        {
            Console.WriteLine(" Ti e fute ne lavazh per te lare makinen!");
        }
        public void Furnizo(Makina makina)
        {
            Console.WriteLine("Sa lek do ta furnizoni mjetin mjetin tuaj?");
            double lek = Convert.ToInt32(Console.ReadLine());

            double l = lek / Cmimi(makina.Karburant);

            if (makina.Kapaciteti < makina.KapacitetiTotal)
            {
                makina.Kapaciteti += l;
                if (makina.Kapaciteti > makina.KapacitetiTotal)
                {
                    double teprica = makina.Kapaciteti - makina.KapacitetiTotal;
                    double kusuri = teprica * Cmimi(makina.Karburant);
                    makina.Kapaciteti = makina.KapacitetiTotal;

                    double km = makina.Kapaciteti / makina.Harxhimi;
                    double Furnizimi = (lek - kusuri) / Cmimi(makina.Karburant);


                    Console.WriteLine($"U shtuan {Math.Round(Furnizimi, 2)} litra nafte!");
                    Console.WriteLine($"kusuri: {Math.Round(kusuri, 2)} Lek!");
                    Console.WriteLine($"{Math.Round(makina.Kapaciteti, 2)} litra te mbetura!");
                    Console.WriteLine($"{Math.Round(km)} kilometra te mbetura!");
                }
                else
                {
                    double km = makina.Kapaciteti / makina.Harxhimi;


                    Console.WriteLine($"U shtuan {Math.Round(l, 2)} litra nafte!");
                    Console.WriteLine($"{Math.Round(makina.Kapaciteti, 2)} litra te mbetura!");
                    Console.WriteLine($"{Math.Round(km)} kilometra te mbetura!");

                }
            }
            else
            {
                Console.WriteLine("Makina eshte e furnizuar");
            }
            Console.WriteLine(" Ti furnizove me karburant makinen!");
        }
        private int Cmimi (string lloji)
        {
            int cmimi = lloji == "Nafte" ? 176 : 178;
            return cmimi;
        }
    }
}
