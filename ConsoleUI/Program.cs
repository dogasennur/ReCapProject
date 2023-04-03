using Bussiness.Concrete;
using Bussiness.Abstact;
using DataAccess.Abstarct;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);

            }

            Console.ReadLine();
        }
    }
}
