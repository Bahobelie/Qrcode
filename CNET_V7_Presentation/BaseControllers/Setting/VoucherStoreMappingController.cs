
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
    public class VoucherStoreMappingController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherStoreMappingController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherStoreMappingById(int id)
        {
            var obj = await _serviceManager.voucherStoreMappingService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherStoreMappings()
        {
            var accounts = await _serviceManager.voucherStoreMappingService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherStoreMapping([FromBody] VoucherStoreMappingDTO voucherStoreMapping)
        {
            if (voucherStoreMapping is null)
                return BadRequest("voucherStoreMapping is null");

            var createdObj = await _serviceManager.voucherStoreMappingService.Create(voucherStoreMapping);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherStoreMapping([FromBody] VoucherStoreMappingDTO voucherStoreMapping)
        {
            if (voucherStoreMapping is null) return BadRequest("voucherStoreMapping is null");
            var updatedObject = await _serviceManager.voucherStoreMappingService.Update(voucherStoreMapping);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherStoreMapping(int id)
        {
            var deletedObject = await _serviceManager.voucherStoreMappingService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                