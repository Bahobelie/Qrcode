
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
    public class TransactionReferenceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public TransactionReferenceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTransactionReferenceById(int id)
        {
            var obj = await _serviceManager.transactionReferenceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTransactionReferences()
        {
            var accounts = await _serviceManager.transactionReferenceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransactionReference([FromBody] TransactionReferenceDTO transactionReference)
        {
            if (transactionReference is null)
                return BadRequest("transactionReference is null");

            var createdObj = await _serviceManager.transactionReferenceService.Create(transactionReference);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTransactionReference([FromBody] TransactionReferenceDTO transactionReference)
        {
            if (transactionReference is null) return BadRequest("transactionReference is null");
            var updatedObject = await _serviceManager.transactionReferenceService.Update(transactionReference);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransactionReference(int id)
        {
            var deletedObject = await _serviceManager.transactionReferenceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                