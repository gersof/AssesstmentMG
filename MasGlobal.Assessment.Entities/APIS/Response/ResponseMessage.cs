using System.Collections.Generic;

namespace MasGlobal.Assessment.Entities.APIS.Response
{
    public class ResponseMessage
    {
        public bool status { get; set; }
        public string message { get; set; }
        public List<EmployeeResponse> employees { get; set; }
    }
}
