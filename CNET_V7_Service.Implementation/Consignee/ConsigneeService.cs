
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
    public class ConsigneeService : IConsigneeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ConsigneeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ConsigneeDTO>> Create(ConsigneeDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Consignee>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Consignee.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ConsigneeDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ConsigneeDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Consignee.Delete(id);
                var returnedObj = _mapper.Map<ConsigneeDTO>(res);
                return new ResponseModel<ConsigneeDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ConsigneeDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Consignee.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ConsigneeDTO>>(result);
                return new ResponseModel<IEnumerable<ConsigneeDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ConsigneeDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Consignee.FindById(id);
                var returnedObj = _mapper.Map<ConsigneeDTO>(result);
                return new ResponseModel<ConsigneeDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeDTO>> Update(ConsigneeDTO entity)
        {
            try
            {
                var account = _mapper.Map<Consignee>(entity);
                var updatedObject = await _repository.Consignee.Update(account);
                var returnedObj = _mapper.Map<ConsigneeDTO>(updatedObject);
                return new ResponseModel<ConsigneeDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            