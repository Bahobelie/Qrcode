
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
    public class PreferenceService : IPreferenceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public PreferenceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<PreferenceDTO>> Create(PreferenceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Preference>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Preference.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<PreferenceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<PreferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Preference.Delete(id);
                var returnedObj = _mapper.Map<PreferenceDTO>(res);
                return new ResponseModel<PreferenceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<PreferenceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Preference.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<PreferenceDTO>>(result);
                return new ResponseModel<IEnumerable<PreferenceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<PreferenceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Preference.FindById(id);
                var returnedObj = _mapper.Map<PreferenceDTO>(result);
                return new ResponseModel<PreferenceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<PreferenceDTO>> Update(PreferenceDTO entity)
        {
            try
            {
                var account = _mapper.Map<Preference>(entity);
                var updatedObject = await _repository.Preference.Update(account);
                var returnedObj = _mapper.Map<PreferenceDTO>(updatedObject);
                return new ResponseModel<PreferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<PreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            