
using AutoMapper;
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SecuritySchema
{
    public class AcLogService : IAcLogService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AcLogService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AcLogDTO>> Create(AcLogDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AcLog>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AcLog.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AcLogDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AcLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AcLogDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AcLogDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AcLog.Delete(id);
                var returnedObj = _mapper.Map<AcLogDTO>(res);
                return new ResponseModel<AcLogDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AcLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AcLogDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AcLog.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AcLogDTO>>(result);
                return new ResponseModel<IEnumerable<AcLogDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AcLogDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AcLogDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AcLog.FindById(id);
                var returnedObj = _mapper.Map<AcLogDTO>(result);
                return new ResponseModel<AcLogDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AcLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AcLogDTO>> Update(AcLogDTO entity)
        {
            try
            {
                var account = _mapper.Map<AcLog>(entity);
                var updatedObject = await _repository.AcLog.Update(account);
                var returnedObj = _mapper.Map<AcLogDTO>(updatedObject);
                return new ResponseModel<AcLogDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AcLogDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            