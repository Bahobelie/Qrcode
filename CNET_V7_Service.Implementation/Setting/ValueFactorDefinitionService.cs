
using AutoMapper;
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SettingSchema
{
    public class ValueFactorDefinitionService : IValueFactorDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ValueFactorDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ValueFactorDefinitionDTO>> Create(ValueFactorDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ValueFactorDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ValueFactorDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ValueFactorDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ValueFactorDefinition.Delete(id);
                var returnedObj = _mapper.Map<ValueFactorDefinitionDTO>(res);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ValueFactorDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ValueFactorDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ValueFactorDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<ValueFactorDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ValueFactorDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ValueFactorDefinition.FindById(id);
                var returnedObj = _mapper.Map<ValueFactorDefinitionDTO>(result);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDefinitionDTO>> Update(ValueFactorDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<ValueFactorDefinition>(entity);
                var updatedObject = await _repository.ValueFactorDefinition.Update(account);
                var returnedObj = _mapper.Map<ValueFactorDefinitionDTO>(updatedObject);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            