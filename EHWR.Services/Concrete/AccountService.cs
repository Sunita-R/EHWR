using EHWR.Domain.BusinessRules;
using EHWR.Domain.DTO.Account;
using EHWR.Domain.Response;
using EHWR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Concrete
{
    public class AccountService : IAccountLogService
    {
        private readonly IAccountRepositoryLog _accountRepositoryLog;

        public AccountService(IAccountRepositoryLog accountRepositoryLog)
        {
            _accountRepositoryLog = accountRepositoryLog;
        }

        public async Task<SpResponse> UserLog(AccountLogModel accountLogModel)
        {
            return await _accountRepositoryLog.UserLog(accountLogModel);
        }

        public async Task<SpResponse> UserLogOut(AccountLogOutModel accountLogOutModel)
        {
            return await _accountRepositoryLog.UserLogOut(accountLogOutModel);
        }
    }
}
