
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
    public class BlankFillService : IBlankFillService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public BlankFillService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<BlankFillDTO>> Create(BlankFillDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<BlankFill>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.BlankFill.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<BlankFillDTO>(createdObj);
                
                //return response object

                return new ResponseModel<BlankFillDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BlankFillDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BlankFillDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.BlankFill.Delete(id);
                var returnedObj = _mapper.Map<BlankFillDTO>(res);
                return new ResponseModel<BlankFillDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BlankFillDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<BlankFillDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.BlankFill.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<BlankFillDTO>>(result);
                return new ResponseModel<IEnumerable<BlankFillDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<BlankFillDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BlankFillDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.BlankFill.FindById(id);
                var returnedObj = _mapper.Map<BlankFillDTO>(result);
                return new ResponseModel<BlankFillDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BlankFillDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<BlankFillDTO>> Update(BlankFillDTO entity)
        {
            try
            {
                var account = _mapper.Map<BlankFill>(entity);
                var updatedObject = await _repository.BlankFill.Update(account);
                var returnedObj = _mapper.Map<BlankFillDTO>(updatedObject);
                return new ResponseModel<BlankFillDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<BlankFillDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            