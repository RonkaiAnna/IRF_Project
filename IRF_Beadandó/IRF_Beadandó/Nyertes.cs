using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Beadandó
{
    
    class Nyertes
    {
        adatbazisEntities context = new adatbazisEntities();
        public Nyertes(Jelenetkezok j)
        {

        }
        public string Név { get; set; }
        public string Telefonszám { get; set; }
    }
}
