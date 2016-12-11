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
        public int numerAvatara;
        //          Misje        Start  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15
        public int[] statusMisji = { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //          Poziom                    1   2   3    4     5    6    7    8     9     10
        public readonly int[] expNaPoziom = { 75, 120, 185, 260, 410, 600, 920, 1430, 2000, 3000 };
        public int doswiadczenie = 0;
        public int poziom = 1;
        public int poziomZdrowia=100;
        public int maxPoziomZdrowia=100;
        public int wytrzymalosc = 100;
        public int maxPoziomWytrzymalosc = 100;
        public int zloto=0;

        public Bohater(string name, bool gender, int avatar)
        {
            this.name = name;
            this.gender = gender;
            this.numerAvatara = avatar;
        }
    }
}
