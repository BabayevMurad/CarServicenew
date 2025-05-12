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

        [HttpGet("randomcar")]
        public Car GetRandomCar(int userid, string url)
        {
            var car = _carService.CarGenerator(userid, url);

            return car;
        }

        [HttpGet("randomissue")]
        public Issue GetRandomIssue()
        {
            var issue = _carService.CarIssueGenerator();

            return issue;
        }

        [HttpGet("carsinservice")]
        public async Task<List<Car>> GetCarsInService()
        {
            var cars = await _carService.CarsInService();

            return cars;
        }

        // POST api/<CarServiceController>
        [HttpPost("CarToService")]
        public Task<Car> CarToService(Car car)
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
