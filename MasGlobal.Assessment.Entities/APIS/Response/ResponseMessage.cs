using System;
using System.Collections.Generic;
using System.Text;

namespace MasGlobal.Assessment.Entities.APIS.Response
{
    public class ResponseMessage
    {
        public bool status { get; set; }
        public string message { get; set; }
        public List<EmployeeResponse> employees { get; set; }
    }
}
