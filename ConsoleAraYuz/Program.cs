using Business.Entities;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleAraYuz
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.CarId);
            }
        }
    }
}
