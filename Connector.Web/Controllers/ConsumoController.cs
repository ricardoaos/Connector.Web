using Connector.Application.Services.Interfaces;
using Connector.Dto.Consumo;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tnf.AspNetCore.Mvc.Response;
using Tnf.Dto;

namespace Connector.Web.Controllers
{
    [Route("api/consumo")]
    [TnfAuthorize("Connector.Consumo")]
    public class ConsumoController : TnfController
    {
        private readonly IConsumoAppService _appService;
        private const string _name = "Consumo";

        public ConsumoController(IConsumoAppService appService)
        {
            _appService = appService;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <param name="requestDto">Request params</param>
        /// <returns>List of products</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IListDto<ConsumoDto>), 200)]
        [ProducesResponseType(typeof(ErrorResponse), 400)]
        public async Task<IActionResult> GetAll([FromQuery] ConsumoRequestAllDto requestDto)
        {
            var response = await _appService.GetAllConsumoAsync(requestDto);

            return CreateResponseOnGetAll(response, _name);
        }
    }
}
