
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
    public class CountryService : ICountryService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CountryService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CountryDTO>> Create(CountryDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Country>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Country.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CountryDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CountryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CountryDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CountryDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Country.Delete(id);
                var returnedObj = _mapper.Map<CountryDTO>(res);
                return new ResponseModel<CountryDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CountryDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Country.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CountryDTO>>(result);
                return new ResponseModel<IEnumerable<CountryDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CountryDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CountryDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Country.FindById(id);
                var returnedObj = _mapper.Map<CountryDTO>(result);
                return new ResponseModel<CountryDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CountryDTO>> Update(CountryDTO entity)
        {
            try
            {
                var account = _mapper.Map<Country>(entity);
                var updatedObject = await _repository.Country.Update(account);
                var returnedObj = _mapper.Map<CountryDTO>(updatedObject);
                return new ResponseModel<CountryDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CountryDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            