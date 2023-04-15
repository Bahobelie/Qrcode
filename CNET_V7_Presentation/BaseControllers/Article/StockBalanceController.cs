
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ArticleSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class StockBalanceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public StockBalanceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStockBalanceById(int id)
        {
            var obj = await _serviceManager.stockBalanceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStockBalances()
        {
            var accounts = await _serviceManager.stockBalanceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStockBalance([FromBody] StockBalanceDTO stockBalance)
        {
            if (stockBalance is null)
                return BadRequest("stockBalance is null");

            var createdObj = await _serviceManager.stockBalanceService.Create(stockBalance);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStockBalance([FromBody] StockBalanceDTO stockBalance)
        {
            if (stockBalance is null) return BadRequest("stockBalance is null");
            var updatedObject = await _serviceManager.stockBalanceService.Update(stockBalance);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockBalance(int id)
        {
            var deletedObject = await _serviceManager.stockBalanceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                