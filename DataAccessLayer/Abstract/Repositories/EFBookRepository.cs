using DataAccessLayer.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.Repositories
{
    public class EFBookRepository : EFGenericRepository<Book>, IBookDAL
    {
    }
}
