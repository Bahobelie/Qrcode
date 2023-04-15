
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
    public class VoucherExtensionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherExtensionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherExtensionById(int id)
        {
            var obj = await _serviceManager.voucherExtensionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherExtensions()
        {
            var accounts = await _serviceManager.voucherExtensionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherExtension([FromBody] VoucherExtensionDTO voucherExtension)
        {
            if (voucherExtension is null)
                return BadRequest("voucherExtension is null");

            var createdObj = await _serviceManager.voucherExtensionService.Create(voucherExtension);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherExtension([FromBody] VoucherExtensionDTO voucherExtension)
        {
            if (voucherExtension is null) return BadRequest("voucherExtension is null");
            var updatedObject = await _serviceManager.voucherExtensionService.Update(voucherExtension);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherExtension(int id)
        {
            var deletedObject = await _serviceManager.voucherExtensionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                