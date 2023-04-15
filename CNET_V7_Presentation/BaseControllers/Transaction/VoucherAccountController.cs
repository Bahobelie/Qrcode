
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
    public class VoucherAccountController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public VoucherAccountController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVoucherAccountById(int id)
        {
            var obj = await _serviceManager.voucherAccountService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVoucherAccounts()
        {
            var accounts = await _serviceManager.voucherAccountService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVoucherAccount([FromBody] VoucherAccountDTO voucherAccount)
        {
            if (voucherAccount is null)
                return BadRequest("voucherAccount is null");

            var createdObj = await _serviceManager.voucherAccountService.Create(voucherAccount);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateVoucherAccount([FromBody] VoucherAccountDTO voucherAccount)
        {
            if (voucherAccount is null) return BadRequest("voucherAccount is null");
            var updatedObject = await _serviceManager.voucherAccountService.Update(voucherAccount);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoucherAccount(int id)
        {
            var deletedObject = await _serviceManager.voucherAccountService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                