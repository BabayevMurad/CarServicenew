using CarService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Abstract
{
    public interface ICarService
    {
        Car CarGenerator(int userId, string url);
        Issue CarIssueGenerator();
        Task<Car> CarGoService(Car car);
        Task<List<Car>> CarsInService();

    }
}
