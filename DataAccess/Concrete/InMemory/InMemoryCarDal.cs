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
                new Car{CarId = 1,BrandId =1, ModelYear = 2011, DailyPrice = 110000, Description = "Hatchback"},
                new Car{CarId = 2,BrandId = 1, ModelYear = 2013, DailyPrice = 90000, Description = "Hatchback"},
                new Car{CarId = 3,BrandId = 2, ModelYear = 2019, DailyPrice = 225000, Description = "Sedan"},
                new Car{CarId = 4,BrandId = 2, ModelYear = 2021, DailyPrice = 425000, Description = "SUV"},
                new Car{CarId = 5,BrandId = 3, ModelYear = 2016, DailyPrice = 575000, Description = "Super Car"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            // LINQ
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

