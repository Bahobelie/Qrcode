
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
    public class ConsigneeController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ConsigneeController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsigneeById(int id)
        {
            var obj = await _serviceManager.consigneeService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllConsignees()
        {
            var accounts = await _serviceManager.consigneeService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateConsignee([FromBody] ConsigneeDTO consignee)
        {
            if (consignee is null)
                return BadRequest("consignee is null");

            var createdObj = await _serviceManager.consigneeService.Create(consignee);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateConsignee([FromBody] ConsigneeDTO consignee)
        {
            if (consignee is null) return BadRequest("consignee is null");
            var updatedObject = await _serviceManager.consigneeService.Update(consignee);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsignee(int id)
        {
            var deletedObject = await _serviceManager.consigneeService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                