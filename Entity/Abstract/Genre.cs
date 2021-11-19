using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Abstract
{
  public  class Genre:ITable
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public List<Book>Books { get; set; }
    }
}
