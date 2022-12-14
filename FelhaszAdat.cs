using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhasznalo_keppel
{
    internal class FelhaszAdat
    {

        int id;
        string nev;
        DateTime szuldat;
        string profilkep;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime Szuldat { get => szuldat; set => szuldat = value; }
        public string Profilkep { get => profilkep; set => profilkep = value; }

        public FelhaszAdat(int id, string nev, DateTime szuldat, string profilkep)
        {
            Id = id;
            Nev = nev;
            Szuldat = szuldat;
            Profilkep = profilkep;
        }

    }
}
