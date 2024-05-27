using System.Threading.Tasks;
using QLHSC07.Model.User;

namespace QLHSC07.ApiGateway.Service.Worker
{
    public interface IWorkerService
    {
        CurrentUserDto GetCurrentUser();
    }
}
