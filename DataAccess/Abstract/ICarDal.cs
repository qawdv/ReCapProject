using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        void GetByld(Car car);
        void GetAll(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAll();
    }
}
