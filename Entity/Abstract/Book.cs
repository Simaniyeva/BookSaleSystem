using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
   public  class Book:ITable
    {
        public  int BookId { get; set; }
        public string BookName { get; set; }
        public decimal Price { get; set; }
        public string About { get; set; }
        public int Count { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
    }
}
