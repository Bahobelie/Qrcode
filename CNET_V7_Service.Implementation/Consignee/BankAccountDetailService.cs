
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
    public class BankAccountDetailService : IBankAccountDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BankAccountDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<BankAccountDetailDTO>> Create(BankAccountDetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<BankAccountDetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.BankAccountDetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<BankAccountDetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<BankAccountDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BankAccountDetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BankAccountDetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.BankAccountDetail.Delete(id);
                var returnedObj = _mapper.Map<BankAccountDetailDTO>(res);
                return new ResponseModel<BankAccountDetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BankAccountDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<BankAccountDetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.BankAccountDetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<BankAccountDetailDTO>>(result);
                return new ResponseModel<IEnumerable<BankAccountDetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<BankAccountDetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BankAccountDetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.BankAccountDetail.FindById(id);
                var returnedObj = _mapper.Map<BankAccountDetailDTO>(result);
                return new ResponseModel<BankAccountDetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BankAccountDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BankAccountDetailDTO>> Update(BankAccountDetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<BankAccountDetail>(entity);
                var updatedObject = await _repository.BankAccountDetail.Update(account);
                var returnedObj = _mapper.Map<BankAccountDetailDTO>(updatedObject);
                return new ResponseModel<BankAccountDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BankAccountDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            