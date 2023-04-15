
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
    public class SubtitleController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SubtitleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubtitleById(int id)
        {
            var obj = await _serviceManager.subtitleService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubtitles()
        {
            var accounts = await _serviceManager.subtitleService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubtitle([FromBody] SubtitleDTO subtitle)
        {
            if (subtitle is null)
                return BadRequest("subtitle is null");

            var createdObj = await _serviceManager.subtitleService.Create(subtitle);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubtitle([FromBody] SubtitleDTO subtitle)
        {
            if (subtitle is null) return BadRequest("subtitle is null");
            var updatedObject = await _serviceManager.subtitleService.Update(subtitle);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubtitle(int id)
        {
            var deletedObject = await _serviceManager.subtitleService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                