
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SettingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProgressTaxRateController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ProgressTaxRateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProgressTaxRateById(int id)
        {
            var obj = await _serviceManager.progressTaxRateService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProgressTaxRates()
        {
            var accounts = await _serviceManager.progressTaxRateService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProgressTaxRate([FromBody] ProgressTaxRateDTO progressTaxRate)
        {
            if (progressTaxRate is null)
                return BadRequest("progressTaxRate is null");

            var createdObj = await _serviceManager.progressTaxRateService.Create(progressTaxRate);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProgressTaxRate([FromBody] ProgressTaxRateDTO progressTaxRate)
        {
            if (progressTaxRate is null) return BadRequest("progressTaxRate is null");
            var updatedObject = await _serviceManager.progressTaxRateService.Update(progressTaxRate);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgressTaxRate(int id)
        {
            var deletedObject = await _serviceManager.progressTaxRateService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                