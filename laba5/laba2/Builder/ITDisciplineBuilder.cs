using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    class ITDisciplineBuilder : DisciplineBuilder
    {
        public override void SetFields(string name, int course, string specciality, int lections, int labs, string semester1, string semester2, string control)
        {
            Discipline.Name = name;
            Discipline.Course = course;
            Discipline.Speciality = specciality;
            Discipline.Lections = lections;
            Discipline.Labs = labs;
            Discipline.Semester1 = semester1;
            Discipline.Semester2 = semester2;
            Discipline.Control = control;
        }

        public override void SetLector(string cafedra, string fio, string classNum)
        {
            Discipline.Lector = new Lector { Cafedra = cafedra, ClassNum = classNum, Fio = fio };
        }

        public override void SetLiterature(string name, string author, int year)
        {
            Discipline.Literature = new Literature { Author = author, Name = name, Year = year };
        }
    }
}
