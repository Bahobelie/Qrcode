
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
    public class DepreciationRuleService : IDepreciationRuleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DepreciationRuleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DepreciationRuleDTO>> Create(DepreciationRuleDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<DepreciationRule>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.DepreciationRule.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DepreciationRuleDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DepreciationRuleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DepreciationRuleDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DepreciationRuleDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.DepreciationRule.Delete(id);
                var returnedObj = _mapper.Map<DepreciationRuleDTO>(res);
                return new ResponseModel<DepreciationRuleDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DepreciationRuleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DepreciationRuleDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.DepreciationRule.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DepreciationRuleDTO>>(result);
                return new ResponseModel<IEnumerable<DepreciationRuleDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DepreciationRuleDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DepreciationRuleDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.DepreciationRule.FindById(id);
                var returnedObj = _mapper.Map<DepreciationRuleDTO>(result);
                return new ResponseModel<DepreciationRuleDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DepreciationRuleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DepreciationRuleDTO>> Update(DepreciationRuleDTO entity)
        {
            try
            {
                var account = _mapper.Map<DepreciationRule>(entity);
                var updatedObject = await _repository.DepreciationRule.Update(account);
                var returnedObj = _mapper.Map<DepreciationRuleDTO>(updatedObject);
                return new ResponseModel<DepreciationRuleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DepreciationRuleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            