
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
    public class ValueFactorSetupService : IValueFactorSetupService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ValueFactorSetupService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ValueFactorSetupDTO>> Create(ValueFactorSetupDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ValueFactorSetup>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ValueFactorSetup.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ValueFactorSetupDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ValueFactorSetupDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorSetupDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorSetupDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ValueFactorSetup.Delete(id);
                var returnedObj = _mapper.Map<ValueFactorSetupDTO>(res);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ValueFactorSetupDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ValueFactorSetup.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ValueFactorSetupDTO>>(result);
                return new ResponseModel<IEnumerable<ValueFactorSetupDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ValueFactorSetupDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorSetupDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ValueFactorSetup.FindById(id);
                var returnedObj = _mapper.Map<ValueFactorSetupDTO>(result);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorSetupDTO>> Update(ValueFactorSetupDTO entity)
        {
            try
            {
                var account = _mapper.Map<ValueFactorSetup>(entity);
                var updatedObject = await _repository.ValueFactorSetup.Update(account);
                var returnedObj = _mapper.Map<ValueFactorSetupDTO>(updatedObject);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorSetupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            