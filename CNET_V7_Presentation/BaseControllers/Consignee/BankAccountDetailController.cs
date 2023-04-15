
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ConsigneeSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountDetailController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public BankAccountDetailController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBankAccountDetailById(int id)
        {
            var obj = await _serviceManager.bankAccountDetailService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBankAccountDetails()
        {
            var accounts = await _serviceManager.bankAccountDetailService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBankAccountDetail([FromBody] BankAccountDetailDTO bankAccountDetail)
        {
            if (bankAccountDetail is null)
                return BadRequest("bankAccountDetail is null");

            var createdObj = await _serviceManager.bankAccountDetailService.Create(bankAccountDetail);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBankAccountDetail([FromBody] BankAccountDetailDTO bankAccountDetail)
        {
            if (bankAccountDetail is null) return BadRequest("bankAccountDetail is null");
            var updatedObject = await _serviceManager.bankAccountDetailService.Update(bankAccountDetail);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankAccountDetail(int id)
        {
            var deletedObject = await _serviceManager.bankAccountDetailService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                