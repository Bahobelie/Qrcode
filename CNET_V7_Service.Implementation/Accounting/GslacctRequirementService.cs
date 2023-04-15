
using AutoMapper;
using CNET_V7_Domain.DataModels.AccountingSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.AccountingSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.AccountingSchema
{
    public class GslacctRequirementService : IGslacctRequirementService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public GslacctRequirementService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<GslacctRequirementDTO>> Create(GslacctRequirementDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<GslacctRequirement>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.GslacctRequirement.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<GslacctRequirementDTO>(createdObj);
                
                //return response object

                return new ResponseModel<GslacctRequirementDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GslacctRequirementDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GslacctRequirementDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.GslacctRequirement.Delete(id);
                var returnedObj = _mapper.Map<GslacctRequirementDTO>(res);
                return new ResponseModel<GslacctRequirementDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GslacctRequirementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<GslacctRequirementDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.GslacctRequirement.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<GslacctRequirementDTO>>(result);
                return new ResponseModel<IEnumerable<GslacctRequirementDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<GslacctRequirementDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GslacctRequirementDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.GslacctRequirement.FindById(id);
                var returnedObj = _mapper.Map<GslacctRequirementDTO>(result);
                return new ResponseModel<GslacctRequirementDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GslacctRequirementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<GslacctRequirementDTO>> Update(GslacctRequirementDTO entity)
        {
            try
            {
                var account = _mapper.Map<GslacctRequirement>(entity);
                var updatedObject = await _repository.GslacctRequirement.Update(account);
                var returnedObj = _mapper.Map<GslacctRequirementDTO>(updatedObject);
                return new ResponseModel<GslacctRequirementDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<GslacctRequirementDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            