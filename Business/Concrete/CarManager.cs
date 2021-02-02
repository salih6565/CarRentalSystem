using Business.Abstarct;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarManager
    {
        ICarDal carManager;
        public CarManager(ICarDal carDal)
        {
            carManager = carDal;
        }
        public List<Car> GetAll()
        {
            return carManager.GetAll();
        }
    }
}
