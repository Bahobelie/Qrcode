
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
    public class VoucherTermController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherTermController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherTermById(int id)
        {
            var obj = await _serviceManager.voucherTermService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherTerms()
        {
            var accounts = await _serviceManager.voucherTermService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherTerm([FromBody] VoucherTermDTO voucherTerm)
        {
            if (voucherTerm is null)
                return BadRequest("voucherTerm is null");

            var createdObj = await _serviceManager.voucherTermService.Create(voucherTerm);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherTerm([FromBody] VoucherTermDTO voucherTerm)
        {
            if (voucherTerm is null) return BadRequest("voucherTerm is null");
            var updatedObject = await _serviceManager.voucherTermService.Update(voucherTerm);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherTerm(int id)
        {
            var deletedObject = await _serviceManager.voucherTermService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                