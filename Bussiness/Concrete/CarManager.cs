﻿using Bussiness.Abstact;
using DataAccess.Abstarct;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal) 
        {
            _carDal = carDal;
        
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();

            
        }
    }
}
