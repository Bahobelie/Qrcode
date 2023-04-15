
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
    public class AttachmentService : IAttachmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AttachmentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<ResponseModel<AttachmentDTO>> Create(AttachmentDTO entity)
        {
            try
            {
                //map dto to entity
                var account = _mapper.Map<Attachment>(entity);
                
                //fetch entity obj
                var createdObj = await _repository.Attachment.Create(account);

                //map fetched entity to dto
                var returnedObj = _mapper.Map<AttachmentDTO>(createdObj);
                
                //return response object

                return new ResponseModel<AttachmentDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttachmentDTO> () { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttachmentDTO>> Delete(int id)
        {
            try
            {
                var res = await _repository.Attachment.Delete(id);
                var returnedObj = _mapper.Map<AttachmentDTO>(res);
                return new ResponseModel<AttachmentDTO>() { Success = true, Data = returnedObj }; 
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttachmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<IEnumerable<AttachmentDTO>>> FindAll(bool trackChanges)
        {
            try
            {
                var result = await _repository.Attachment.FindAll(trackChanges);
                var returnedObj = _mapper.Map<IEnumerable<AttachmentDTO>>(result);
                return new ResponseModel<IEnumerable<AttachmentDTO>>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<IEnumerable<AttachmentDTO>>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttachmentDTO>> FindById(int id)
        {
            try
            {
                var result = await _repository.Attachment.FindById(id);
                var returnedObj = _mapper.Map<AttachmentDTO>(result);
                return new ResponseModel<AttachmentDTO>() { Success = true, Data = returnedObj };
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttachmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }

        public async Task<ResponseModel<AttachmentDTO>> Update(AttachmentDTO entity)
        {
            try
            {
                var account = _mapper.Map<Attachment>(entity);
                var updatedObject = await _repository.Attachment.Update(account);
                var returnedObj = _mapper.Map<AttachmentDTO>(updatedObject);
                return new ResponseModel<AttachmentDTO>() { Success = true, Data = returnedObj }; ;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return new ResponseModel<AttachmentDTO>() { Success = false, Ex = e, Message = e.Message };
            }
        }
    }
}
            