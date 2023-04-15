
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
    public class ScheduleHeaderService : IScheduleHeaderService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ScheduleHeaderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ScheduleHeaderDTO>> Create(ScheduleHeaderDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ScheduleHeader>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ScheduleHeader.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ScheduleHeaderDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ScheduleHeaderDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleHeaderDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleHeaderDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ScheduleHeader.Delete(id);
                var returnedObj = _mapper.Map<ScheduleHeaderDTO>(res);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ScheduleHeaderDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ScheduleHeader.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ScheduleHeaderDTO>>(result);
                return new ResponseModel<IEnumerable<ScheduleHeaderDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ScheduleHeaderDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleHeaderDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ScheduleHeader.FindById(id);
                var returnedObj = _mapper.Map<ScheduleHeaderDTO>(result);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ScheduleHeaderDTO>> Update(ScheduleHeaderDTO entity)
        {
            try
            {
                var account = _mapper.Map<ScheduleHeader>(entity);
                var updatedObject = await _repository.ScheduleHeader.Update(account);
                var returnedObj = _mapper.Map<ScheduleHeaderDTO>(updatedObject);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ScheduleHeaderDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            