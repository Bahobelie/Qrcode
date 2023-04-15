
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
    public class LineItemReferenceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public LineItemReferenceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLineItemReferenceById(int id)
        {
            var obj = await _serviceManager.lineItemReferenceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLineItemReferences()
        {
            var accounts = await _serviceManager.lineItemReferenceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLineItemReference([FromBody] LineItemReferenceDTO lineItemReference)
        {
            if (lineItemReference is null)
                return BadRequest("lineItemReference is null");

            var createdObj = await _serviceManager.lineItemReferenceService.Create(lineItemReference);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLineItemReference([FromBody] LineItemReferenceDTO lineItemReference)
        {
            if (lineItemReference is null) return BadRequest("lineItemReference is null");
            var updatedObject = await _serviceManager.lineItemReferenceService.Update(lineItemReference);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLineItemReference(int id)
        {
            var deletedObject = await _serviceManager.lineItemReferenceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                