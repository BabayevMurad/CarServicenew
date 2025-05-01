using CarService.DataAccess.Abstract;
using CarService.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarService.DataAccess.Concrete
{
    public class CarServiceClass : ICarService
    {
        private readonly AppDataContext _appDataContext;

        public CarServiceClass(AppDataContext appDataContext)
        {
            _appDataContext = appDataContext;
        }

        public Car CarGenerator(int userId, string url)
        {
            string[] name = { "Toyota Corolla", "Toyota Land Cruiser 200", "Peyserin Kolonkali Priusu", "Mercedes Benz Brabus 6.5S", "Geylerin Teslasi" };
            Random random = new Random();

            string randomName = name[random.Next(name.Length)];
            int randomYear = random.Next(2020, 2025);

            var car = new Car
            {
                Name = randomName,
                Year = randomYear,
                UserId = userId,
                imageUrl = url
            };

            return car;
        }

        public async Task<Car> CarGoService(Car car)
        {
            var carReturn = await _appDataContext.Cars.AddAsync(car);

            return carReturn.Entity;
        }

        public Issue CarIssueGenerator()
        {
            List<Issue> list = new List<Issue>
            {
                new Issue { Level="Easy", Problem="Flat Tire", Description="The tire loses air pressure and needs replacement." },
                new Issue { Level="Easy", Problem="Oil Change", Description="The engine oil needs to be changed regularly." },
                new Issue { Level="Easy", Problem="Air Filter Replacement", Description="The air filter is dirty and needs replacement." },
                new Issue { Level="Easy", Problem="Battery Replacement", Description="The battery is dead and requires replacement." },
                new Issue { Level="Easy", Problem="Wiper Blade Change", Description="The wiper blades are worn out and need changing." },
                new Issue { Level="Medium", Problem="Brake Pad Replacement", Description="Brake pads are worn and need replacement." },
                new Issue { Level="Medium", Problem="Coolant Leak Repair", Description="Coolant system is leaking and requires repair." },
                new Issue { Level="Medium", Problem="Spark Plug Replacement", Description="Spark plugs are faulty and need changing." },
                new Issue { Level="Medium", Problem="Wheel Alignment", Description="Wheels need realignment to fix steering issues." },
                new Issue { Level="Medium", Problem="Headlight Replacement", Description="The headlights are broken or burnt out." },
                new Issue {Level="Difficult", Problem="Transmission Failure", Description= "Transmission system is failing completely." },
                new Issue {Level="Difficult", Problem="Engine Overheating", Description= "Engine overheats and may be seriously damaged." },
                new Issue {Level="Difficult", Problem="Timing Belt Failure", Description= "Timing belt has broken and engine synchronization is lost." },
                new Issue {Level="Difficult", Problem="Fuel Pump Failure", Description= "Fuel pump has failed, causing fuel delivery issues." },
                new Issue {Level="Difficult", Problem="Clutch System Failure", Description= "Clutch has completely failed and needs full replacement." },
            };

            Random random = new Random();

            var randomName = list[random.Next(list.ToArray().Length)];

            return randomName;
        }

        public async Task<List<Car>> CarsInService()
        {
            var cars = await _appDataContext.Cars.ToListAsync();

            return cars;
        }
    }
}
