
using AutoMapper;
using CNET_V7_Domain.DataModels.AccountingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.AccountingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.AccountingSchema
{
    public class AccountService : IAccountService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccountService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AccountDTO>> Create(AccountDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Account>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Account.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AccountDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Account.Delete(id);
                var returnedObj = _mapper.Map<AccountDTO>(res);
                return new ResponseModel<AccountDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AccountDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Account.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AccountDTO>>(result);
                return new ResponseModel<IEnumerable<AccountDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AccountDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Account.FindById(id);
                var returnedObj = _mapper.Map<AccountDTO>(result);
                return new ResponseModel<AccountDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountDTO>> Update(AccountDTO entity)
        {
            try
            {
                var account = _mapper.Map<Account>(entity);
                var updatedObject = await _repository.Account.Update(account);
                var returnedObj = _mapper.Map<AccountDTO>(updatedObject);
                return new ResponseModel<AccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            