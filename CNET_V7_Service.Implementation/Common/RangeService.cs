
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
    public class RangeService : IRangeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RangeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RangeDTO>> Create(RangeDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Range>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Range.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RangeDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RangeDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RangeDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RangeDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Range.Delete(id);
                var returnedObj = _mapper.Map<RangeDTO>(res);
                return new ResponseModel<RangeDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RangeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RangeDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Range.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RangeDTO>>(result);
                return new ResponseModel<IEnumerable<RangeDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RangeDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RangeDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Range.FindById(id);
                var returnedObj = _mapper.Map<RangeDTO>(result);
                return new ResponseModel<RangeDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RangeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RangeDTO>> Update(RangeDTO entity)
        {
            try
            {
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Range>(entity);
                var updatedObject = await _repository.Range.Update(account);
                var returnedObj = _mapper.Map<RangeDTO>(updatedObject);
                return new ResponseModel<RangeDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RangeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            