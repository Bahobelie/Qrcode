
using AutoMapper;
using CNET_V7_Domain.DataModels.SettingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SettingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SettingSchema
{
    public class RequiredGslService : IRequiredGslService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequiredGslService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RequiredGslDTO>> Create(RequiredGslDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<RequiredGsl>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.RequiredGsl.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RequiredGslDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RequiredGslDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGslDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGslDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.RequiredGsl.Delete(id);
                var returnedObj = _mapper.Map<RequiredGslDTO>(res);
                return new ResponseModel<RequiredGslDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGslDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RequiredGslDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.RequiredGsl.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RequiredGslDTO>>(result);
                return new ResponseModel<IEnumerable<RequiredGslDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RequiredGslDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGslDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.RequiredGsl.FindById(id);
                var returnedObj = _mapper.Map<RequiredGslDTO>(result);
                return new ResponseModel<RequiredGslDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGslDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGslDTO>> Update(RequiredGslDTO entity)
        {
            try
            {
                var account = _mapper.Map<RequiredGsl>(entity);
                var updatedObject = await _repository.RequiredGsl.Update(account);
                var returnedObj = _mapper.Map<RequiredGslDTO>(updatedObject);
                return new ResponseModel<RequiredGslDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGslDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            