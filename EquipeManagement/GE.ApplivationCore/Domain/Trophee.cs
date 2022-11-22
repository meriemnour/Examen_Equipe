using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GE.ApplivationCore.Domain
{
    public class Trophee
    {
        public int TropheeId { get; set; }
        public string TypeTrophee { get; set; }
        public double Recompense { get; set; }
        public DateTime DateTrophee { get; set; }

        public Equipe equipe { get; set; }
        public override string ToString()
        {
            return "type trphee:  "+TypeTrophee+"  recompense:  "+Recompense+"  date trophee:  "+DateTrophee;
        }
    }
}
