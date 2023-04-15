
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
    public class FunctionalityService : IFunctionalityService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public FunctionalityService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<FunctionalityDTO>> Create(FunctionalityDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Functionality>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Functionality.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<FunctionalityDTO>(createdObj);
                
                //return response object

                return new ResponseModel<FunctionalityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FunctionalityDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FunctionalityDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Functionality.Delete(id);
                var returnedObj = _mapper.Map<FunctionalityDTO>(res);
                return new ResponseModel<FunctionalityDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FunctionalityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<FunctionalityDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Functionality.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<FunctionalityDTO>>(result);
                return new ResponseModel<IEnumerable<FunctionalityDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<FunctionalityDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FunctionalityDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Functionality.FindById(id);
                var returnedObj = _mapper.Map<FunctionalityDTO>(result);
                return new ResponseModel<FunctionalityDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FunctionalityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<FunctionalityDTO>> Update(FunctionalityDTO entity)
        {
            try
            {
                var account = _mapper.Map<Functionality>(entity);
                var updatedObject = await _repository.Functionality.Update(account);
                var returnedObj = _mapper.Map<FunctionalityDTO>(updatedObject);
                return new ResponseModel<FunctionalityDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<FunctionalityDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            