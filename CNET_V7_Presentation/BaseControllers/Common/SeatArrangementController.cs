
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
    public class SeatArrangementController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SeatArrangementController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSeatArrangementById(int id)
        {
            var obj = await _serviceManager.seatArrangementService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSeatArrangements()
        {
            var accounts = await _serviceManager.seatArrangementService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSeatArrangement([FromBody] SeatArrangementDTO seatArrangement)
        {
            if (seatArrangement is null)
                return BadRequest("seatArrangement is null");

            var createdObj = await _serviceManager.seatArrangementService.Create(seatArrangement);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSeatArrangement([FromBody] SeatArrangementDTO seatArrangement)
        {
            if (seatArrangement is null) return BadRequest("seatArrangement is null");
            var updatedObject = await _serviceManager.seatArrangementService.Update(seatArrangement);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSeatArrangement(int id)
        {
            var deletedObject = await _serviceManager.seatArrangementService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                