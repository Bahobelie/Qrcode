
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
    public class PreferentialValueFactorController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public PreferentialValueFactorController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPreferentialValueFactorById(int id)
        {
            var obj = await _serviceManager.preferentialValueFactorService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPreferentialValueFactors()
        {
            var accounts = await _serviceManager.preferentialValueFactorService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePreferentialValueFactor([FromBody] PreferentialValueFactorDTO preferentialValueFactor)
        {
            if (preferentialValueFactor is null)
                return BadRequest("preferentialValueFactor is null");

            var createdObj = await _serviceManager.preferentialValueFactorService.Create(preferentialValueFactor);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdatePreferentialValueFactor([FromBody] PreferentialValueFactorDTO preferentialValueFactor)
        {
            if (preferentialValueFactor is null) return BadRequest("preferentialValueFactor is null");
            var updatedObject = await _serviceManager.preferentialValueFactorService.Update(preferentialValueFactor);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreferentialValueFactor(int id)
        {
            var deletedObject = await _serviceManager.preferentialValueFactorService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                