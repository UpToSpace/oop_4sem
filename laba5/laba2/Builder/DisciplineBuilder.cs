using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public abstract class DisciplineBuilder
    {
        public Discipline Discipline { get; private set; }
        public void CreateDiscipline()
        {
            Discipline = new Discipline();
        }
        public abstract void SetLector(string cafedra, string fio, string classNum);
        public abstract void SetLiterature(string name, string author, int year);
        public abstract void SetFields(string name, int course, string specciality, int lections, int labs, string semester1, string semester2, string control);
    }
}
