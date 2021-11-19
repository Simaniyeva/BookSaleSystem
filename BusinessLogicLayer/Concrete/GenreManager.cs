using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class GenreManager : IGenreService
    {
        private readonly IGenreDAL  _genreDAL;
        public GenreManager(IGenreDAL genreDAL)
        {
            this._genreDAL = genreDAL;
        }
        public void Add(Genre entity)
        {
            _genreDAL.Add(entity);
        }

        public void Delete(Genre entity)
        {
            _genreDAL.Delete(entity);
        }

        public List<Genre> Get()
        {
            return _genreDAL.Get();
        }

        public Genre GetById(int id)
        {
            return _genreDAL.GetById(id);
        }

        public void Update(Genre entity)
        {
            _genreDAL.Update(entity);
        }
    }
}
