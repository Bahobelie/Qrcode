
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
    public class ValueFactorService : IValueFactorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ValueFactorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ValueFactorDTO>> Create(ValueFactorDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ValueFactor>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ValueFactor.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ValueFactorDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ValueFactor.Delete(id);
                var returnedObj = _mapper.Map<ValueFactorDTO>(res);
                return new ResponseModel<ValueFactorDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ValueFactorDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ValueFactor.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ValueFactorDTO>>(result);
                return new ResponseModel<IEnumerable<ValueFactorDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ValueFactorDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ValueFactor.FindById(id);
                var returnedObj = _mapper.Map<ValueFactorDTO>(result);
                return new ResponseModel<ValueFactorDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ValueFactorDTO>> Update(ValueFactorDTO entity)
        {
            try
            {
                var account = _mapper.Map<ValueFactor>(entity);
                var updatedObject = await _repository.ValueFactor.Update(account);
                var returnedObj = _mapper.Map<ValueFactorDTO>(updatedObject);
                return new ResponseModel<ValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            