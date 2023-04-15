
using CNET_V7_Repository.Contracts;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CNET_V7_Entities.DataModels;
using CNET_V7_Repository.Contracts.SecuritySchema;
using Microsoft.EntityFrameworkCore;
using CNET_V7_Entities.Data;

namespace CNET_V7_Repository.Implementation.SecuritySchema
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(CnetV7DbContext context) : base(context)
        {
        }
    }
}

        