
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
    public class JournalDetailService : IJournalDetailService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public JournalDetailService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<JournalDetailDTO>> Create(JournalDetailDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<JournalDetail>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.JournalDetail.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<JournalDetailDTO>(createdObj);
                
                //return response object

                return new ResponseModel<JournalDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<JournalDetailDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<JournalDetailDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.JournalDetail.Delete(id);
                var returnedObj = _mapper.Map<JournalDetailDTO>(res);
                return new ResponseModel<JournalDetailDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<JournalDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<JournalDetailDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.JournalDetail.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<JournalDetailDTO>>(result);
                return new ResponseModel<IEnumerable<JournalDetailDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<JournalDetailDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<JournalDetailDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.JournalDetail.FindById(id);
                var returnedObj = _mapper.Map<JournalDetailDTO>(result);
                return new ResponseModel<JournalDetailDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<JournalDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<JournalDetailDTO>> Update(JournalDetailDTO entity)
        {
            try
            {
                var account = _mapper.Map<JournalDetail>(entity);
                var updatedObject = await _repository.JournalDetail.Update(account);
                var returnedObj = _mapper.Map<JournalDetailDTO>(updatedObject);
                return new ResponseModel<JournalDetailDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<JournalDetailDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            