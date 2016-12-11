using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___Projekt_programowanie_obiektowe
{
    abstract class Wrog
    {
        public abstract void ZadajeObrazenia(int obrazenia);
        public abstract void ZostawiaZloto(int zloto);
        public abstract void DeajeExpy(int doswiadczenie);
        public abstract void Wysilek(int wysilek);
    }
}
