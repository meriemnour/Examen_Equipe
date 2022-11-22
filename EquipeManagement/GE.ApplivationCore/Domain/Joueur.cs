using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Joueur:Membre
    {
        public string Poste { get; set; }
        public override void membertype()
        {
            base.membertype();
            Console.WriteLine("i'm a player");
        }
    }
}
