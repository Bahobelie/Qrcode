
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
    public class TransactionLimitController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TransactionLimitController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionLimitById(int id)
        {
            var obj = await _serviceManager.transactionLimitService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactionLimits()
        {
            var accounts = await _serviceManager.transactionLimitService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransactionLimit([FromBody] TransactionLimitDTO transactionLimit)
        {
            if (transactionLimit is null)
                return BadRequest("transactionLimit is null");

            var createdObj = await _serviceManager.transactionLimitService.Create(transactionLimit);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTransactionLimit([FromBody] TransactionLimitDTO transactionLimit)
        {
            if (transactionLimit is null) return BadRequest("transactionLimit is null");
            var updatedObject = await _serviceManager.transactionLimitService.Update(transactionLimit);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionLimit(int id)
        {
            var deletedObject = await _serviceManager.transactionLimitService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                