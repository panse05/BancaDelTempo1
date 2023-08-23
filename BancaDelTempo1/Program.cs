using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancaDelTempo1
{
    public class Prestazione
    {
        public string Descrizione { get; set; }
        public string ErogataDa { get; set; }
        public string RicevutaDa { get; set; }
        public int Ore { get; set; }
        //public DateTime Data { get; set; }
    }
    //Questo codice definisce una classe chiamata `Prestazione` con diverse proprietà che rappresentano i dettagli di una prestazione di servizio all'interno del contesto di una Banca del Tempo. 

    public class ZonaTerritorio
    {
        public string Nome { get; set; }

    }
    //Questo codice definisce una classe chiamata `ZonaTerritorio` con una singola proprietà che rappresenta il nome di una zona geografica o territorio all'interno del contesto di una Banca del Tempo. 

    public class BancaDelTempo
    {
        private List<Prestazione> prestazioni;
        private List<ZonaTerritorio> zoneTerritorio;

        public BancaDelTempo()
        {
            prestazioni = new List<Prestazione>();
            zoneTerritorio = new List<ZonaTerritorio>();
        }

        public void AggiungiPrestazione(Prestazione prestazione)
        {
            prestazioni.Add(prestazione);
        }

        public List<Prestazione> OttieniPrestazioni()
        {
            return prestazioni;
        }

        public void AggiungiZonaTerritorio(ZonaTerritorio zona)
        {
            zoneTerritorio.Add(zona);
        }

        public List<ZonaTerritorio> OttieniZoneTerritorio()
        {
            return zoneTerritorio;
        }
    }
    //Questa classe gestisce una lista di prestazioni di servizio e una lista di zone territoriali all'interno del sistema della banca del tempo.


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BENVENUTO NELLA BANCA DEL TEMPO");
            
            BancaDelTempo banca = new BancaDelTempo();

            banca.AggiungiZonaTerritorio(new ZonaTerritorio { Nome = "Bergamo" });
            banca.AggiungiZonaTerritorio(new ZonaTerritorio { Nome = "Brescia" });

            Prestazione prestazione1 = new Prestazione
            {
                Descrizione = "Piccola riparazione in casa",
                ErogataDa = "Mario",
                RicevutaDa = "Luigi",
                Ore = 2,
                //Data = DateTime.Now
            };

            Prestazione prestazione2 = new Prestazione
            {
                Descrizione = "Preparazione di una torta",
                ErogataDa = "Filippo",
                RicevutaDa = "Andrea",
                Ore = 1,
                //Data = DateTime.Now
            };

            banca.AggiungiPrestazione(prestazione1);
            banca.AggiungiPrestazione(prestazione2);


            Console.WriteLine("Ecco l'elenco delle prestazioni effettuate:");
            foreach (var prest in banca.OttieniPrestazioni())
            {
                Console.WriteLine($"Descrizione: {prest.Descrizione}, Erogata da: {prest.ErogataDa}, Ricevuta da: {prest.RicevutaDa}, Ore: { prest.Ore}");
            }

            /* Data: { prest.Data} */

            Console.WriteLine("\nZone del territorio:");
            foreach (var zona in banca.OttieniZoneTerritorio())
            {
                Console.WriteLine($"Nome zona: {zona.Nome}");
            }
        }
    }
}