using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();   
        }

        //Select * from Category where CategoryId = 3; gibi bir sorgu gibi çalışır.
        //Her c için c nin categoryId si benim verdiğim categoryId ile aynı mı ? Diye bakar varsa sonuç getirir.
        public Category GetById(int CategoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == CategoryId);
        }
    }
}
