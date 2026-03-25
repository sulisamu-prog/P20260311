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

        public Tanulo(int id, string nev, string agazat, string fact)
        {
            this.id = id;
            this.nev = nev;
            this.agazat = agazat;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Agazat { get => agazat; set => agazat = value; }
    }
}
