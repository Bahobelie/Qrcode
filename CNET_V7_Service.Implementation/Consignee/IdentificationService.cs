
using AutoMapper;
using CNET_V7_Domain.DataModels.ConsigneeSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.ConsigneeSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.ConsigneeSchema
{
    public class IdentificationService : IIdentificationService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public IdentificationService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IdentificationDTO>> Create(IdentificationDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Identification>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Identification.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<IdentificationDTO>(createdObj);
                
                //return response object

                return new ResponseModel<IdentificationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdentificationDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdentificationDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Identification.Delete(id);
                var returnedObj = _mapper.Map<IdentificationDTO>(res);
                return new ResponseModel<IdentificationDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdentificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<IdentificationDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Identification.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<IdentificationDTO>>(result);
                return new ResponseModel<IEnumerable<IdentificationDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<IdentificationDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdentificationDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Identification.FindById(id);
                var returnedObj = _mapper.Map<IdentificationDTO>(result);
                return new ResponseModel<IdentificationDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdentificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IdentificationDTO>> Update(IdentificationDTO entity)
        {
            try
            {
                var account = _mapper.Map<Identification>(entity);
                var updatedObject = await _repository.Identification.Update(account);
                var returnedObj = _mapper.Map<IdentificationDTO>(updatedObject);
                return new ResponseModel<IdentificationDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IdentificationDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            