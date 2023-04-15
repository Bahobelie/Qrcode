
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
    public class RelationService : IRelationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public RelationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<RelationDTO>> Create(RelationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Relation>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Relation.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<RelationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<RelationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Relation.Delete(id);
                var returnedObj = _mapper.Map<RelationDTO>(res);
                return new ResponseModel<RelationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<RelationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Relation.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<RelationDTO>>(result);
                return new ResponseModel<IEnumerable<RelationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<RelationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Relation.FindById(id);
                var returnedObj = _mapper.Map<RelationDTO>(result);
                return new ResponseModel<RelationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<RelationDTO>> Update(RelationDTO entity)
        {
            try
            {
                var account = _mapper.Map<Relation>(entity);
                var updatedObject = await _repository.Relation.Update(account);
                var returnedObj = _mapper.Map<RelationDTO>(updatedObject);
                return new ResponseModel<RelationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<RelationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            