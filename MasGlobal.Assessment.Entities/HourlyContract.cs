using MasGlobal.Assessment.Entities.Employees;
using MasGlobal.Assessment.Entities.Interfaces;

namespace MasGlobal.Assessment.Entities
{
    public class HourlyContract : Employee, IContracts
    {
        public HourlyContract(EmployeeResponse item) : base(item)
        {
            anualSalary = 120 * hourlySalary * 12;
        }
    }
}
