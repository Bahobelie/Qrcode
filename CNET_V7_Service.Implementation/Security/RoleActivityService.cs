
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
    public class RoleActivityService : IRoleActivityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RoleActivityService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RoleActivityDTO>> Create(RoleActivityDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<RoleActivity>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.RoleActivity.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RoleActivityDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RoleActivityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RoleActivityDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RoleActivityDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.RoleActivity.Delete(id);
                var returnedObj = _mapper.Map<RoleActivityDTO>(res);
                return new ResponseModel<RoleActivityDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RoleActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RoleActivityDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.RoleActivity.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RoleActivityDTO>>(result);
                return new ResponseModel<IEnumerable<RoleActivityDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RoleActivityDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RoleActivityDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.RoleActivity.FindById(id);
                var returnedObj = _mapper.Map<RoleActivityDTO>(result);
                return new ResponseModel<RoleActivityDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RoleActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RoleActivityDTO>> Update(RoleActivityDTO entity)
        {
            try
            {
                var account = _mapper.Map<RoleActivity>(entity);
                var updatedObject = await _repository.RoleActivity.Update(account);
                var returnedObj = _mapper.Map<RoleActivityDTO>(updatedObject);
                return new ResponseModel<RoleActivityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RoleActivityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            