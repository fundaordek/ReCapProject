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
            _cars = new List<Car>() {
            new Car{CarId=1, BrandId=1, ColorId=2, ModelYear=2005, DailyPrice=100, Description="GÜNLÜK TEMİZ ARABA"},
            new Car{CarId=2, BrandId=2, ColorId=4, ModelYear=2019, DailyPrice=250, Description="GÜNLÜK KİRALIK ARABA"},
            new Car{CarId=3, BrandId=3, ColorId=5, ModelYear=2003, DailyPrice=500, Description="AYLIK KİRALIK ARABA"},
            new Car{CarId=4, BrandId=1, ColorId=9, ModelYear=2020, DailyPrice=1000, Description="SAHİBİNDEN TEMİZ ARABA"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
         Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

