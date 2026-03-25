using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P20260311_2
{
    class Tanulo
    {
        int id;
        string nev;
        string agazat;
        DateTime szuldate;
        string lakcim;
        Boolean nem;

        public Tanulo(int id, string nev, string agazat, DateTime szuldate, string lakcim, bool nem)
        {
            this.id = id;
            this.nev = nev;
            this.agazat = agazat;
            this.szuldate = szuldate;
            this.lakcim = lakcim;
            this.nem = nem;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Agazat { get => agazat; set => agazat = value; }
        public DateTime Szuldate { get => szuldate; set => szuldate = value; }
        public string Lakcim { get => lakcim; set => lakcim = value; }
        public bool Nem { get => nem; set => nem = value; }

        public int eletkor(int szDate)
        {
            int ekor = 0;
            DateTime dateTime = DateTime.Now;
            ekor = dateTime.Year - szDate;
            return ekor;
        }
    }
}
