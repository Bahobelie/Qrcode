
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ConsigneeSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class LanguagePreferenceController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public LanguagePreferenceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLanguagePreferenceById(int id)
        {
            var obj = await _serviceManager.languagePreferenceService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguagePreferences()
        {
            var accounts = await _serviceManager.languagePreferenceService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLanguagePreference([FromBody] LanguagePreferenceDTO languagePreference)
        {
            if (languagePreference is null)
                return BadRequest("languagePreference is null");

            var createdObj = await _serviceManager.languagePreferenceService.Create(languagePreference);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateLanguagePreference([FromBody] LanguagePreferenceDTO languagePreference)
        {
            if (languagePreference is null) return BadRequest("languagePreference is null");
            var updatedObject = await _serviceManager.languagePreferenceService.Update(languagePreference);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLanguagePreference(int id)
        {
            var deletedObject = await _serviceManager.languagePreferenceService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                