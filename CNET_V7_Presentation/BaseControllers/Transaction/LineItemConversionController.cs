
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
    public class LineItemConversionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public LineItemConversionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLineItemConversionById(int id)
        {
            var obj = await _serviceManager.lineItemConversionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLineItemConversions()
        {
            var accounts = await _serviceManager.lineItemConversionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLineItemConversion([FromBody] LineItemConversionDTO lineItemConversion)
        {
            if (lineItemConversion is null)
                return BadRequest("lineItemConversion is null");

            var createdObj = await _serviceManager.lineItemConversionService.Create(lineItemConversion);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLineItemConversion([FromBody] LineItemConversionDTO lineItemConversion)
        {
            if (lineItemConversion is null) return BadRequest("lineItemConversion is null");
            var updatedObject = await _serviceManager.lineItemConversionService.Update(lineItemConversion);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLineItemConversion(int id)
        {
            var deletedObject = await _serviceManager.lineItemConversionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                