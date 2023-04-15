
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
    public class RequiredGsldetailService : IRequiredGsldetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RequiredGsldetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RequiredGsldetailDTO>> Create(RequiredGsldetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<RequiredGsldetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.RequiredGsldetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RequiredGsldetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RequiredGsldetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGsldetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGsldetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.RequiredGsldetail.Delete(id);
                var returnedObj = _mapper.Map<RequiredGsldetailDTO>(res);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RequiredGsldetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.RequiredGsldetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RequiredGsldetailDTO>>(result);
                return new ResponseModel<IEnumerable<RequiredGsldetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RequiredGsldetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGsldetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.RequiredGsldetail.FindById(id);
                var returnedObj = _mapper.Map<RequiredGsldetailDTO>(result);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RequiredGsldetailDTO>> Update(RequiredGsldetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<RequiredGsldetail>(entity);
                var updatedObject = await _repository.RequiredGsldetail.Update(account);
                var returnedObj = _mapper.Map<RequiredGsldetailDTO>(updatedObject);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RequiredGsldetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            