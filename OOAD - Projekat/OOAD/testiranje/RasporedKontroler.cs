﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SafeHouse;

namespace SafeHouse
{
    public class RasporedKontroler
    {

        List<rasporedi> zauzetiTermini;

        public List<rasporedi> ZauzetiTermini
        {
            get { return zauzetiTermini; }
            set { zauzetiTermini = value; }
        }
        //List<int> kodiraniTermini;
        
        mydbEntities DB = new mydbEntities();
        public RasporedKontroler() { }
        public RasporedKontroler(Osoba o)
        {
            
            if (o is Korisnik)
            {
                o.ID1 = (from i in DB.korisnici where i.Ime == o.Ime_osobe && i.Prezime == o.Prezime_osobe select i.ID).Single();
                zauzetiTermini = (from z in DB.rasporedi where z.ID_K == o.ID1 select z).ToList();
            }
            else
            {
                o.ID1 = (from i in DB.radnici where i.Ime == o.Ime_osobe && i.Prezime == o.Prezime_osobe select i.ID).Single();
                zauzetiTermini = (from z in DB.rasporedi where z.ID_R == o.ID1 select z).ToList();
            }
        }

        List<int> dajDostupneTermine(int idk, int idr)
        {
            List<rasporedi> termini = new List<rasporedi>();
            List<int> dostupniTermini = new List<int>();
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j <= 4; j++)
                    dostupniTermini.Add(i * 10 + j);
            }


            termini = (from r in DB.rasporedi where r.ID_K == idk || r.ID_R==idr select r).ToList();
            foreach (rasporedi r in termini)
            {
                int dan, sat;
                if (r.Dan == "Ponedjeljak") dan = 0;
                else if (r.Dan == "Utorak") dan = 1;
                else if (r.Dan == "Srijeda") dan = 2;
                else if (r.Dan == "Cetvrtak") dan = 3;
                else dan = 4;

                if (r.Vrijeme == "09") sat = 0;
                else if (r.Vrijeme == "11") sat = 1;
                else if (r.Vrijeme == "13") sat = 2;
                else if (r.Vrijeme == "15") sat = 3;
                else sat = 4;
                int vr = dan*10 + sat;
                dostupniTermini.Remove(vr);   
            }
            return dostupniTermini;          

        }

        rasporedi dodijeliTermin(int n, int idk, int idr)
        {
            String Dan;
            String Vrijeme;
            int pomocna = n;
            if (pomocna % 10 == 0) Vrijeme = "09";
            else if (pomocna % 10 == 1) Vrijeme = "11";
            else if (pomocna % 10 == 2) Vrijeme = "13";
            else if (pomocna % 10 == 3) Vrijeme = "15";
            else Vrijeme = "17";
            if (pomocna / 10 == 0) Dan = "Ponedjeljak";
            else if (pomocna / 10 == 1) Dan = "Utorak";
            else if (pomocna / 10 == 2) Dan = "Srijeda";
            else if (pomocna / 10 == 3) Dan = "Cetvrtak";
            else Dan = "Petak";
            rasporedi r = new rasporedi();
            r.ID_K = idk;
            r.ID_R = idr;
            r.Dan = Dan;
            r.Vrijeme = Vrijeme; 
            return r;
        }
        
        public void popuniRaspored()
        {
            List<rasporedi> nedodijeljeniTermini = (from r in DB.rasporedi where r.Dan == null select r).ToList();
            
            foreach(rasporedi o in nedodijeljeniTermini)
            {
                List<int> dostupni = dajDostupneTermine(o.ID_K, o.ID_R);
                rasporedi r = dodijeliTermin(dostupni[0], o.ID_K, o.ID_R);
               
                var termin = (from rs in DB.rasporedi where rs.ID_K == o.ID_K && rs.ID_R == o.ID_R select rs).First();
                termin.Vrijeme = r.Vrijeme;
                termin.Dan = r.Dan;
                
                DB.SaveChanges();
            }

            
        }
        

    }
}
