using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<Car>()
            {
                new Car{Id = 1, BrandId=1, ColorId=1, DailyPrice=120, ModelYear=2017,Description="In sale for a week"},
                new Car{Id = 2, BrandId=2, ColorId=2, DailyPrice=150, ModelYear=2018,Description="In sale for 10 days"},
                new Car{Id = 3, BrandId=2, ColorId=3, DailyPrice=500, ModelYear=2019,Description="In sale for 6 weeks"},
                new Car{Id = 4, BrandId=3, ColorId=1, DailyPrice=100, ModelYear=2013,Description="In sale for a month"},
                new Car{Id = 5, BrandId=4, ColorId=4, DailyPrice=200, ModelYear=2016,Description="In sale for 3 weeks"},
                new Car{Id = 6, BrandId=4, ColorId=5, DailyPrice=120, ModelYear=2018,Description="In sale for 2 months"},
                new Car{Id = 7, BrandId=5, ColorId=3, DailyPrice=800, ModelYear=2020,Description="In sale for 2 days"}
            };
        }
        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            _Cars.Remove(_Cars.SingleOrDefault(c => c.Id == car.Id)); 

        }

        public void Update(Car car)
        {
            Car carToUpdate = _Cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public Car get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException(); // ??????????????????????????????????????????????????????????????????????????????????????????????
        }


        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _Cars; 
        }
    }
}
