using EHWR.Domain.DomainModel.Dashboard;
using EHWR.Services.Interfaces.Dashboard;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Controllers.Dashboard
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;
        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] DashboardSearch dashboardSearch)
        {
            IEnumerable<DashboardModel> collection = await _dashboardService.CollectionAsync(dashboardSearch);
            return Ok(collection);
        }

    }
}
