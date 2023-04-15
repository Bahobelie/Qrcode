using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Domain.Misc
{


    public class ResponseModel<T> 
    {
        public T Data { get; set; }
        public Exception Ex { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

    }
}
