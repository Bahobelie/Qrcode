
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
    public class ConsigneeUnitService : IConsigneeUnitService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ConsigneeUnitService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ConsigneeUnitDTO>> Create(ConsigneeUnitDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ConsigneeUnit>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ConsigneeUnit.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ConsigneeUnitDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ConsigneeUnitDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeUnitDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeUnitDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ConsigneeUnit.Delete(id);
                var returnedObj = _mapper.Map<ConsigneeUnitDTO>(res);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ConsigneeUnitDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ConsigneeUnit.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ConsigneeUnitDTO>>(result);
                return new ResponseModel<IEnumerable<ConsigneeUnitDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ConsigneeUnitDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeUnitDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ConsigneeUnit.FindById(id);
                var returnedObj = _mapper.Map<ConsigneeUnitDTO>(result);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ConsigneeUnitDTO>> Update(ConsigneeUnitDTO entity)
        {
            try
            {
                var account = _mapper.Map<ConsigneeUnit>(entity);
                var updatedObject = await _repository.ConsigneeUnit.Update(account);
                var returnedObj = _mapper.Map<ConsigneeUnitDTO>(updatedObject);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ConsigneeUnitDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            