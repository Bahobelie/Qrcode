
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
    public class ValueFactorSetupController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ValueFactorSetupController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueFactorSetupById(int id)
        {
            var obj = await _serviceManager.valueFactorSetupService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllValueFactorSetups()
        {
            var accounts = await _serviceManager.valueFactorSetupService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateValueFactorSetup([FromBody] ValueFactorSetupDTO valueFactorSetup)
        {
            if (valueFactorSetup is null)
                return BadRequest("valueFactorSetup is null");

            var createdObj = await _serviceManager.valueFactorSetupService.Create(valueFactorSetup);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateValueFactorSetup([FromBody] ValueFactorSetupDTO valueFactorSetup)
        {
            if (valueFactorSetup is null) return BadRequest("valueFactorSetup is null");
            var updatedObject = await _serviceManager.valueFactorSetupService.Update(valueFactorSetup);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteValueFactorSetup(int id)
        {
            var deletedObject = await _serviceManager.valueFactorSetupService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                