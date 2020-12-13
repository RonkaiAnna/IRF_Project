using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Beadandó
{
    
    class Nyertes
    {
        adatbazisEntities1 context = new adatbazisEntities1();
        public Nyertes(Jelentkezok j)
        {

        }
        public string Név { get; set; }
        public string Email_cím { get; set; }
    }
}
