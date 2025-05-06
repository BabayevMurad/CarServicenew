namespace CarService.DataAccess.Abstract
{
    public interface IUserService
    {
        public void AddUserMoney(int userId, decimal money);
        public void UserPay(int userId, decimal money);
    }
}
