using DataAccessLayer.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.Repositories
{
    public class EFGenreRepository:EFGenericRepository<Genre>,IGenreDAL
    {
    }
}
