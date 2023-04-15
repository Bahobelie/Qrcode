
using CNET_V7_Domain.DataModels.AccountingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.AccountingSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.AccountingSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class ControlAccountController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ControlAccountController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetControlAccountById(int id)
        {
            var obj = await _serviceManager.controlAccountService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllControlAccounts()
        {
            var accounts = await _serviceManager.controlAccountService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateControlAccount([FromBody] ControlAccountDTO controlAccount)
        {
            if (controlAccount is null)
                return BadRequest("controlAccount is null");

            var createdObj = await _serviceManager.controlAccountService.Create(controlAccount);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateControlAccount([FromBody] ControlAccountDTO controlAccount)
        {
            if (controlAccount is null) return BadRequest("controlAccount is null");
            var updatedObject = await _serviceManager.controlAccountService.Update(controlAccount);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteControlAccount(int id)
        {
            var deletedObject = await _serviceManager.controlAccountService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                