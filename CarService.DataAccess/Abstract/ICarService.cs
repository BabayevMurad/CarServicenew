using CarService.Entities;

namespace CarService.DataAccess.Abstract
{
    public interface ICarService
    {
        Car CarGenerator(int userId, string url);
        Issue CarIssueGenerator();
        Task<Car> CarGoService(Car car);
        Task<List<Car>> CarsInService();
        Task RemoveCarFromSevice(int id);

    }
}
