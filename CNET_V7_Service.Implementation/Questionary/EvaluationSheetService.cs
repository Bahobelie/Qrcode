
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
    public class EvaluationSheetService : IEvaluationSheetService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public EvaluationSheetService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<EvaluationSheetDTO>> Create(EvaluationSheetDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<EvaluationSheet>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.EvaluationSheet.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<EvaluationSheetDTO>(createdObj);
                
                //return response object

                return new ResponseModel<EvaluationSheetDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<EvaluationSheetDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<EvaluationSheetDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.EvaluationSheet.Delete(id);
                var returnedObj = _mapper.Map<EvaluationSheetDTO>(res);
                return new ResponseModel<EvaluationSheetDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<EvaluationSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<EvaluationSheetDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.EvaluationSheet.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<EvaluationSheetDTO>>(result);
                return new ResponseModel<IEnumerable<EvaluationSheetDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<EvaluationSheetDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<EvaluationSheetDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.EvaluationSheet.FindById(id);
                var returnedObj = _mapper.Map<EvaluationSheetDTO>(result);
                return new ResponseModel<EvaluationSheetDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<EvaluationSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<EvaluationSheetDTO>> Update(EvaluationSheetDTO entity)
        {
            try
            {
                var account = _mapper.Map<EvaluationSheet>(entity);
                var updatedObject = await _repository.EvaluationSheet.Update(account);
                var returnedObj = _mapper.Map<EvaluationSheetDTO>(updatedObject);
                return new ResponseModel<EvaluationSheetDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<EvaluationSheetDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            