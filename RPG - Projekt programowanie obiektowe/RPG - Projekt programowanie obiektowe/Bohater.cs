using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___Projekt_programowanie_obiektowe
{
    class Bohater
    {
        public string name;
        public bool gender;
        public System.Drawing.Image avatar;
        //          Poziom                    1   2   3   4    5    6    7    8    9     10
        public readonly int[] expNaPoziom = { 10, 25, 60, 120, 200, 320, 540, 920, 1200, 2000 };
        public int doswiadczenie = 0;
        public int poziom = 1;
        public int poziomZdrowia=100;
        public int maxPoziomZdrowia=100;
        public int wytrzymalosc = 100;
        public int maxPoziomWytrzymalosc = 100;
        public int zloto=0;

        public Bohater(string name, bool gender, System.Drawing.Image avatar)
        {
            this.name = name;
            this.gender = gender;
            this.avatar = avatar;
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
