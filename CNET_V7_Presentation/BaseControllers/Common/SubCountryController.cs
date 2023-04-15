
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
    public class SubCountryController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SubCountryController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubCountryById(int id)
        {
            var obj = await _serviceManager.subCountryService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSubCountrys()
        {
            var accounts = await _serviceManager.subCountryService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubCountry([FromBody] SubCountryDTO subCountry)
        {
            if (subCountry is null)
                return BadRequest("subCountry is null");

            var createdObj = await _serviceManager.subCountryService.Create(subCountry);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSubCountry([FromBody] SubCountryDTO subCountry)
        {
            if (subCountry is null) return BadRequest("subCountry is null");
            var updatedObject = await _serviceManager.subCountryService.Update(subCountry);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubCountry(int id)
        {
            var deletedObject = await _serviceManager.subCountryService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                