
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.CommonSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValueFactorController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ValueFactorController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetValueFactorById(int id)
        {
            var obj = await _serviceManager.valueFactorService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllValueFactors()
        {
            var accounts = await _serviceManager.valueFactorService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateValueFactor([FromBody] ValueFactorDTO valueFactor)
        {
            if (valueFactor is null)
                return BadRequest("valueFactor is null");

            var createdObj = await _serviceManager.valueFactorService.Create(valueFactor);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateValueFactor([FromBody] ValueFactorDTO valueFactor)
        {
            if (valueFactor is null) return BadRequest("valueFactor is null");
            var updatedObject = await _serviceManager.valueFactorService.Update(valueFactor);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteValueFactor(int id)
        {
            var deletedObject = await _serviceManager.valueFactorService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                