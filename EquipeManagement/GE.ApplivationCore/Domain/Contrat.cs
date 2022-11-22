using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Contrat
    {
        public int DureeMois { get; set; }
        public double Salaire { get; set; }
        public DateTime DateContrat { get; set; }

        public Equipe equipe { get; set; }
        public Membre membre { get; set; }
        public override string ToString()
        {
            return "dureeMois:  "+DureeMois+"  salaire:  "+Salaire+ "  datecontrat:  "+DateContrat;
        }

    }
}
