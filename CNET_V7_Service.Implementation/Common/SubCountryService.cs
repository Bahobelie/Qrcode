
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
    public class SubCountryService : ISubCountryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SubCountryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SubCountryDTO>> Create(SubCountryDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<SubCountry>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.SubCountry.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SubCountryDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SubCountryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubCountryDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubCountryDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.SubCountry.Delete(id);
                var returnedObj = _mapper.Map<SubCountryDTO>(res);
                return new ResponseModel<SubCountryDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubCountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SubCountryDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.SubCountry.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SubCountryDTO>>(result);
                return new ResponseModel<IEnumerable<SubCountryDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SubCountryDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubCountryDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.SubCountry.FindById(id);
                var returnedObj = _mapper.Map<SubCountryDTO>(result);
                return new ResponseModel<SubCountryDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubCountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubCountryDTO>> Update(SubCountryDTO entity)
        {
            try
            {
                var account = _mapper.Map<SubCountry>(entity);
                var updatedObject = await _repository.SubCountry.Update(account);
                var returnedObj = _mapper.Map<SubCountryDTO>(updatedObject);
                return new ResponseModel<SubCountryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubCountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            