using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookSaleSystem.Models
{
    public class BookViewModel
    {
        public List<Book>Books { get; set; }
        public Book Book { get; set; }
        public List<Genre>Genres { get; set; }
        public Genre Genre { get; set; }
    }
}
