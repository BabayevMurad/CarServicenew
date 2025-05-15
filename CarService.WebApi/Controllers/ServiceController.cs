using CarService.DataAccess.Abstract;
using CarService.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IService _service;

        public ServiceController(IService service)
        {
            _service = service;
        }

        [HttpGet("GetCar")]
        public async Task<Car> GetCar()
        {
             return await _service.GetCarForRepair();
        }

        [HttpGet("RepairCar")]
        public async Task<decimal> RepairCar(int carId)
        {
            var issue = await _service.GetCarIssue(carId);

            var price = _service.GetRepairPrice(issue);

            await _service.CarRepairAndAddtoStock(carId);

            return price;
        }
    }
}
