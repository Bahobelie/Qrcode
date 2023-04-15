
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
    public class LookupService : ILookupService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public LookupService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<LookupDTO>> Create(LookupDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Lookup>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Lookup.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<LookupDTO>(createdObj);
                
                //return response object

                return new ResponseModel<LookupDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LookupDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LookupDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Lookup.Delete(id);
                var returnedObj = _mapper.Map<LookupDTO>(res);
                return new ResponseModel<LookupDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LookupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<LookupDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Lookup.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<LookupDTO>>(result);
                return new ResponseModel<IEnumerable<LookupDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<LookupDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LookupDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Lookup.FindById(id);
                var returnedObj = _mapper.Map<LookupDTO>(result);
                return new ResponseModel<LookupDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LookupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<LookupDTO>> Update(LookupDTO entity)
        {
            try
            {
                var account = _mapper.Map<Lookup>(entity);
                var updatedObject = await _repository.Lookup.Update(account);
                var returnedObj = _mapper.Map<LookupDTO>(updatedObject);
                return new ResponseModel<LookupDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<LookupDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            