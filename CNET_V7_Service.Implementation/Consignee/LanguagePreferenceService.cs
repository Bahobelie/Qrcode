
using AutoMapper;
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ConsigneeSchema
{
    public class LanguagePreferenceService : ILanguagePreferenceService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LanguagePreferenceService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<LanguagePreferenceDTO>> Create(LanguagePreferenceDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<LanguagePreference>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.LanguagePreference.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<LanguagePreferenceDTO>(createdObj);
                
                //return response object

                return new ResponseModel<LanguagePreferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguagePreferenceDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguagePreferenceDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.LanguagePreference.Delete(id);
                var returnedObj = _mapper.Map<LanguagePreferenceDTO>(res);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<LanguagePreferenceDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.LanguagePreference.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<LanguagePreferenceDTO>>(result);
                return new ResponseModel<IEnumerable<LanguagePreferenceDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<LanguagePreferenceDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguagePreferenceDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.LanguagePreference.FindById(id);
                var returnedObj = _mapper.Map<LanguagePreferenceDTO>(result);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguagePreferenceDTO>> Update(LanguagePreferenceDTO entity)
        {
            try
            {
                var account = _mapper.Map<LanguagePreference>(entity);
                var updatedObject = await _repository.LanguagePreference.Update(account);
                var returnedObj = _mapper.Map<LanguagePreferenceDTO>(updatedObject);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguagePreferenceDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            