using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Entities
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int GenreID { get; set; } //maybe an interface
        public decimal Score { get; set; }
        public int RatingID { get; set; }



    }
}
