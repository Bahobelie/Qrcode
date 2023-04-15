
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.TransactionSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClosedRelationController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ClosedRelationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetClosedRelationById(int id)
        {
            var obj = await _serviceManager.closedRelationService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClosedRelations()
        {
            var accounts = await _serviceManager.closedRelationService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateClosedRelation([FromBody] ClosedRelationDTO closedRelation)
        {
            if (closedRelation is null)
                return BadRequest("closedRelation is null");

            var createdObj = await _serviceManager.closedRelationService.Create(closedRelation);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateClosedRelation([FromBody] ClosedRelationDTO closedRelation)
        {
            if (closedRelation is null) return BadRequest("closedRelation is null");
            var updatedObject = await _serviceManager.closedRelationService.Update(closedRelation);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClosedRelation(int id)
        {
            var deletedObject = await _serviceManager.closedRelationService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                