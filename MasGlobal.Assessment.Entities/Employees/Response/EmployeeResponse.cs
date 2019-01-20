/// <summary>
/// 
/// </summary>
namespace MasGlobal.Assessment.Entities.Employees
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeResponse
    {
        public int id { get; set; }

        public string name { get; set; }

        public string contractTypeName { get; set; }

        public int roleId { get; set; }

        public string roleName { get; set; }

        public string roleDescription { get; set; }

        public long hourlySalary { get; set; }

        public long monthlySalary { get; set; }
    }
}
