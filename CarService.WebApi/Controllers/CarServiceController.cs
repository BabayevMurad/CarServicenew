using CarService.DataAccess.Abstract;
using CarService.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarServiceController : ControllerBase
    {

        private readonly ICarService _carService;

        public CarServiceController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet("RandomCar")]
        public async Task<Car> GetRandomCar(int userid)
        {
            var car = await _carService.CarGenerator(userid);

            return car;
        }

        [HttpGet("RandomIssue")]
        public async Task<Issue> GetRandomIssue()
        {
            var issue = await _carService.CarIssueGenerator();
            return issue;
        }

        [HttpGet("AddDatabase")]
        public async Task AddDatabseIssue()
        {
            await _carService.AddIssueToSql();
        }

        [HttpGet("AddDatabaseCar")]
        public async Task AddDatabseCar()
        {
            await _carService.AddcarToSql();
        }

        [HttpGet("CarsInService")]
        public async Task<List<Car>> GetCarsInService()
        {
            var cars = await _carService.CarsInService();

            return cars;
        }

        // POST api/<CarServiceController>
        [HttpPost("CarToService")]
        public Task<Car> CarToService(CarRepair car)
        {
            return _carService.CarGoService(car);
        }

        // DELETE api/<CarServiceController>/5
        [HttpDelete("RemoveCarFromService/{id}")]
        public Task RemoveCarFromService(int id)
        {
            return _carService.RemoveCarFromSevice(id);
        }
    }
}
