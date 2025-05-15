using CarService.Entities;

namespace CarService.DataAccess.Abstract
{
    public interface ICarService
    {
        Task<Car> CarGenerator(int userId);
        Task<Issue> CarIssueGenerator();
        Task<Car> CarGoService(CarRepair car);
        Task<List<Car>> CarsInService();
        Task RemoveCarFromSevice(int id);
        Task AddIssueToSql();
        Task AddcarToSql();

    }
}
