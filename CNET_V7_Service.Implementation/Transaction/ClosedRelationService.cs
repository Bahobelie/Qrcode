
using AutoMapper;
using CNET_V7_Domain.DataModels.TransactionSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.TransactionSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.TransactionSchema
{
    public class ClosedRelationService : IClosedRelationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ClosedRelationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ClosedRelationDTO>> Create(ClosedRelationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ClosedRelation>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ClosedRelation.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ClosedRelationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ClosedRelationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ClosedRelationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ClosedRelationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ClosedRelation.Delete(id);
                var returnedObj = _mapper.Map<ClosedRelationDTO>(res);
                return new ResponseModel<ClosedRelationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ClosedRelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ClosedRelationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ClosedRelation.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ClosedRelationDTO>>(result);
                return new ResponseModel<IEnumerable<ClosedRelationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ClosedRelationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ClosedRelationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ClosedRelation.FindById(id);
                var returnedObj = _mapper.Map<ClosedRelationDTO>(result);
                return new ResponseModel<ClosedRelationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ClosedRelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ClosedRelationDTO>> Update(ClosedRelationDTO entity)
        {
            try
            {
                var account = _mapper.Map<ClosedRelation>(entity);
                var updatedObject = await _repository.ClosedRelation.Update(account);
                var returnedObj = _mapper.Map<ClosedRelationDTO>(updatedObject);
                return new ResponseModel<ClosedRelationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ClosedRelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            