using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    class Računalo
    {
        public string Naziv { get; set; }
        public string KapacitetMemorije { get; set; }
        public string Procesor { get; set; }
        public string OS { get; set; }
        public string Disk { get; set; }
        public string Napajanje { get; set; }
        public string MatičnaPloča { get; set; }
        public int Cijena { get; set; }

        public int BrojInstanci = 0;

        public Računalo()
        {

        }

        public Računalo(string naziv, string kapacitetMemorije, string procesor, string os, string disk, string napajanje, string matičnaPloča, int cijena)
        {
            Naziv = naziv;
            KapacitetMemorije = kapacitetMemorije;
            Procesor = procesor;
            OS = os;
            Disk = disk;
            Napajanje = napajanje;
            MatičnaPloča = matičnaPloča;
            Cijena = cijena;

            BrojInstanci++;
        }

        public void IspišiDetalje()
        {
            Console.WriteLine($"Naziv: {Naziv} \nKapacitet memorije: {KapacitetMemorije} \nProcesor: {Procesor} \nOS: {OS} \nDisk: {Disk} \nNapajanje: {Napajanje} \nMatična ploča: {MatičnaPloča} \nCijena: {Cijena}");
        }

        public void OdrediKategorijuRačunala()
        {
            Console.WriteLine();
            Console.WriteLine("Kategorija računala:");
            if (Cijena <= 5000)
            {
                Console.WriteLine("Radi se o stolnom računalu.");
            }

            else if (Cijena > 5000 && Cijena <= 7000)
            {
                Console.WriteLine("Radi se o osobnom računalu.");
            }

            else
            {
                Console.WriteLine("Radi se o gaming računalu.");
            }
        }
    }
}
