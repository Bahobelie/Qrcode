
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
    public class RequiredGsldetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public RequiredGsldetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRequiredGsldetailById(int id)
        {
            var obj = await _serviceManager.requiredGsldetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRequiredGsldetails()
        {
            var accounts = await _serviceManager.requiredGsldetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequiredGsldetail([FromBody] RequiredGsldetailDTO requiredGsldetail)
        {
            if (requiredGsldetail is null)
                return BadRequest("requiredGsldetail is null");

            var createdObj = await _serviceManager.requiredGsldetailService.Create(requiredGsldetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRequiredGsldetail([FromBody] RequiredGsldetailDTO requiredGsldetail)
        {
            if (requiredGsldetail is null) return BadRequest("requiredGsldetail is null");
            var updatedObject = await _serviceManager.requiredGsldetailService.Update(requiredGsldetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRequiredGsldetail(int id)
        {
            var deletedObject = await _serviceManager.requiredGsldetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                