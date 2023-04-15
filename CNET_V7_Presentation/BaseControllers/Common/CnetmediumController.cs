
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
    public class CnetmediumController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public CnetmediumController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCnetmediumById(int id)
        {
            var obj = await _serviceManager.cnetmediumService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCnetmediums()
        {
            var accounts = await _serviceManager.cnetmediumService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCnetmedium([FromBody] CnetmediumDTO cnetmedium)
        {
            if (cnetmedium is null)
                return BadRequest("cnetmedium is null");

            var createdObj = await _serviceManager.cnetmediumService.Create(cnetmedium);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCnetmedium([FromBody] CnetmediumDTO cnetmedium)
        {
            if (cnetmedium is null) return BadRequest("cnetmedium is null");
            var updatedObject = await _serviceManager.cnetmediumService.Update(cnetmedium);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCnetmedium(int id)
        {
            var deletedObject = await _serviceManager.cnetmediumService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                