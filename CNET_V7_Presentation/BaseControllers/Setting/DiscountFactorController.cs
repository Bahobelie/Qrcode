
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SettingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class DiscountFactorController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public DiscountFactorController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountFactorById(int id)
        {
            var obj = await _serviceManager.discountFactorService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDiscountFactors()
        {
            var accounts = await _serviceManager.discountFactorService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountFactor([FromBody] DiscountFactorDTO discountFactor)
        {
            if (discountFactor is null)
                return BadRequest("discountFactor is null");

            var createdObj = await _serviceManager.discountFactorService.Create(discountFactor);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountFactor([FromBody] DiscountFactorDTO discountFactor)
        {
            if (discountFactor is null) return BadRequest("discountFactor is null");
            var updatedObject = await _serviceManager.discountFactorService.Update(discountFactor);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscountFactor(int id)
        {
            var deletedObject = await _serviceManager.discountFactorService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                