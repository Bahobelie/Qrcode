
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
    public class BeginingBalanceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public BeginingBalanceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBeginingBalanceById(int id)
        {
            var obj = await _serviceManager.beginingBalanceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBeginingBalances()
        {
            var accounts = await _serviceManager.beginingBalanceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBeginingBalance([FromBody] BeginingBalanceDTO beginingBalance)
        {
            if (beginingBalance is null)
                return BadRequest("beginingBalance is null");

            var createdObj = await _serviceManager.beginingBalanceService.Create(beginingBalance);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBeginingBalance([FromBody] BeginingBalanceDTO beginingBalance)
        {
            if (beginingBalance is null) return BadRequest("beginingBalance is null");
            var updatedObject = await _serviceManager.beginingBalanceService.Update(beginingBalance);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBeginingBalance(int id)
        {
            var deletedObject = await _serviceManager.beginingBalanceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                