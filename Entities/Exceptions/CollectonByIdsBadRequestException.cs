using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
    public class CollectonByIdsBadRequestException : BadRequestException
    {
        public CollectonByIdsBadRequestException()
        :base("Parameter ids is null")
        {

        }
    }
}
