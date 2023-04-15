
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
    public class ExchangeRateService : IExchangeRateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ExchangeRateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ExchangeRateDTO>> Create(ExchangeRateDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ExchangeRate>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ExchangeRate.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ExchangeRateDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ExchangeRateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ExchangeRateDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ExchangeRateDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ExchangeRate.Delete(id);
                var returnedObj = _mapper.Map<ExchangeRateDTO>(res);
                return new ResponseModel<ExchangeRateDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ExchangeRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ExchangeRateDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ExchangeRate.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ExchangeRateDTO>>(result);
                return new ResponseModel<IEnumerable<ExchangeRateDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ExchangeRateDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ExchangeRateDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ExchangeRate.FindById(id);
                var returnedObj = _mapper.Map<ExchangeRateDTO>(result);
                return new ResponseModel<ExchangeRateDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ExchangeRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ExchangeRateDTO>> Update(ExchangeRateDTO entity)
        {
            try
            {
                var account = _mapper.Map<ExchangeRate>(entity);
                var updatedObject = await _repository.ExchangeRate.Update(account);
                var returnedObj = _mapper.Map<ExchangeRateDTO>(updatedObject);
                return new ResponseModel<ExchangeRateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ExchangeRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            