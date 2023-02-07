using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aspect_Injector.Sample.Repositories;
using Aspect_Injector.Sample.Repositories.DBContext;
using Microsoft.EntityFrameworkCore;

namespace Aspect_Injector.Sample.Services
{
    public class SampleService : ISampleService
    {
        private readonly EPKDBContext _dbContext;

        public SampleService(EPKDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<EpkAccAccount>> GetAccounts()
        {
            var accAccounts = _dbContext.EpkAccAccounts.Where(x => x.EpkStatus == "A");
            var paymentLinks = _dbContext.EpkAccPaymentlinks.Where(x => x.Status == "A");

            var result = await
            (
                from account in accAccounts
                join paymentLink in paymentLinks
                    on account.EpkAccId equals paymentLink.EpkAccId
                select account
            ).ToListAsync();

            await _dbContext.EpkAccSubscribedServices.Where(x => x.EpkAccId == result.First().EpkAccId)
                            .ToListAsync();

            return result;
        }
    }
}