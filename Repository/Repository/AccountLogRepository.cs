using EHWR.Data.EHWRGenericRepository;
using EHWR.Domain.BusinessRules;
using EHWR.Domain.DTO.Account;
using EHWR.Domain.Response;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AccountLogRepository : GenericRepository, IAccountRepositoryLog
    {
        public AccountLogRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public async Task<SpResponse> UserLog(AccountLogModel accountLogModel)
        {
            return await CommandAsync<SpResponse>("UserLog", accountLogModel);
        }

        public async Task<SpResponse> UserLogOut(AccountLogOutModel accountLogOutModel)
        {
            return await CommandAsync<SpResponse>("UserLogOut", accountLogOutModel);
        }
    }
}
