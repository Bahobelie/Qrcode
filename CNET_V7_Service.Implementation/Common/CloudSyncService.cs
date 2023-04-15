
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
    public class CloudSyncService : ICloudSyncService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CloudSyncService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CloudSyncDTO>> Create(CloudSyncDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<CloudSync>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.CloudSync.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CloudSyncDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CloudSyncDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CloudSyncDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CloudSyncDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.CloudSync.Delete(id);
                var returnedObj = _mapper.Map<CloudSyncDTO>(res);
                return new ResponseModel<CloudSyncDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CloudSyncDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CloudSyncDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.CloudSync.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CloudSyncDTO>>(result);
                return new ResponseModel<IEnumerable<CloudSyncDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CloudSyncDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CloudSyncDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.CloudSync.FindById(id);
                var returnedObj = _mapper.Map<CloudSyncDTO>(result);
                return new ResponseModel<CloudSyncDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CloudSyncDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CloudSyncDTO>> Update(CloudSyncDTO entity)
        {
            try
            {
                var account = _mapper.Map<CloudSync>(entity);
                var updatedObject = await _repository.CloudSync.Update(account);
                var returnedObj = _mapper.Map<CloudSyncDTO>(updatedObject);
                return new ResponseModel<CloudSyncDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CloudSyncDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            