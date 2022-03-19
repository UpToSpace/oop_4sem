using System;
using System.ComponentModel.DataAnnotations;
using laba2.AbstractFactory;
using laba2.Prototype;

namespace laba2
{
    [Serializable]
    public class Discipline : AbstractFactory.AbstractFactory, IDiscipline
    {
        public string str;
        [Required, Name]
        public string Name { get; set; }
        [Required]
        public int Course { get; set; }
        [Required]
        public string Speciality { get; set; }
        [Required]
        [Range(1, 100)]
        public int Lections { get; set; }
        [Required]
        [Range(0, 100)]
        public int Labs { get; set; }
        public string Semester1 { get; set; }
        public string Semester2 { get; set; }
        [Required]
        public string Control { get; set; }
        public Lector Lector { get; set; }
        public Literature Literature { get; set; }
        //public override string ToString()
        //{
        //    return $"Name: {Name}\n Course: {Course}\n Speciality: {Speciality}\n Number of lections: {Lections}\n " +
        //        $"Number of labs: {Labs}\n Semester1: {Semester1}\n Semester2: {Semester2}\n Control: {Control}\n\n Fio Lector: {Lector.Fio}\n " +
        //        $"Cafedra: {Lector.Cafedra}\n Class number: {Lector.ClassNum}\n\n LITERATURE\n name: {Literature.Name}\n author: {Literature.Author}\n year: {Literature.Year}";
        //}
        public Discipline(string name, int course, string speciality, int lections, int labs, string str, string control,
            string cafedra, string fio, string classNum, string litName, string author, int year)
        {
            Name = name;
            Course = course;
            Speciality = speciality;
            Lections = lections;
            Labs = labs;
            Control = control;
            this.str = str;
            Lector = new Lector();
            Lector.Cafedra = cafedra;
            Lector.ClassNum = classNum;
            Lector.Fio = fio;

            Literature = new Literature();
            Literature.Name = litName;
            Literature.Author = author;
            Literature.Year = year;
        }
        public Discipline() {
            this.Lector = new Lector();
            this.Literature = new Literature();
        }
        private string SetSemesters()
        {
            if (Semester1 == "True")
            {
                str = "1";
            }
            if (Semester2 == "True")
            {
                str = "2";
            }
            if (Semester1 == "True" && Semester2 == "True")
            {
                str = "1, 2";
            }
            return str;
        }
        public (string, int, string, int, int, string, string, string, string, string, string, string, int) ShowRow()
        {
            str = SetSemesters();
            return (Name, Course, Speciality, Lections, Labs, str, Control, Lector.Fio, Lector.Cafedra, Lector.ClassNum, Literature.Name, Literature.Author, Literature.Year);
        }

        public IDiscipline Clone() 
        {
            str = SetSemesters();
            return new Discipline(Name, Course, Speciality, Lections, Labs, str, Control, Lector.Cafedra, Lector.Fio, Lector.ClassNum, Literature.Name, Literature.Author, Literature.Year);
        }

        public override AbstractLiterature CreateLiterature()
        {
            return new Literature();
        }

        public override AbstractLector CreateLector()
        {
            return new Lector();
        }
    }
    [Serializable]
    public class Lector : AbstractLector
    {
        public string Cafedra { get; set; }
        public string Fio { get; set; }
        public string ClassNum { get; set; }
    }
    [Serializable]
    public class Literature : AbstractLiterature
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
