
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
    public class SpaceDirectionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SpaceDirectionController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpaceDirectionById(int id)
        {
            var obj = await _serviceManager.spaceDirectionService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSpaceDirections()
        {
            var accounts = await _serviceManager.spaceDirectionService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpaceDirection([FromBody] SpaceDirectionDTO spaceDirection)
        {
            if (spaceDirection is null)
                return BadRequest("spaceDirection is null");

            var createdObj = await _serviceManager.spaceDirectionService.Create(spaceDirection);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSpaceDirection([FromBody] SpaceDirectionDTO spaceDirection)
        {
            if (spaceDirection is null) return BadRequest("spaceDirection is null");
            var updatedObject = await _serviceManager.spaceDirectionService.Update(spaceDirection);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpaceDirection(int id)
        {
            var deletedObject = await _serviceManager.spaceDirectionService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                