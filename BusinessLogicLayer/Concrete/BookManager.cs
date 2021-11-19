using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDAL _bookDAL;
        public BookManager(IBookDAL bookDAL)
        {
            _bookDAL = bookDAL;
        }
        public void Add(Book entity)
        {
            _bookDAL.Add(entity);
        }

        public void Delete(Book entity)
        {

            _bookDAL.Delete(entity);

        }

        public List<Book> Get()
        {
            return _bookDAL.Get();

        }

        public Book GetById(int id)
        {
            return _bookDAL.GetById(id);

        }

        public void Update(Book entity)
        {
            _bookDAL.Update(entity);

        }
    }
}
