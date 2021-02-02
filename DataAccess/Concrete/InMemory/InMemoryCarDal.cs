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
                new Car{CarId=1,BrandId=1,ColorId=2,DailyPrice=280,ModelYear=2012,Description="Konforlu 2012 model araba"},
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=400,ModelYear=2016,Description="Konforlu 2016 model araba"},
                new Car{CarId=3,BrandId=2,ColorId=1,DailyPrice=360,ModelYear=2015,Description="Konforlu 2015 model araba"},
                new Car{CarId=4,BrandId=3,ColorId=1,DailyPrice=150,ModelYear=2010,Description="Konforlu 2010 model araba"},
                new Car{CarId=5,BrandId=2,ColorId=2,DailyPrice=380,ModelYear=2017,Description="Konforlu 2017 model araba"},
                new Car{CarId=6,BrandId=1,ColorId=3,DailyPrice=500,ModelYear=2020,Description="Konforlu 2020 model araba"},
            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetByBrand(int brandId)
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
