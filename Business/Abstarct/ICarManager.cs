using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstarct
{
    interface ICarManager
    {
        List<Car> GetAll();
    }
}
