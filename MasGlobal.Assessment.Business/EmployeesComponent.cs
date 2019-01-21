using MasGlobal.Assessment.DataAccess.Interfaces;
using MasGlobal.Assessment.DataAccess.Repositories;
using MasGlobal.Assessment.Entities;
using MasGlobal.Assessment.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasGlobal.Assessment.Business
{
    public class EmployeesComponent
    {
        private readonly IMasGlobalEmployees repositoryEmployee;

        private string Path { get; set; } = "Employees/";

        public EmployeesComponent(IMasGlobalEmployees repositoryEmployee)
        {
            this.repositoryEmployee = repositoryEmployee;
        }

        public EmployeesComponent() :
            this(new MasGlobalEmployees())
        {

        }

        public async Task<IEnumerable<Employee>> GetAll(int? id)
        {
            var employeeResponse = await repositoryEmployee.GetEntityAsync<IEnumerable<Entities.Employees.EmployeeResponse>>(Path);

            employeeResponse = (id == null) ? employeeResponse : employeeResponse.Where(a => a.id == id).ToList();

            if (employeeResponse.Count() > 0)
            {
                List<Employee> response = new List<Employee>();

                foreach (var item in employeeResponse)
                {
                    ContractsFactory contract = new ContractsComponent();
                    IContracts type = contract.GetContractType(item);
                    Employee employee = (Employee)type;

                    response.Add(employee);
                }
                return response;
            }
            else
            {
                throw new Exception("Id does not exist");
            }
        }
    }

}
