
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
    public class AnswerSheetService : IAnswerSheetService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AnswerSheetService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AnswerSheetDTO>> Create(AnswerSheetDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<AnswerSheet>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.AnswerSheet.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AnswerSheetDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AnswerSheetDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerSheetDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerSheetDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.AnswerSheet.Delete(id);
                var returnedObj = _mapper.Map<AnswerSheetDTO>(res);
                return new ResponseModel<AnswerSheetDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AnswerSheetDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.AnswerSheet.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AnswerSheetDTO>>(result);
                return new ResponseModel<IEnumerable<AnswerSheetDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AnswerSheetDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerSheetDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.AnswerSheet.FindById(id);
                var returnedObj = _mapper.Map<AnswerSheetDTO>(result);
                return new ResponseModel<AnswerSheetDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AnswerSheetDTO>> Update(AnswerSheetDTO entity)
        {
            try
            {
                var account = _mapper.Map<AnswerSheet>(entity);
                var updatedObject = await _repository.AnswerSheet.Update(account);
                var returnedObj = _mapper.Map<AnswerSheetDTO>(updatedObject);
                return new ResponseModel<AnswerSheetDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AnswerSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            