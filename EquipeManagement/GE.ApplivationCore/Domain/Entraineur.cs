using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Entraineur:Membre
    {
        public int Grades { get; set; }
        public override void membertype()
        {
            base.membertype();
            Console.WriteLine("i'm a trainer");
        }
    }
}
