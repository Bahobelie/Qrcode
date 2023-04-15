
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
    public class ObjectStateDefinitionService : IObjectStateDefinitionService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ObjectStateDefinitionService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ObjectStateDefinitionDTO>> Create(ObjectStateDefinitionDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ObjectStateDefinition>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ObjectStateDefinition.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ObjectStateDefinitionDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDefinitionDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDefinitionDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ObjectStateDefinition.Delete(id);
                var returnedObj = _mapper.Map<ObjectStateDefinitionDTO>(res);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ObjectStateDefinitionDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ObjectStateDefinition.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ObjectStateDefinitionDTO>>(result);
                return new ResponseModel<IEnumerable<ObjectStateDefinitionDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ObjectStateDefinitionDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDefinitionDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ObjectStateDefinition.FindById(id);
                var returnedObj = _mapper.Map<ObjectStateDefinitionDTO>(result);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDefinitionDTO>> Update(ObjectStateDefinitionDTO entity)
        {
            try
            {
                var account = _mapper.Map<ObjectStateDefinition>(entity);
                var updatedObject = await _repository.ObjectStateDefinition.Update(account);
                var returnedObj = _mapper.Map<ObjectStateDefinitionDTO>(updatedObject);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDefinitionDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            