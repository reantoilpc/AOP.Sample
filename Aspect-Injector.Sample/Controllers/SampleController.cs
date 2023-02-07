using System.Collections.Generic;
using System.Threading.Tasks;
using Aspect_Injector.Sample.Attributes;
using Aspect_Injector.Sample.Repositories;
using Aspect_Injector.Sample.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aspect_Injector.Sample.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;

        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        [LogCall("GetAccount")]
        [HttpGet]
        public async Task<IEnumerable<EpkAccAccount>> GetAccounts()
        {
            var accounts = await _sampleService.GetAccounts();
            return accounts;
        }
        
    }
}