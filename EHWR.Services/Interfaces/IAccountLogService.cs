using EHWR.Domain.DTO.Account;
using EHWR.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EHWR.Services.Interfaces
{
    public interface IAccountLogService
    {
        Task<SpResponse> UserLog(AccountLogModel accountLogModel);
        Task<SpResponse> UserLogOut(AccountLogOutModel accountLogOutModel);
    }
}
