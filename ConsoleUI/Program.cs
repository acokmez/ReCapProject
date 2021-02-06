using Bussiness.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka ID : " + car.BrandId + " Model : " + car.ModelYear + " Fiyat : " + car.DailyPrice + " Açıklama : " + car.Description);
            }

            Console.WriteLine("\nMarka ID : 2 için Listeleme");
            foreach (var car in carManager.GetByBrandId(2))
            {
                Console.WriteLine("Marka ID : " + car.BrandId + " Model : " + car.ModelYear + " Fiyat : " + car.DailyPrice + " Açıklama : " + car.Description);
            }
        }
    }
}
