
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
    public class CnetmediumService : ICnetmediumService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CnetmediumService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CnetmediumDTO>> Create(CnetmediumDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Cnetmedium>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Cnetmedium.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CnetmediumDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CnetmediumDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetmediumDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetmediumDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Cnetmedium.Delete(id);
                var returnedObj = _mapper.Map<CnetmediumDTO>(res);
                return new ResponseModel<CnetmediumDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetmediumDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CnetmediumDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Cnetmedium.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CnetmediumDTO>>(result);
                return new ResponseModel<IEnumerable<CnetmediumDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CnetmediumDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetmediumDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Cnetmedium.FindById(id);
                var returnedObj = _mapper.Map<CnetmediumDTO>(result);
                return new ResponseModel<CnetmediumDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetmediumDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CnetmediumDTO>> Update(CnetmediumDTO entity)
        {
            try
            {
                var account = _mapper.Map<Cnetmedium>(entity);
                var updatedObject = await _repository.Cnetmedium.Update(account);
                var returnedObj = _mapper.Map<CnetmediumDTO>(updatedObject);
                return new ResponseModel<CnetmediumDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CnetmediumDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            