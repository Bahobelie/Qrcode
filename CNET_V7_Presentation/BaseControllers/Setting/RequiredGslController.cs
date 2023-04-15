
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
    public class RequiredGslController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public RequiredGslController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequiredGslById(int id)
        {
            var obj = await _serviceManager.requiredGslService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequiredGsls()
        {
            var accounts = await _serviceManager.requiredGslService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequiredGsl([FromBody] RequiredGslDTO requiredGsl)
        {
            if (requiredGsl is null)
                return BadRequest("requiredGsl is null");

            var createdObj = await _serviceManager.requiredGslService.Create(requiredGsl);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRequiredGsl([FromBody] RequiredGslDTO requiredGsl)
        {
            if (requiredGsl is null) return BadRequest("requiredGsl is null");
            var updatedObject = await _serviceManager.requiredGslService.Update(requiredGsl);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequiredGsl(int id)
        {
            var deletedObject = await _serviceManager.requiredGslService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                