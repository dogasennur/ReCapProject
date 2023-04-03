using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        //global değişken
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car> { };
            new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYears = 1999, DailyPrice = 200, Description = "opel" };
            new Car { CarId = 2, BrandId = 1, ColorId = 5, ModelYears = 1996, DailyPrice = 100, Description = "opel" };
            new Car { CarId = 3, BrandId = 2, ColorId = 3, ModelYears = 2010, DailyPrice = 300, Description = "golf" };
            new Car { CarId = 4, BrandId = 3, ColorId = 2, ModelYears = 2011, DailyPrice = 350, Description = "volvo" };
            new Car { CarId = 5, BrandId = 4, ColorId = 4, ModelYears = 2020, DailyPrice = 500, Description = "BMW" };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
            
            
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetByCarId(int Id)
        {
           return _car.Where(c => c.CarId == Id).ToList();            
        }

        public void Update(Car car)
        {
            Car carToUpdate = carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.Description = car.Description;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;

            
        }
    }
}
