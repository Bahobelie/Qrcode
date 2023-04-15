
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
    public class GsltaxController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public GsltaxController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetGsltaxById(int id)
        {
            var obj = await _serviceManager.gsltaxService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllGsltaxs()
        {
            var accounts = await _serviceManager.gsltaxService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGsltax([FromBody] GsltaxDTO gsltax)
        {
            if (gsltax is null)
                return BadRequest("gsltax is null");

            var createdObj = await _serviceManager.gsltaxService.Create(gsltax);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateGsltax([FromBody] GsltaxDTO gsltax)
        {
            if (gsltax is null) return BadRequest("gsltax is null");
            var updatedObject = await _serviceManager.gsltaxService.Update(gsltax);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGsltax(int id)
        {
            var deletedObject = await _serviceManager.gsltaxService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                