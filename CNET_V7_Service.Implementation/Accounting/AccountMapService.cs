
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
    public class AccountMapService : IAccountMapService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AccountMapService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AccountMapDTO>> Create(AccountMapDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AccountMap>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AccountMap.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AccountMapDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AccountMapDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountMapDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountMapDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AccountMap.Delete(id);
                var returnedObj = _mapper.Map<AccountMapDTO>(res);
                return new ResponseModel<AccountMapDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AccountMapDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AccountMap.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AccountMapDTO>>(result);
                return new ResponseModel<IEnumerable<AccountMapDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AccountMapDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountMapDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AccountMap.FindById(id);
                var returnedObj = _mapper.Map<AccountMapDTO>(result);
                return new ResponseModel<AccountMapDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AccountMapDTO>> Update(AccountMapDTO entity)
        {
            try
            {
                var account = _mapper.Map<AccountMap>(entity);
                var updatedObject = await _repository.AccountMap.Update(account);
                var returnedObj = _mapper.Map<AccountMapDTO>(updatedObject);
                return new ResponseModel<AccountMapDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AccountMapDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            