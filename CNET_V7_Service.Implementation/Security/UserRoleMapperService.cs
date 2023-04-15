
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
    public class UserRoleMapperService : IUserRoleMapperService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserRoleMapperService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<UserRoleMapperDTO>> Create(UserRoleMapperDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<UserRoleMapper>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.UserRoleMapper.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<UserRoleMapperDTO>(createdObj);
                
                //return response object

                return new ResponseModel<UserRoleMapperDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserRoleMapperDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserRoleMapperDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.UserRoleMapper.Delete(id);
                var returnedObj = _mapper.Map<UserRoleMapperDTO>(res);
                return new ResponseModel<UserRoleMapperDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserRoleMapperDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<UserRoleMapperDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.UserRoleMapper.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<UserRoleMapperDTO>>(result);
                return new ResponseModel<IEnumerable<UserRoleMapperDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<UserRoleMapperDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserRoleMapperDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.UserRoleMapper.FindById(id);
                var returnedObj = _mapper.Map<UserRoleMapperDTO>(result);
                return new ResponseModel<UserRoleMapperDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserRoleMapperDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserRoleMapperDTO>> Update(UserRoleMapperDTO entity)
        {
            try
            {
                var account = _mapper.Map<UserRoleMapper>(entity);
                var updatedObject = await _repository.UserRoleMapper.Update(account);
                var returnedObj = _mapper.Map<UserRoleMapperDTO>(updatedObject);
                return new ResponseModel<UserRoleMapperDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserRoleMapperDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            