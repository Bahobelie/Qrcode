
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
    public class ChooseService : IChooseService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public ChooseService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<ChooseDTO>> Create(ChooseDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Choose>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Choose.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<ChooseDTO>(createdObj);
                
                //return response object

                return new ResponseModel<ChooseDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ChooseDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ChooseDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Choose.Delete(id);
                var returnedObj = _mapper.Map<ChooseDTO>(res);
                return new ResponseModel<ChooseDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ChooseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<ChooseDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Choose.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<ChooseDTO>>(result);
                return new ResponseModel<IEnumerable<ChooseDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<ChooseDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ChooseDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Choose.FindById(id);
                var returnedObj = _mapper.Map<ChooseDTO>(result);
                return new ResponseModel<ChooseDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ChooseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<ChooseDTO>> Update(ChooseDTO entity)
        {
            try
            {
                var account = _mapper.Map<Choose>(entity);
                var updatedObject = await _repository.Choose.Update(account);
                var returnedObj = _mapper.Map<ChooseDTO>(updatedObject);
                return new ResponseModel<ChooseDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<ChooseDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            