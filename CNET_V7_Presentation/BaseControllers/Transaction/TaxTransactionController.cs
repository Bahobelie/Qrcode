
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
    public class TaxTransactionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TaxTransactionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaxTransactionById(int id)
        {
            var obj = await _serviceManager.taxTransactionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTaxTransactions()
        {
            var accounts = await _serviceManager.taxTransactionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTaxTransaction([FromBody] TaxTransactionDTO taxTransaction)
        {
            if (taxTransaction is null)
                return BadRequest("taxTransaction is null");

            var createdObj = await _serviceManager.taxTransactionService.Create(taxTransaction);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTaxTransaction([FromBody] TaxTransactionDTO taxTransaction)
        {
            if (taxTransaction is null) return BadRequest("taxTransaction is null");
            var updatedObject = await _serviceManager.taxTransactionService.Update(taxTransaction);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaxTransaction(int id)
        {
            var deletedObject = await _serviceManager.taxTransactionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                