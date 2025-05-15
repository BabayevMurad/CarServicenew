using CarService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Abstract
{
    public interface IService
    {
        Task<Car> GetCarForRepair();
        Task GetCarIssue(int carId);
        Task CarRepairAndAddtoStock(int carId);
        Task<decimal> GetRepairPrice(Issue issue);        
    }
}
