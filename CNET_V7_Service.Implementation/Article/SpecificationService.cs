
using AutoMapper;
using CNET_V7_Domain.DataModels.ArticleSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ArticleSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ArticleSchema
{
    public class SpecificationService : ISpecificationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SpecificationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SpecificationDTO>> Create(SpecificationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Specification>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Specification.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SpecificationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SpecificationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpecificationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpecificationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Specification.Delete(id);
                var returnedObj = _mapper.Map<SpecificationDTO>(res);
                return new ResponseModel<SpecificationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpecificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SpecificationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Specification.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SpecificationDTO>>(result);
                return new ResponseModel<IEnumerable<SpecificationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SpecificationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpecificationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Specification.FindById(id);
                var returnedObj = _mapper.Map<SpecificationDTO>(result);
                return new ResponseModel<SpecificationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpecificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SpecificationDTO>> Update(SpecificationDTO entity)
        {
            try
            {
                var account = _mapper.Map<Specification>(entity);
                var updatedObject = await _repository.Specification.Update(account);
                var returnedObj = _mapper.Map<SpecificationDTO>(updatedObject);
                return new ResponseModel<SpecificationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SpecificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            