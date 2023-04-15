
using CNET_V7_Repository.Contracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNET_V7_Entities.DataModels;
using CNET_V7_Repository.Contracts.CommonSchema;
using Microsoft.EntityFrameworkCore;
using CNET_V7_Entities.Data;

namespace CNET_V7_Repository.Implementation.CommonSchema
{
    public class RangeRepository : Repository<CNET_V7_Entities.DataModels.Range>, IRangeRepository
    {
        public RangeRepository(CnetV7DbContext context) : base(context)
        {
        }
    }
}

        