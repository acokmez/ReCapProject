using Business.Concrete;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryCarDal());

            UserManager userManager = new UserManager(new EfUserDal());
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            #region UserCRUD
            /* User addUser = new User()
            {
                FirstName = "Ahmet",
                LastName = "Çökmez",
                Email = "aç@gmail.com",
                Password = "A123"
            };

            userManager.Add(addUser);


            User updateUser = new User()
            {
                Id = 1,
                FirstName = "Melek",
                LastName = "Ünsal",
                Email = "ms@gmail.com",
                Password = "M123m"
            };

            userManager.Update(updateUser);

            User deleteUser = new User()
            {
                Id = 1,
                FirstName = "Melek",
                LastName = "Ünsal",
                Email = "ms@gmail.com",
                Password = "M123m"
            };

            userManager.Delete(deleteUser);

            foreach (var users in userManager.GetAll().Data)
            {
                Console.WriteLine(users.Id);
                Console.WriteLine(users.FirstName);
            }*/
            #endregion

            #region CustomerCRUD
            /*Customer addCustomer = new Customer()
            {
                UserId = 2,
                CompanyName = "Torku"
            };
            customerManager.Add(addCustomer);

            Customer updateCustomer = new Customer()
            {
                Id = 2,
                UserId = 2,
                CompanyName = "Kalyon İnşaat"
            };
            customerManager.Update(updateCustomer);

            Customer deleteCustomer = new Customer()
            {
                Id=3,
                UserId = 2,
                CompanyName = "Kalyon İnşaat"
            };
            customerManager.Delete(deleteCustomer);

            foreach (var customers in customerManager.GetAll().Data)
            {
                Console.WriteLine(customers.Id);
                Console.WriteLine(customers.UserId);
                Console.WriteLine(customers.CompanyName);
            }*/
            #endregion

            #region RentalCRUD
            Rental addRental = new Rental()
            {
                CarId = 5,
                CustomerId = 1,
                RentDate = "27/01/2021",
                ReturnDate = "27/02/2021"
            };
            rentalManager.Add(addRental);

            /*Rental updateRental = new Rental()
            {
                Id = 2,
                CarId = 6,
                CustomerId = 2,
                RentDate = "12/01/2021",
                ReturnDate = "18/01/2021"
            };
            rentalManager.Update(updateRental);*/

            /*Rental addRental1 = new Rental()
            {
                Id = 3,
                CarId = 7,
                CustomerId = 2,
                RentDate = "05/02/2021",
                ReturnDate = "08/02/2021"
            };*/
            //rentalManager.Delete(addRental);

            foreach (var rentals in rentalManager.GetAll().Data)
            {
                Console.WriteLine("Id: {0}", rentals.Id);
                Console.WriteLine("CarId: {0}", rentals.CarId);
                Console.WriteLine("CustomerId: {0}", rentals.CustomerId);
                Console.WriteLine("RentDate: {0}", rentals.RentDate);
                Console.WriteLine("ReturnDate: {0}", rentals.ReturnDate);
            }
            #endregion
            //CarTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.ColorName + "/" + car.CarName);
            }
        }

        
    }
}
