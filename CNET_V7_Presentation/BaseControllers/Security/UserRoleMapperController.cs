
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
    public class UserRoleMapperController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public UserRoleMapperController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRoleMapperById(int id)
        {
            var obj = await _serviceManager.userRoleMapperService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserRoleMappers()
        {
            var accounts = await _serviceManager.userRoleMapperService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUserRoleMapper([FromBody] UserRoleMapperDTO userRoleMapper)
        {
            if (userRoleMapper is null)
                return BadRequest("userRoleMapper is null");

            var createdObj = await _serviceManager.userRoleMapperService.Create(userRoleMapper);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateUserRoleMapper([FromBody] UserRoleMapperDTO userRoleMapper)
        {
            if (userRoleMapper is null) return BadRequest("userRoleMapper is null");
            var updatedObject = await _serviceManager.userRoleMapperService.Update(userRoleMapper);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserRoleMapper(int id)
        {
            var deletedObject = await _serviceManager.userRoleMapperService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                