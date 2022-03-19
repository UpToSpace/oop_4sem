using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.Decorator
{
    class Decorator : Discipline
    {
        public Decorator(Discipline discipline) : base("hello " + discipline.Name, 2, "economics", discipline.Lections, discipline.Labs, "1, 3", discipline.Control, "2", "f i o", "20e", "knigga", "afftor", 2021)
        {
            
        }
    }
}
