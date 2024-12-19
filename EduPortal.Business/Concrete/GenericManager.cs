using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EduPortal.Business.Abstract;
using EduPortal.DataAccess.Abstract;

namespace EduPortal.Business.Concrete
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public List<T> TGetAll()
        {
            return _repository.GetAll();
        }

        public int TCount()
        {
            return _repository.Count();
        }

        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> predicate)
        {
            return _repository.FilteredCount(predicate);
        }

        public T TGetByFilter(Expression<Func<T, bool>> predicate)
        {
            return (_repository.GetByFilter(predicate));
        }

        public T TGetbyId(int id)
        {
            return _repository.GetbyId(id);
        }

        public List<T> TGetFilteredList(Expression<Func<T, bool>> predicate)
        {
            return _repository.GetFilteredList(predicate);
        }

        public void TUpdate(T entity)
        {
            _repository.Update(entity);
        }
    }
}
