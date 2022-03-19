using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.Memento
{
    class History
    {
        public Stack<Mori> FormHistory { get; private set; }
        public History()
        {
            FormHistory = new Stack<Mori>();
        }
    }
}
