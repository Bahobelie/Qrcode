
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
    public class MovieScheduleController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public MovieScheduleController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieScheduleById(int id)
        {
            var obj = await _serviceManager.movieScheduleService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllMovieSchedules()
        {
            var accounts = await _serviceManager.movieScheduleService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovieSchedule([FromBody] MovieScheduleDTO movieSchedule)
        {
            if (movieSchedule is null)
                return BadRequest("movieSchedule is null");

            var createdObj = await _serviceManager.movieScheduleService.Create(movieSchedule);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateMovieSchedule([FromBody] MovieScheduleDTO movieSchedule)
        {
            if (movieSchedule is null) return BadRequest("movieSchedule is null");
            var updatedObject = await _serviceManager.movieScheduleService.Update(movieSchedule);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovieSchedule(int id)
        {
            var deletedObject = await _serviceManager.movieScheduleService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                