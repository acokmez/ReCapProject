using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;

        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _CarDal.Add(car);
                Console.WriteLine("Araba eklendi.");
            }
            else
            {
                Console.WriteLine("Araba günlük fiyatı 0'dan büyük olmalıdır. Kontrol ediniz.");
            }
        }

        public void Delete(Car car)
        {
            _CarDal.Delete(car);
            Console.WriteLine("Araba silindi.");
        }

        public List<Car> GetAll()
        {
            Console.WriteLine("Tüm arabalar listeleniyor.");
            return _CarDal.GetAll();
        }
        public List<Car> GetCarsByBrandId(int id)
        {
            return _CarDal.GetAll(x => x.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _CarDal.GetAll(x => x.ColorId == id);
        }


        public Car GetById(int id)
        {
            return _CarDal.Get(x => x.Id == id);
        }
        public void Update(Car car)
        {
            _CarDal.Update(car);
            Console.WriteLine("Araba güncellendi.");
        }
    }
}
