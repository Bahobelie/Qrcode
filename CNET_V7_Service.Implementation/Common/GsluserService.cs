
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
    public class GsluserService : IGsluserService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GsluserService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<GsluserDTO>> Create(GsluserDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Gsluser>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Gsluser.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<GsluserDTO>(createdObj);
                
                //return response object

                return new ResponseModel<GsluserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsluserDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsluserDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Gsluser.Delete(id);
                var returnedObj = _mapper.Map<GsluserDTO>(res);
                return new ResponseModel<GsluserDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsluserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<GsluserDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Gsluser.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<GsluserDTO>>(result);
                return new ResponseModel<IEnumerable<GsluserDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<GsluserDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsluserDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Gsluser.FindById(id);
                var returnedObj = _mapper.Map<GsluserDTO>(result);
                return new ResponseModel<GsluserDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsluserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GsluserDTO>> Update(GsluserDTO entity)
        {
            try
            {
                var account = _mapper.Map<Gsluser>(entity);
                var updatedObject = await _repository.Gsluser.Update(account);
                var returnedObj = _mapper.Map<GsluserDTO>(updatedObject);
                return new ResponseModel<GsluserDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GsluserDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            