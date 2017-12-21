using System;
using SQLite;

namespace ICT13580101EndB.Models
{
    public class Product
    {   
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Type { get; set; }
        public String Yehor { get; set; }
        [MaxLength(100)]
        public String Genalation { get; set; }
        public int Year { get; set; }
        public int Mile { get; set; }
        public String Color { get; set; }
        public Boolean Deler { get; set; }
        public String Detail { get; set; }
        public decimal Price { get; set; }
        public String Provice { get; set; }
        public String Phone { get; set; }
    }
}
