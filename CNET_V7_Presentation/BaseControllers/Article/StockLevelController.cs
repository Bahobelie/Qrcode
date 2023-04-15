
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
    public class StockLevelController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public StockLevelController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStockLevelById(int id)
        {
            var obj = await _serviceManager.stockLevelService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStockLevels()
        {
            var accounts = await _serviceManager.stockLevelService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStockLevel([FromBody] StockLevelDTO stockLevel)
        {
            if (stockLevel is null)
                return BadRequest("stockLevel is null");

            var createdObj = await _serviceManager.stockLevelService.Create(stockLevel);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStockLevel([FromBody] StockLevelDTO stockLevel)
        {
            if (stockLevel is null) return BadRequest("stockLevel is null");
            var updatedObject = await _serviceManager.stockLevelService.Update(stockLevel);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStockLevel(int id)
        {
            var deletedObject = await _serviceManager.stockLevelService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                