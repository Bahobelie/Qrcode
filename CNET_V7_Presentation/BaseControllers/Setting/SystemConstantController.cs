
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
    public class SystemConstantController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SystemConstantController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSystemConstantById(int id)
        {
            var obj = await _serviceManager.systemConstantService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSystemConstants()
        {
            var accounts = await _serviceManager.systemConstantService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSystemConstant([FromBody] SystemConstantDTO systemConstant)
        {
            if (systemConstant is null)
                return BadRequest("systemConstant is null");

            var createdObj = await _serviceManager.systemConstantService.Create(systemConstant);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSystemConstant([FromBody] SystemConstantDTO systemConstant)
        {
            if (systemConstant is null) return BadRequest("systemConstant is null");
            var updatedObject = await _serviceManager.systemConstantService.Update(systemConstant);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSystemConstant(int id)
        {
            var deletedObject = await _serviceManager.systemConstantService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                