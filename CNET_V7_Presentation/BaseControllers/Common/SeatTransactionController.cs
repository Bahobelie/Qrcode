
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.CommonSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class SeatTransactionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SeatTransactionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeatTransactionById(int id)
        {
            var obj = await _serviceManager.seatTransactionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeatTransactions()
        {
            var accounts = await _serviceManager.seatTransactionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeatTransaction([FromBody] SeatTransactionDTO seatTransaction)
        {
            if (seatTransaction is null)
                return BadRequest("seatTransaction is null");

            var createdObj = await _serviceManager.seatTransactionService.Create(seatTransaction);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeatTransaction([FromBody] SeatTransactionDTO seatTransaction)
        {
            if (seatTransaction is null) return BadRequest("seatTransaction is null");
            var updatedObject = await _serviceManager.seatTransactionService.Update(seatTransaction);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeatTransaction(int id)
        {
            var deletedObject = await _serviceManager.seatTransactionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                