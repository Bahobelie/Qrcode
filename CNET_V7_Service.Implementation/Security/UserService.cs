
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
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public UserService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<UserDTO>> Create(UserDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<User>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.User.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<UserDTO>(createdObj);
                
                //return response object

                return new ResponseModel<UserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.User.Delete(id);
                var returnedObj = _mapper.Map<UserDTO>(res);
                return new ResponseModel<UserDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<UserDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.User.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<UserDTO>>(result);
                return new ResponseModel<IEnumerable<UserDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<UserDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.User.FindById(id);
                var returnedObj = _mapper.Map<UserDTO>(result);
                return new ResponseModel<UserDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<UserDTO>> Update(UserDTO entity)
        {
            try
            {
                var account = _mapper.Map<User>(entity);
                var updatedObject = await _repository.User.Update(account);
                var returnedObj = _mapper.Map<UserDTO>(updatedObject);
                return new ResponseModel<UserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<UserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            