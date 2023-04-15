
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
    public class ControlAccountService : IControlAccountService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ControlAccountService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ControlAccountDTO>> Create(ControlAccountDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<ControlAccount>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.ControlAccount.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ControlAccountDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ControlAccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ControlAccountDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ControlAccountDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.ControlAccount.Delete(id);
                var returnedObj = _mapper.Map<ControlAccountDTO>(res);
                return new ResponseModel<ControlAccountDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ControlAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ControlAccountDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.ControlAccount.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ControlAccountDTO>>(result);
                return new ResponseModel<IEnumerable<ControlAccountDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ControlAccountDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ControlAccountDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.ControlAccount.FindById(id);
                var returnedObj = _mapper.Map<ControlAccountDTO>(result);
                return new ResponseModel<ControlAccountDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ControlAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ControlAccountDTO>> Update(ControlAccountDTO entity)
        {
            try
            {
                var account = _mapper.Map<ControlAccount>(entity);
                var updatedObject = await _repository.ControlAccount.Update(account);
                var returnedObj = _mapper.Map<ControlAccountDTO>(updatedObject);
                return new ResponseModel<ControlAccountDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ControlAccountDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            