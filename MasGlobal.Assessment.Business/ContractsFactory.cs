using MasGlobal.Assessment.Entities.Interfaces;

namespace MasGlobal.Assessment.Business
{
    public abstract class ContractsFactory
    {
        public abstract IContracts GetContractType(Entities.Employees.EmployeeResponse employee);
    }
}
