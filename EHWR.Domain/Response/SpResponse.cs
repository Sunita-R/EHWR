using System;
using System.Collections.Generic;
using System.Text;

namespace EHWR.Domain.Response
{
    public class SpResponse
    {
        public int KeyId { get; set; }
        public int ResponseCode { get; set; }
        public string ResponseMessage { get; set; }
    }
}
