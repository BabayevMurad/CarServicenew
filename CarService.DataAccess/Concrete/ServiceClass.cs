using CarService.DataAccess.Abstract;
using CarService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Concrete
{
    public class ServiceClass : IService
    {
        public Task CarRepairAndAddtoStock(int carId)
        {
            throw new NotImplementedException();
        }

        public Task GetCarIssue(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<Car> GetCarForRepair()
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetRepairPrice(Issue issue)
        {
            throw new NotImplementedException();
        }
    }
}
