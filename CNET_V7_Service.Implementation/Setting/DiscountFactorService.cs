
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
    public class DiscountFactorService : IDiscountFactorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DiscountFactorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DiscountFactorDTO>> Create(DiscountFactorDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<DiscountFactor>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.DiscountFactor.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DiscountFactorDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DiscountFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DiscountFactorDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DiscountFactorDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.DiscountFactor.Delete(id);
                var returnedObj = _mapper.Map<DiscountFactorDTO>(res);
                return new ResponseModel<DiscountFactorDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DiscountFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DiscountFactorDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.DiscountFactor.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DiscountFactorDTO>>(result);
                return new ResponseModel<IEnumerable<DiscountFactorDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DiscountFactorDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DiscountFactorDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.DiscountFactor.FindById(id);
                var returnedObj = _mapper.Map<DiscountFactorDTO>(result);
                return new ResponseModel<DiscountFactorDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DiscountFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DiscountFactorDTO>> Update(DiscountFactorDTO entity)
        {
            try
            {
                var account = _mapper.Map<DiscountFactor>(entity);
                var updatedObject = await _repository.DiscountFactor.Update(account);
                var returnedObj = _mapper.Map<DiscountFactorDTO>(updatedObject);
                return new ResponseModel<DiscountFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DiscountFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            