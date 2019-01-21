using MasGlobal.Assessment.Entities;
using MasGlobal.Assessment.Entities.Interfaces;

namespace MasGlobal.Assessment.Business
{
    public class ContractsComponent : ContractsFactory
    {
        private readonly IContracts repositoryEmployee;

        public ContractsComponent(IContracts repositoryEmployee)
        {
            this.repositoryEmployee = repositoryEmployee;
        }
        public ContractsComponent()
        {

        }



        public override IContracts GetContractType(Entities.Employees.EmployeeResponse employee)
        {
            switch (employee.contractTypeName)
            {
                case "HourlySalaryEmployee": return new HourlyContract(employee);
                default: return new MonthlyContract(employee);
            }
        }
    }
}
