
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
    public class SeasonalMessageController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SeasonalMessageController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeasonalMessageById(int id)
        {
            var obj = await _serviceManager.seasonalMessageService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeasonalMessages()
        {
            var accounts = await _serviceManager.seasonalMessageService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeasonalMessage([FromBody] SeasonalMessageDTO seasonalMessage)
        {
            if (seasonalMessage is null)
                return BadRequest("seasonalMessage is null");

            var createdObj = await _serviceManager.seasonalMessageService.Create(seasonalMessage);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeasonalMessage([FromBody] SeasonalMessageDTO seasonalMessage)
        {
            if (seasonalMessage is null) return BadRequest("seasonalMessage is null");
            var updatedObject = await _serviceManager.seasonalMessageService.Update(seasonalMessage);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeasonalMessage(int id)
        {
            var deletedObject = await _serviceManager.seasonalMessageService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                