
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
    public class CardService : ICardService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CardService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<CardDTO>> Create(CardDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Card>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Card.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<CardDTO>(createdObj);
                
                //return response object

                return new ResponseModel<CardDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CardDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CardDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Card.Delete(id);
                var returnedObj = _mapper.Map<CardDTO>(res);
                return new ResponseModel<CardDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<CardDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Card.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<CardDTO>>(result);
                return new ResponseModel<IEnumerable<CardDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<CardDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CardDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Card.FindById(id);
                var returnedObj = _mapper.Map<CardDTO>(result);
                return new ResponseModel<CardDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<CardDTO>> Update(CardDTO entity)
        {
            try
            {
                var account = _mapper.Map<Card>(entity);
                var updatedObject = await _repository.Card.Update(account);
                var returnedObj = _mapper.Map<CardDTO>(updatedObject);
                return new ResponseModel<CardDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<CardDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            