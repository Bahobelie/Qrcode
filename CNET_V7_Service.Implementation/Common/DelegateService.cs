
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
    public class DelegateService : IDelegateService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DelegateService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DelegateDTO>> Create(DelegateDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Delegate>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Delegate.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DelegateDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DelegateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DelegateDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DelegateDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Delegate.Delete(id);
                var returnedObj = _mapper.Map<DelegateDTO>(res);
                return new ResponseModel<DelegateDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DelegateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DelegateDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Delegate.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DelegateDTO>>(result);
                return new ResponseModel<IEnumerable<DelegateDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DelegateDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DelegateDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Delegate.FindById(id);
                var returnedObj = _mapper.Map<DelegateDTO>(result);
                return new ResponseModel<DelegateDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DelegateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DelegateDTO>> Update(DelegateDTO entity)
        {
            try
            {
                var account = _mapper.Map<CNET_V7_Entities.DataModels.Delegate>(entity);
                var updatedObject = await _repository.Delegate.Update(account);
                var returnedObj = _mapper.Map<DelegateDTO>(updatedObject);
                return new ResponseModel<DelegateDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DelegateDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            