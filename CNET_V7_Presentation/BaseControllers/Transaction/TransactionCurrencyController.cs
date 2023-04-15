
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
    public class TransactionCurrencyController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TransactionCurrencyController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionCurrencyById(int id)
        {
            var obj = await _serviceManager.transactionCurrencyService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactionCurrencys()
        {
            var accounts = await _serviceManager.transactionCurrencyService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransactionCurrency([FromBody] TransactionCurrencyDTO transactionCurrency)
        {
            if (transactionCurrency is null)
                return BadRequest("transactionCurrency is null");

            var createdObj = await _serviceManager.transactionCurrencyService.Create(transactionCurrency);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTransactionCurrency([FromBody] TransactionCurrencyDTO transactionCurrency)
        {
            if (transactionCurrency is null) return BadRequest("transactionCurrency is null");
            var updatedObject = await _serviceManager.transactionCurrencyService.Update(transactionCurrency);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionCurrency(int id)
        {
            var deletedObject = await _serviceManager.transactionCurrencyService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                