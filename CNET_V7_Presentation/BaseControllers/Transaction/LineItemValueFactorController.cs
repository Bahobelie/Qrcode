
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
    public class LineItemValueFactorController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public LineItemValueFactorController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLineItemValueFactorById(int id)
        {
            var obj = await _serviceManager.lineItemValueFactorService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLineItemValueFactors()
        {
            var accounts = await _serviceManager.lineItemValueFactorService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLineItemValueFactor([FromBody] LineItemValueFactorDTO lineItemValueFactor)
        {
            if (lineItemValueFactor is null)
                return BadRequest("lineItemValueFactor is null");

            var createdObj = await _serviceManager.lineItemValueFactorService.Create(lineItemValueFactor);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLineItemValueFactor([FromBody] LineItemValueFactorDTO lineItemValueFactor)
        {
            if (lineItemValueFactor is null) return BadRequest("lineItemValueFactor is null");
            var updatedObject = await _serviceManager.lineItemValueFactorService.Update(lineItemValueFactor);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLineItemValueFactor(int id)
        {
            var deletedObject = await _serviceManager.lineItemValueFactorService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                