
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
    public class ActivityService : IActivityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ActivityService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ActivityDTO>> Create(ActivityDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Activity>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Activity.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ActivityDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ActivityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Activity.Delete(id);
                var returnedObj = _mapper.Map<ActivityDTO>(res);
                return new ResponseModel<ActivityDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ActivityDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Activity.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ActivityDTO>>(result);
                return new ResponseModel<IEnumerable<ActivityDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ActivityDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Activity.FindById(id);
                var returnedObj = _mapper.Map<ActivityDTO>(result);
                return new ResponseModel<ActivityDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ActivityDTO>> Update(ActivityDTO entity)
        {
            try
            {
                var account = _mapper.Map<Activity>(entity);
                var updatedObject = await _repository.Activity.Update(account);
                var returnedObj = _mapper.Map<ActivityDTO>(updatedObject);
                return new ResponseModel<ActivityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            