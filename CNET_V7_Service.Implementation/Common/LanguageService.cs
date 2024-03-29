
using AutoMapper;
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.CommonSchema
{
    public class LanguageService : ILanguageService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LanguageService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<LanguageDTO>> Create(LanguageDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Language>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Language.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<LanguageDTO>(createdObj);
                
                //return response object

                return new ResponseModel<LanguageDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguageDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguageDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Language.Delete(id);
                var returnedObj = _mapper.Map<LanguageDTO>(res);
                return new ResponseModel<LanguageDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguageDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<LanguageDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Language.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<LanguageDTO>>(result);
                return new ResponseModel<IEnumerable<LanguageDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<LanguageDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguageDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Language.FindById(id);
                var returnedObj = _mapper.Map<LanguageDTO>(result);
                return new ResponseModel<LanguageDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguageDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LanguageDTO>> Update(LanguageDTO entity)
        {
            try
            {
                var account = _mapper.Map<Language>(entity);
                var updatedObject = await _repository.Language.Update(account);
                var returnedObj = _mapper.Map<LanguageDTO>(updatedObject);
                return new ResponseModel<LanguageDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LanguageDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            