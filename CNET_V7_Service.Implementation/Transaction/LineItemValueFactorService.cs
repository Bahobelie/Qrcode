
using AutoMapper;
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.TransactionSchema
{
    public class LineItemValueFactorService : ILineItemValueFactorService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LineItemValueFactorService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<LineItemValueFactorDTO>> Create(LineItemValueFactorDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<LineItemValueFactor>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.LineItemValueFactor.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<LineItemValueFactorDTO>(createdObj);
                
                //return response object

                return new ResponseModel<LineItemValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemValueFactorDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemValueFactorDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.LineItemValueFactor.Delete(id);
                var returnedObj = _mapper.Map<LineItemValueFactorDTO>(res);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<LineItemValueFactorDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.LineItemValueFactor.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<LineItemValueFactorDTO>>(result);
                return new ResponseModel<IEnumerable<LineItemValueFactorDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<LineItemValueFactorDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemValueFactorDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.LineItemValueFactor.FindById(id);
                var returnedObj = _mapper.Map<LineItemValueFactorDTO>(result);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LineItemValueFactorDTO>> Update(LineItemValueFactorDTO entity)
        {
            try
            {
                var account = _mapper.Map<LineItemValueFactor>(entity);
                var updatedObject = await _repository.LineItemValueFactor.Update(account);
                var returnedObj = _mapper.Map<LineItemValueFactorDTO>(updatedObject);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LineItemValueFactorDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            