using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___Projekt_programowanie_obiektowe
{
    class Bohater
    {
        //                                    1     2   3    4     5     6     7     8       9      10
        public readonly int[] expNaPoziom = { 100, 250, 600, 1200, 2000, 3200, 5400, 9200, 12000, 20000 };
        public int doswiadczenie = 0;
        public int poziom = 1;
        public int poziomZdrowia=100;
        public int maxPoziomZdrowia=100;
        public int zloto=0;
        
        public string name;
        public Bohater(string name)
        {
            this.name = name;
        }
        public void wczytajPostac(int wczytajDoswiadczenie, int wczytajPoziom)
        {
            doswiadczenie = wczytajDoswiadczenie;
            poziom = wczytajPoziom;
        }
        public void dodajDoswiadczenie(int a)
        {
            this.doswiadczenie += a;
        }
    }
}
