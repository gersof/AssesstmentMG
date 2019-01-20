using MasGlobal.Assessment.Entities.Employees;
using MasGlobal.Assessment.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Assessment.Entities
{
   public class MonthlyContract : Employee, IContracts
    {
        public MonthlyContract(EmployeeResponse item) : base(item)
        {
            anualSalary = monthlySalary * 12;
        }
    }
}
