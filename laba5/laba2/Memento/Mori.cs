using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.Memento
{
    public class Mori
    {
        public List<Discipline> disciplines { get; set; }
        public Mori(ref List<Discipline> disciplines)
        {
            this.disciplines = disciplines;
        }
    }
}
