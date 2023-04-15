
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers.ArticleSchema
{

    [Route("api/[controller]")]
    [ApiController]
    public class SpecificationController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public SpecificationController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSpecificationById(int id)
        {
            var obj = await _serviceManager.specificationService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSpecifications()
        {
            var accounts = await _serviceManager.specificationService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSpecification([FromBody] SpecificationDTO specification)
        {
            if (specification is null)
                return BadRequest("specification is null");

            var createdObj = await _serviceManager.specificationService.Create(specification);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSpecification([FromBody] SpecificationDTO specification)
        {
            if (specification is null) return BadRequest("specification is null");
            var updatedObject = await _serviceManager.specificationService.Update(specification);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSpecification(int id)
        {
            var deletedObject = await _serviceManager.specificationService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                