using System;
using System.ComponentModel.DataAnnotations;

namespace laba2
{
    [Serializable]
    public class Discipline
    {
        [Required, RegularExpression(@"^[a-zA-Z]*$", ErrorMessage = "only letters available")]
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
        public Lector lector { get; set; }
        public Literature literature { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}\n Course: {Course}\n Speciality: {Speciality}\n Number of lections: {Lections}\n " +
                $"Number of labs: {Labs}\n Semester1: {Semester1}\n Semester2: {Semester2}\n Control: {Control}\n\n Fio Lector: {lector.Fio}\n " +
                $"Cafedra: {lector.Cafedra}\n Class number: {lector.ClassNum}\n\n LITERATURE\n name: {literature.Name}\n author: {literature.Author}\n year: {literature.Year}";
        }
    }
    [Serializable]
    public class Lector
    {
        public string Cafedra { get; set; }
        public string Fio { get; set; }
        public string ClassNum { get; set; }
    }
    [Serializable]
    public class Literature
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
