
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ConsigneeSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ConsigneeUserController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ConsigneeUserController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsigneeUserById(int id)
        {
            var obj = await _serviceManager.consigneeUserService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllConsigneeUsers()
        {
            var accounts = await _serviceManager.consigneeUserService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateConsigneeUser([FromBody] ConsigneeUserDTO consigneeUser)
        {
            if (consigneeUser is null)
                return BadRequest("consigneeUser is null");

            var createdObj = await _serviceManager.consigneeUserService.Create(consigneeUser);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateConsigneeUser([FromBody] ConsigneeUserDTO consigneeUser)
        {
            if (consigneeUser is null) return BadRequest("consigneeUser is null");
            var updatedObject = await _serviceManager.consigneeUserService.Update(consigneeUser);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsigneeUser(int id)
        {
            var deletedObject = await _serviceManager.consigneeUserService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                