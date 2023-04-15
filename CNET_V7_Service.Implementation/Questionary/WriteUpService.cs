
using AutoMapper;
using CNET_V7_Domain.DataModels.QuestionarySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.QuestionarySchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.QuestionarySchema
{
    public class WriteUpService : IWriteUpService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public WriteUpService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<WriteUpDTO>> Create(WriteUpDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<WriteUp>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.WriteUp.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<WriteUpDTO>(createdObj);
                
                //return response object

                return new ResponseModel<WriteUpDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<WriteUpDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<WriteUpDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.WriteUp.Delete(id);
                var returnedObj = _mapper.Map<WriteUpDTO>(res);
                return new ResponseModel<WriteUpDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<WriteUpDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<WriteUpDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.WriteUp.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<WriteUpDTO>>(result);
                return new ResponseModel<IEnumerable<WriteUpDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<WriteUpDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<WriteUpDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.WriteUp.FindById(id);
                var returnedObj = _mapper.Map<WriteUpDTO>(result);
                return new ResponseModel<WriteUpDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<WriteUpDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<WriteUpDTO>> Update(WriteUpDTO entity)
        {
            try
            {
                var account = _mapper.Map<WriteUp>(entity);
                var updatedObject = await _repository.WriteUp.Update(account);
                var returnedObj = _mapper.Map<WriteUpDTO>(updatedObject);
                return new ResponseModel<WriteUpDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<WriteUpDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            