
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
    public class DenominationDetailService : IDenominationDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DenominationDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<DenominationDetailDTO>> Create(DenominationDetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<DenominationDetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.DenominationDetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<DenominationDetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<DenominationDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.DenominationDetail.Delete(id);
                var returnedObj = _mapper.Map<DenominationDetailDTO>(res);
                return new ResponseModel<DenominationDetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<DenominationDetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.DenominationDetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<DenominationDetailDTO>>(result);
                return new ResponseModel<IEnumerable<DenominationDetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<DenominationDetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.DenominationDetail.FindById(id);
                var returnedObj = _mapper.Map<DenominationDetailDTO>(result);
                return new ResponseModel<DenominationDetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<DenominationDetailDTO>> Update(DenominationDetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<DenominationDetail>(entity);
                var updatedObject = await _repository.DenominationDetail.Update(account);
                var returnedObj = _mapper.Map<DenominationDetailDTO>(updatedObject);
                return new ResponseModel<DenominationDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<DenominationDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            