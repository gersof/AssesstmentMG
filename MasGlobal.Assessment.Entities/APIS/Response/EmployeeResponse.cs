using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Assessment.Entities.APIS.Response
{
   public class EmployeeResponse
    {
        public int id { get; set; }

        public string name { get; set; }

        public string contractTypeName { get; set; }

        public int roleId { get; set; }

        public string roleName { get; set; }

        public string roleDescription { get; set; }

        public long anualSalary { get; set; }

    }
}
