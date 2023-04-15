using CNET_V7_Domain.DataModels;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts;
using CNET_V7_Service.Contracts.Accounting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Presentation.BaseControllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRepositoryManager repositoryManager;
        private readonly IServiceManager _service;
        public AccountController(IServiceManager service, IRepositoryManager repositoryManager)
        {
            _service = service;
            this.repositoryManager = repositoryManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccounts()
        {
            var accounts = await _service.AccountService.GetAllAccounts(trackChanges: false);
            return Ok(accounts);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAccount([FromBody] AccountDTO account)
        {
            if (account is null)
                return BadRequest("account is null");
            await _service.AccountService.CreateAccount(account);
            return Ok();
        }
    }
}
