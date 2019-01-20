using MasGlobal.Assessment.Entities.Interfaces;
using System;

namespace MasGlobal.Assessment.Entities
{

    public class Employee : IContracts
    {
        public Employee()
        {
        }

        public Employee(Employees.EmployeeResponse item)
        {
            id = item.id;
            name = item.name;
            contractTypeName = item.contractTypeName;
            roleId = item.roleId;
            roleName = item.roleName;
            roleDescription = item.roleDescription;
            hourlySalary = item.hourlySalary;
            monthlySalary = item.monthlySalary;
        }

        public int id { get; set; }

        public string name { get; set; }

        public string contractTypeName { get; set; }

        public int roleId { get; set; }

        public string roleName { get; set; }

        public string roleDescription { get; set; }

        public long hourlySalary { get; set; }

        public long monthlySalary { get; set; }

        public long anualSalary { get; set; }
    }
}

