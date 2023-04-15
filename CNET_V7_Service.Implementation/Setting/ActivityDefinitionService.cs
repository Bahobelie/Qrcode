
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
    public class ActivityDefinitionService : IActivityDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ActivityDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ActivityDefinitionDTO>> Create(ActivityDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ActivityDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ActivityDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ActivityDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ActivityDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ActivityDefinition.Delete(id);
                var returnedObj = _mapper.Map<ActivityDefinitionDTO>(res);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ActivityDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ActivityDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ActivityDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<ActivityDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ActivityDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ActivityDefinition.FindById(id);
                var returnedObj = _mapper.Map<ActivityDefinitionDTO>(result);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDefinitionDTO>> Update(ActivityDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<ActivityDefinition>(entity);
                var updatedObject = await _repository.ActivityDefinition.Update(account);
                var returnedObj = _mapper.Map<ActivityDefinitionDTO>(updatedObject);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            