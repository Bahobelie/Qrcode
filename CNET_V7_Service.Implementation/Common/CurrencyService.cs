
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
    public class CurrencyService : ICurrencyService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CurrencyService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CurrencyDTO>> Create(CurrencyDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Currency>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Currency.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CurrencyDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CurrencyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CurrencyDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CurrencyDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Currency.Delete(id);
                var returnedObj = _mapper.Map<CurrencyDTO>(res);
                return new ResponseModel<CurrencyDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CurrencyDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Currency.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CurrencyDTO>>(result);
                return new ResponseModel<IEnumerable<CurrencyDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CurrencyDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CurrencyDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Currency.FindById(id);
                var returnedObj = _mapper.Map<CurrencyDTO>(result);
                return new ResponseModel<CurrencyDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CurrencyDTO>> Update(CurrencyDTO entity)
        {
            try
            {
                var account = _mapper.Map<Currency>(entity);
                var updatedObject = await _repository.Currency.Update(account);
                var returnedObj = _mapper.Map<CurrencyDTO>(updatedObject);
                return new ResponseModel<CurrencyDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CurrencyDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            