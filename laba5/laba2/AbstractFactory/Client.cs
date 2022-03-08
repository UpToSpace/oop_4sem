using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2.AbstractFactory
{
    public class Client
    {
        private AbstractLector lector;
        private AbstractLiterature literature;
        public Client(AbstractFactory factory)
        {
            lector = factory.CreateLector();
            literature = factory.CreateLiterature();
        }
    }
}
