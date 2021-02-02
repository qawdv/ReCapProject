using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> 
            {
                new Car {Id=1, BrandId=1, ColorId=3, ModelYear ="2010",DailyPrice =225000,Description="Gökyüzü mavisi BMW 3.20i Otomatik Vites Benzin"},
                new Car {Id=2, BrandId=4, ColorId=2, ModelYear ="2018",DailyPrice =189000,Description="Açık Kahve Kia Ceed 1.4 TDI Manuel Vites Dizel"},
                new Car {Id=3, BrandId=3, ColorId=4, ModelYear ="2021",DailyPrice =330000,Description="Siyah Peugeot 3008 Manuel Vites Dizel"},
                new Car {Id=4, BrandId=2, ColorId=5, ModelYear ="2004",DailyPrice =89000,Description="Beyaz Renoult Symbol 1.4 Dizel Manuel Vites"},
                new Car {Id=5, BrandId=5, ColorId=1, ModelYear ="2011",DailyPrice =145000,Description="Kırmızı Volkswagen Polo 1.6 TDI Dizel Manuel Vites"},
                               
            };
        }       

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id ==car.Id);

            _cars.Remove(carToDelete);
        }

       
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByld(int id)
        {
            return _cars.Where(c=>c.Id == id).ToList();
        }

        public void GetByld(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        void ICarDal.GetAll(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
