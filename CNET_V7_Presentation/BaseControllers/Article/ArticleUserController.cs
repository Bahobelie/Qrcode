
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
    public class ArticleUserController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;

        public ArticleUserController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleUserById(int id)
        {
            var obj = await _serviceManager.articleUserService.FindById(id);
            if (obj.Success) return Ok(obj.Data);
            return BadRequest(obj.Ex.ToString());
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticleUsers()
        {
            var accounts = await _serviceManager.articleUserService.FindAll(trackChanges: false);
            if(accounts.Success)
                return Ok(accounts.Data);
            return BadRequest(accounts.Message);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticleUser([FromBody] ArticleUserDTO articleUser)
        {
            if (articleUser is null)
                return BadRequest("articleUser is null");

            var createdObj = await _serviceManager.articleUserService.Create(articleUser);
            if (createdObj.Success)
                return Ok(createdObj.Data);
            return BadRequest(createdObj.Ex.ToString());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticleUser([FromBody] ArticleUserDTO articleUser)
        {
            if (articleUser is null) return BadRequest("articleUser is null");
            var updatedObject = await _serviceManager.articleUserService.Update(articleUser);
            if(updatedObject.Success) return Ok(updatedObject.Data);
            return BadRequest(updatedObject.Ex.ToString());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticleUser(int id)
        {
            var deletedObject = await _serviceManager.articleUserService.Delete(id);
            if (deletedObject.Success)
                return NoContent();
            return BadRequest(deletedObject.Ex.ToString());
        }

    }
}

                