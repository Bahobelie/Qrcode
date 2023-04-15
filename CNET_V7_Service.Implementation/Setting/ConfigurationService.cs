
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
    public class ConfigurationService : IConfigurationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ConfigurationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ConfigurationDTO>> Create(ConfigurationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Configuration>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Configuration.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ConfigurationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ConfigurationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConfigurationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConfigurationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Configuration.Delete(id);
                var returnedObj = _mapper.Map<ConfigurationDTO>(res);
                return new ResponseModel<ConfigurationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConfigurationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ConfigurationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Configuration.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ConfigurationDTO>>(result);
                return new ResponseModel<IEnumerable<ConfigurationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ConfigurationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConfigurationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Configuration.FindById(id);
                var returnedObj = _mapper.Map<ConfigurationDTO>(result);
                return new ResponseModel<ConfigurationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConfigurationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConfigurationDTO>> Update(ConfigurationDTO entity)
        {
            try
            {
                var account = _mapper.Map<Configuration>(entity);
                var updatedObject = await _repository.Configuration.Update(account);
                var returnedObj = _mapper.Map<ConfigurationDTO>(updatedObject);
                return new ResponseModel<ConfigurationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConfigurationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            