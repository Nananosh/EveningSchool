using System.Threading.Tasks;

namespace EveningSchool.Business.Interfaces
{
    public interface ISeedDatabaseService
    {
        public Task CreateStartAdmin();
        public Task CreateStartRole();
        public Task CreateRegisterCode();
    }
}