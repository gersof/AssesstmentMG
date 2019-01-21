using System.Threading.Tasks;

namespace MasGlobal.Assessment.DataAccess.Interfaces
{
    public interface IEmployeesRepository
    {
        Task<T> GetEntityAsync<T>(string path);
    }
}
