using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using Prism.Mvvm;

namespace laba6_7
{
    public class Picture
    {        
        public Picture()
        {
            //Pictures.Add( new Picture() { Rating = 2, Name = "hey", Author = "dali", Category = "j", Count = 1, Image = @"D:\University\4\oop\laba6_7\laba6_7\pictures\memory.png", Price = "3000" });
        }
        //[Required, RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Enter correct name")]
        public string Name { get; set; }
        //[Required, RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Enter correct author")]
        public string Author { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        [Required, Range(0, 10, ErrorMessage = "Enter correct rating")]
        public double Rating { get; set; }
       // [Required, RegularExpression(@"^[0-9\s]*$", ErrorMessage = "Enter correct price")]
        public string Price { get; set; }
       // [Required, RegularExpression(@"^[0-9\s]*$", ErrorMessage = "Enter correct count")]
        public int Count { get; set; }

    }
}
