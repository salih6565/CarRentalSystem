using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryCarDal
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carS;
        public InMemoryCarDal()
        {
            _carS = new List<Car>()
            {
                new Car{Id=1,ColorId=1,ModelYear=2000,DailyPrice=35000,BrandId=1,Description="çıtır hasarlı araç"},
                new Car{Id=2,ColorId=2,ModelYear=2003,DailyPrice=85000,BrandId=2,Description="taksi çıkması"},
                new Car{Id=3,ColorId=2,ModelYear=2005,DailyPrice=45000,BrandId=3,Description="3000 km de araç"},
            };
        }

        public List<Car> GetAll()
        {
            return _carS;
        }
        public void Update(Car car)
        {
            Car CarToUpdate;
            CarToUpdate = _carS.SingleOrDefault(c => c.Id == car.Id);
            car.Id = CarToUpdate.Id;
            car.ColorId = CarToUpdate.ColorId;
            car.ModelYear = CarToUpdate.ModelYear;
            car.Description = CarToUpdate.Description;
            car.DailyPrice = CarToUpdate.DailyPrice;
            car.BrandId = CarToUpdate.BrandId;

        }
        public List<Car> GetById(int BrandId)
        {
            return _carS.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Add(Car car)
        {
            _carS.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = null;
            CarToDelete = _carS.SingleOrDefault(c => c.Id == car.Id);
            _carS.Remove(CarToDelete);
        }
    }
}
