
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.SecuritySchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class IssuedCardController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public IssuedCardController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIssuedCardById(int id)
        {
            var obj = await _serviceManager.issuedCardService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllIssuedCards()
        {
            var accounts = await _serviceManager.issuedCardService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateIssuedCard([FromBody] IssuedCardDTO issuedCard)
        {
            if (issuedCard is null)
                return BadRequest("issuedCard is null");

            var createdObj = await _serviceManager.issuedCardService.Create(issuedCard);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateIssuedCard([FromBody] IssuedCardDTO issuedCard)
        {
            if (issuedCard is null) return BadRequest("issuedCard is null");
            var updatedObject = await _serviceManager.issuedCardService.Update(issuedCard);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteIssuedCard(int id)
        {
            var deletedObject = await _serviceManager.issuedCardService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                