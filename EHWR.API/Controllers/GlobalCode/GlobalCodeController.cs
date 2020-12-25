using EHWR.Domain.DomainModel.GlobalCode;
using EHWR.Services.Interfaces.GlobalCode;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EHWR.Domain.DomainModel.GlobalCode.GlobalCodeModel;

namespace EHWR.API.Controllers.GlobalCode
{
    [ApiController]
    [Route("api/[controller]")]
    public class GlobalCodeController : ControllerBase
    {
        private readonly IGlobalCodeService _globalCodeService;

        public GlobalCodeController(IGlobalCodeService globalCodeService)
        {
            _globalCodeService = globalCodeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] GlobelSearchModel globelSearchModel)
        {
            IEnumerable<GlobalCodeModel> collection = await _globalCodeService.GlobalCodeListAnync(globelSearchModel);

            return Ok(collection);
        }

        [HttpGet("Category")]
        public async Task<IActionResult> GetCategoryAsync()
        {
            IEnumerable<GlobalCodeCategoriesModel> collection = await _globalCodeService.GlobalCodeCategoriesAsync();

            return Ok(collection);
        }
    }
}
