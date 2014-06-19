using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Music.Models
{
    public class Musics
    
        {
        public int ID { get; set; }
        public string Title { get; set; }
        [MyDate]
        public DateTime? ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public TimeSpan Duration { get; set; }
    
    }


    public class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime d = Convert.ToDateTime(value);
            return d <= DateTime.Now;
        }
    }
    
   
}



