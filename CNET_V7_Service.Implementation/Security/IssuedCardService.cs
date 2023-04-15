
using AutoMapper;
using CNET_V7_Domain.DataModels.SecuritySchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.SecuritySchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.SecuritySchema
{
    public class IssuedCardService : IIssuedCardService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public IssuedCardService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<IssuedCardDTO>> Create(IssuedCardDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<IssuedCard>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.IssuedCard.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<IssuedCardDTO>(createdObj);
                
                //return response object

                return new ResponseModel<IssuedCardDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IssuedCardDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IssuedCardDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.IssuedCard.Delete(id);
                var returnedObj = _mapper.Map<IssuedCardDTO>(res);
                return new ResponseModel<IssuedCardDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IssuedCardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<IssuedCardDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.IssuedCard.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<IssuedCardDTO>>(result);
                return new ResponseModel<IEnumerable<IssuedCardDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<IssuedCardDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IssuedCardDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.IssuedCard.FindById(id);
                var returnedObj = _mapper.Map<IssuedCardDTO>(result);
                return new ResponseModel<IssuedCardDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IssuedCardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IssuedCardDTO>> Update(IssuedCardDTO entity)
        {
            try
            {
                var account = _mapper.Map<IssuedCard>(entity);
                var updatedObject = await _repository.IssuedCard.Update(account);
                var returnedObj = _mapper.Map<IssuedCardDTO>(updatedObject);
                return new ResponseModel<IssuedCardDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IssuedCardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            