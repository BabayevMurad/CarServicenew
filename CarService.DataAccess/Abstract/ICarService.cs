using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.DataAccess.Abstract
{
    public interface ICarService
    {
        void CarGenerator();
        void CarIssueGenerator();
        void CarGoService();
        void CarsInService();

    }
}
