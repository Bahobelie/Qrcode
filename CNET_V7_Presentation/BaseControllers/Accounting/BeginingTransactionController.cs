
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
    public class BeginingTransactionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public BeginingTransactionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBeginingTransactionById(int id)
        {
            var obj = await _serviceManager.beginingTransactionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBeginingTransactions()
        {
            var accounts = await _serviceManager.beginingTransactionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBeginingTransaction([FromBody] BeginingTransactionDTO beginingTransaction)
        {
            if (beginingTransaction is null)
                return BadRequest("beginingTransaction is null");

            var createdObj = await _serviceManager.beginingTransactionService.Create(beginingTransaction);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBeginingTransaction([FromBody] BeginingTransactionDTO beginingTransaction)
        {
            if (beginingTransaction is null) return BadRequest("beginingTransaction is null");
            var updatedObject = await _serviceManager.beginingTransactionService.Update(beginingTransaction);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeginingTransaction(int id)
        {
            var deletedObject = await _serviceManager.beginingTransactionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                