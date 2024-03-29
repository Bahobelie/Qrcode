
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
    public class NonCashTransactionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public NonCashTransactionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNonCashTransactionById(int id)
        {
            var obj = await _serviceManager.nonCashTransactionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllNonCashTransactions()
        {
            var accounts = await _serviceManager.nonCashTransactionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateNonCashTransaction([FromBody] NonCashTransactionDTO nonCashTransaction)
        {
            if (nonCashTransaction is null)
                return BadRequest("nonCashTransaction is null");

            var createdObj = await _serviceManager.nonCashTransactionService.Create(nonCashTransaction);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateNonCashTransaction([FromBody] NonCashTransactionDTO nonCashTransaction)
        {
            if (nonCashTransaction is null) return BadRequest("nonCashTransaction is null");
            var updatedObject = await _serviceManager.nonCashTransactionService.Update(nonCashTransaction);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNonCashTransaction(int id)
        {
            var deletedObject = await _serviceManager.nonCashTransactionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                