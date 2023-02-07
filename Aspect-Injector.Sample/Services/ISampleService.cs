using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspect_Injector.Sample.Repositories;

namespace Aspect_Injector.Sample.Services
{
    public interface ISampleService
    {
        Task<IEnumerable<EpkAccAccount>> GetAccounts();
    }
}