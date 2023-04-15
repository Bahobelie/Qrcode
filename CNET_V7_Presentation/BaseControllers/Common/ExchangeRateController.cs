
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.CommonSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ExchangeRateController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ExchangeRateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExchangeRateById(int id)
        {
            var obj = await _serviceManager.exchangeRateService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllExchangeRates()
        {
            var accounts = await _serviceManager.exchangeRateService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateExchangeRate([FromBody] ExchangeRateDTO exchangeRate)
        {
            if (exchangeRate is null)
                return BadRequest("exchangeRate is null");

            var createdObj = await _serviceManager.exchangeRateService.Create(exchangeRate);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateExchangeRate([FromBody] ExchangeRateDTO exchangeRate)
        {
            if (exchangeRate is null) return BadRequest("exchangeRate is null");
            var updatedObject = await _serviceManager.exchangeRateService.Update(exchangeRate);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExchangeRate(int id)
        {
            var deletedObject = await _serviceManager.exchangeRateService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                