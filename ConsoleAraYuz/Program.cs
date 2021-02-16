using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //BrandManagerTest();
            //ColorManagerTest();
            //CustomerManagerTest();
            //UserManagerTest();
            RentalManagerTest();



            void RentalManagerTest()
            {
                RentalManager rentalManager = new RentalManager(new EfRentalDal());
                var result = rentalManager.Add(new Rental
                {
                    CarId = 2,
                    CustomerId = 3,
                    RentalId = 6,
                    RentDate = new DateTime(2021, 2, 5, 11, 30, 00),
                    ReturnDate = null,


                });
                Console.WriteLine(result.Success);
                Console.WriteLine(result.Message);

            }

            void UserManagerTest()
            {
                UserManager userManager = new UserManager(new EfUserDal());
                var result = userManager.GetAll();
                if (result.Success)
                {
                    foreach (var user in result.Data)
                    {
                        Console.WriteLine(user.FirstName + "-" + user.LastName + "-" + user.Email);
                    }
                    Console.WriteLine(result.Message);
                }
            }

            void CustomerManagerTest()
            {
                CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
                var result = customerManager.GetAll();
                if (result.Success)
                {
                    foreach (var customer in result.Data)
                    {
                        Console.WriteLine(customer.CustomerId);
                        Console.WriteLine(customer.CompanyName);


                    }
                    Console.WriteLine(result.Message);
                }
            }

            void ColorManagerTest()
            {
                ColorManager color = new ColorManager(new EfColorDal());
                var result = color.GetAll();
                if (result.Success)
                {
                    foreach (var colors in result.Data)
                    {
                        Console.WriteLine(colors.ColorId);
                        Console.WriteLine(colors.ColorName);

                    }
                    Console.WriteLine(result.Message);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }


            void BrandManagerTest()
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal());
                var result = brandManager.GetAll();
                if (result.Success)
                {
                    foreach (var brand in result.Data)
                    {
                        Console.WriteLine(brand.BrandId);
                        Console.WriteLine(brand.BrandName);
                    }
                    Console.WriteLine(result.Message);

                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }

            void CarManagerTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                var result = carManager.GetAll();
                if (result.Success)
                {
                    foreach (var car in result.Data)
                    {
                        Console.WriteLine(car.Descriptions);
                        Console.WriteLine(car.ColorId);

                    }
                    Console.WriteLine(result.Message);

                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }

        }

    }
}