
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
    public class PreferenceAccessService : IPreferenceAccessService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PreferenceAccessService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PreferenceAccessDTO>> Create(PreferenceAccessDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<PreferenceAccess>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.PreferenceAccess.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<PreferenceAccessDTO>(createdObj);
                
                //return response object

                return new ResponseModel<PreferenceAccessDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceAccessDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceAccessDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.PreferenceAccess.Delete(id);
                var returnedObj = _mapper.Map<PreferenceAccessDTO>(res);
                return new ResponseModel<PreferenceAccessDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceAccessDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<PreferenceAccessDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.PreferenceAccess.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<PreferenceAccessDTO>>(result);
                return new ResponseModel<IEnumerable<PreferenceAccessDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<PreferenceAccessDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceAccessDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.PreferenceAccess.FindById(id);
                var returnedObj = _mapper.Map<PreferenceAccessDTO>(result);
                return new ResponseModel<PreferenceAccessDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceAccessDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceAccessDTO>> Update(PreferenceAccessDTO entity)
        {
            try
            {
                var account = _mapper.Map<PreferenceAccess>(entity);
                var updatedObject = await _repository.PreferenceAccess.Update(account);
                var returnedObj = _mapper.Map<PreferenceAccessDTO>(updatedObject);
                return new ResponseModel<PreferenceAccessDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceAccessDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            