
using CNET_V7_Repository.Contracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNET_V7_Entities.DataModels;
using CNET_V7_Repository.Contracts.QuestionarySchema;
using Microsoft.EntityFrameworkCore;
using CNET_V7_Entities.Data;

namespace CNET_V7_Repository.Implementation.QuestionarySchema
{
    public class AnswerKeyRepository : Repository<AnswerKey>, IAnswerKeyRepository
    {
        public AnswerKeyRepository(CnetV7DbContext context) : base(context)
        {
        }
    }
}

        