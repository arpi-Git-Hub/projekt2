using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt2
{
    internal class Alkatresz
    {
        string tipus;
        string nev;
        string parameter;
        int ar;

        public Alkatresz() {}
        public Alkatresz(string tipus, string nev, string parameter, int ar)
        {
            this.tipus = tipus;
            this.nev = nev;
            this.parameter = parameter;
            this.ar = ar;
        }

        public string Tipus { get => tipus; }
        public string Nev { get => nev; }

        public string Parameter { get => parameter; }
        public int Ar { get => ar; }

        public void Akcio(int sz)
        {
            ar = ar - (ar / 100 * sz);
        } 
        public void Param(string p)
        {
            parameter = p;
        }
    }
}
