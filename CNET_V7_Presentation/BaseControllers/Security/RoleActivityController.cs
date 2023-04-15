
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SecuritySchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoleActivityController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public RoleActivityController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleActivityById(int id)
        {
            var obj = await _serviceManager.roleActivityService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoleActivitys()
        {
            var accounts = await _serviceManager.roleActivityService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleActivity([FromBody] RoleActivityDTO roleActivity)
        {
            if (roleActivity is null)
                return BadRequest("roleActivity is null");

            var createdObj = await _serviceManager.roleActivityService.Create(roleActivity);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateRoleActivity([FromBody] RoleActivityDTO roleActivity)
        {
            if (roleActivity is null) return BadRequest("roleActivity is null");
            var updatedObject = await _serviceManager.roleActivityService.Update(roleActivity);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleActivity(int id)
        {
            var deletedObject = await _serviceManager.roleActivityService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                