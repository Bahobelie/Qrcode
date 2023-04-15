
using AutoMapper;
using CNET_V7_Domain.DataModels.CommonSchema;
using CNET_V7_Entities.DataModels;
using CNET_V7_Logger;
using CNET_V7_Repository.Contracts;
using CNET_V7_Service.Contracts.CommonSchema;
using CNET_V7_Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using CNET_V7_Domain.Misc;
using Azure;

namespace CNET_V7_Service.Implementation.CommonSchema
{
    public class SubtitleService : ISubtitleService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public SubtitleService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<SubtitleDTO>> Create(SubtitleDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Subtitle>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Subtitle.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<SubtitleDTO>(createdObj);
                
                //return response object

                return new ResponseModel<SubtitleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubtitleDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubtitleDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Subtitle.Delete(id);
                var returnedObj = _mapper.Map<SubtitleDTO>(res);
                return new ResponseModel<SubtitleDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubtitleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<SubtitleDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Subtitle.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<SubtitleDTO>>(result);
                return new ResponseModel<IEnumerable<SubtitleDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<SubtitleDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubtitleDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Subtitle.FindById(id);
                var returnedObj = _mapper.Map<SubtitleDTO>(result);
                return new ResponseModel<SubtitleDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubtitleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<SubtitleDTO>> Update(SubtitleDTO entity)
        {
            try
            {
                var account = _mapper.Map<Subtitle>(entity);
                var updatedObject = await _repository.Subtitle.Update(account);
                var returnedObj = _mapper.Map<SubtitleDTO>(updatedObject);
                return new ResponseModel<SubtitleDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<SubtitleDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            