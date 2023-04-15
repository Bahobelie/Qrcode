
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
    public class ObjectStateService : IObjectStateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ObjectStateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ObjectStateDTO>> Create(ObjectStateDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ObjectState>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ObjectState.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ObjectStateDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ObjectStateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ObjectState.Delete(id);
                var returnedObj = _mapper.Map<ObjectStateDTO>(res);
                return new ResponseModel<ObjectStateDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ObjectStateDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ObjectState.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ObjectStateDTO>>(result);
                return new ResponseModel<IEnumerable<ObjectStateDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ObjectStateDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ObjectState.FindById(id);
                var returnedObj = _mapper.Map<ObjectStateDTO>(result);
                return new ResponseModel<ObjectStateDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ObjectStateDTO>> Update(ObjectStateDTO entity)
        {
            try
            {
                var account = _mapper.Map<ObjectState>(entity);
                var updatedObject = await _repository.ObjectState.Update(account);
                var returnedObj = _mapper.Map<ObjectStateDTO>(updatedObject);
                return new ResponseModel<ObjectStateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ObjectStateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            