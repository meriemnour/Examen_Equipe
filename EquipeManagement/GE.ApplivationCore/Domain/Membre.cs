using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Membre
    {
        public int identifiant { get; set; }

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }

        public ICollection<Contrat> contrats { get; set; }
        public override string ToString()
        {
            return "nom:  "+nom+"  prenom;  "+prenom+"  datenaissance:  "+dateNaissance;
        }


        public virtual void membertype()
        {
            Console.WriteLine("i'm a member");
        }
    }
}
