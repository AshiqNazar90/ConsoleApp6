using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public decimal Price { get; set; }


        public virtual int AutherId { get; set; }
        public virtual Author Author { get; set; }
    }
}
