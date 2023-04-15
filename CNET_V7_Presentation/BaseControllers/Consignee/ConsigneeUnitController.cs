
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
    public class ConsigneeUnitController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ConsigneeUnitController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsigneeUnitById(int id)
        {
            var obj = await _serviceManager.consigneeUnitService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllConsigneeUnits()
        {
            var accounts = await _serviceManager.consigneeUnitService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateConsigneeUnit([FromBody] ConsigneeUnitDTO consigneeUnit)
        {
            if (consigneeUnit is null)
                return BadRequest("consigneeUnit is null");

            var createdObj = await _serviceManager.consigneeUnitService.Create(consigneeUnit);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateConsigneeUnit([FromBody] ConsigneeUnitDTO consigneeUnit)
        {
            if (consigneeUnit is null) return BadRequest("consigneeUnit is null");
            var updatedObject = await _serviceManager.consigneeUnitService.Update(consigneeUnit);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsigneeUnit(int id)
        {
            var deletedObject = await _serviceManager.consigneeUnitService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                