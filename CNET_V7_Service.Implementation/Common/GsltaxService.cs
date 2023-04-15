
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
    public class GsltaxService : IGsltaxService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GsltaxService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<GsltaxDTO>> Create(GsltaxDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Gsltax>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Gsltax.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<GsltaxDTO>(createdObj);
                
                //return response object

                return new ResponseModel<GsltaxDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsltaxDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsltaxDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Gsltax.Delete(id);
                var returnedObj = _mapper.Map<GsltaxDTO>(res);
                return new ResponseModel<GsltaxDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsltaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<GsltaxDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Gsltax.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<GsltaxDTO>>(result);
                return new ResponseModel<IEnumerable<GsltaxDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<GsltaxDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsltaxDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Gsltax.FindById(id);
                var returnedObj = _mapper.Map<GsltaxDTO>(result);
                return new ResponseModel<GsltaxDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsltaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsltaxDTO>> Update(GsltaxDTO entity)
        {
            try
            {
                var account = _mapper.Map<Gsltax>(entity);
                var updatedObject = await _repository.Gsltax.Update(account);
                var returnedObj = _mapper.Map<GsltaxDTO>(updatedObject);
                return new ResponseModel<GsltaxDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsltaxDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            