using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Equipe
    {
        public int EquipeId { get; set; }
        public string EquipeName { get; set; }
        public string AdresseLocal { get; set; }
        public string logo { get; set; }

        public ICollection<Trophee> Trophees { get; set; }

        public Contrat contrat { get; set; }

        public override string ToString()
        {
            return "equipe name:  "+EquipeName+"  adresse local :  "+AdresseLocal+"  logo:  "+logo;
        }
    }
}
