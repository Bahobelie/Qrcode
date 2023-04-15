
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
    public class ProgressTaxRateService : IProgressTaxRateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ProgressTaxRateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ProgressTaxRateDTO>> Create(ProgressTaxRateDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ProgressTaxRate>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ProgressTaxRate.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ProgressTaxRateDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ProgressTaxRateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ProgressTaxRateDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ProgressTaxRateDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ProgressTaxRate.Delete(id);
                var returnedObj = _mapper.Map<ProgressTaxRateDTO>(res);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ProgressTaxRateDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ProgressTaxRate.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ProgressTaxRateDTO>>(result);
                return new ResponseModel<IEnumerable<ProgressTaxRateDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ProgressTaxRateDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ProgressTaxRateDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ProgressTaxRate.FindById(id);
                var returnedObj = _mapper.Map<ProgressTaxRateDTO>(result);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ProgressTaxRateDTO>> Update(ProgressTaxRateDTO entity)
        {
            try
            {
                var account = _mapper.Map<ProgressTaxRate>(entity);
                var updatedObject = await _repository.ProgressTaxRate.Update(account);
                var returnedObj = _mapper.Map<ProgressTaxRateDTO>(updatedObject);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ProgressTaxRateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            