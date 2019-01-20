using MasGlobal.Assessment.Business;
using MasGlobal.Assessment.Entities.APIS.Response;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Web.Http;

namespace MasGlobal.Assessment.UI.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [DefaultValue(null)]
        [Route("api/employee/{id?}")]
        public async Task<HttpResponseMessage> GetAsync(int? id=null)
        {
            try
            {
                var component = await new EmployeesComponent().GetAll(id);

                var response = new List<EmployeeResponse>();
                foreach (var item in component)
                {
                    var employee = new EmployeeResponse
                    {
                        id = item.id,
                        name = item.name,
                        contractTypeName = item.contractTypeName,
                        roleId = item.roleId,
                        roleName = item.roleName,
                        roleDescription = item.roleDescription,
                        anualSalary = item.anualSalary

                    };

                    response.Add(employee);
                }

                return Request.CreateResponse(HttpStatusCode.OK, response, FormatMediaTypeJson());
            }
            catch (Exception ex)
            {
                var msg = new { status = false, mensaje = ex.Message.ToString() };
                return Request.CreateResponse(HttpStatusCode.BadRequest, msg, FormatMediaTypeJson());
            }
        }

        public static JsonMediaTypeFormatter FormatMediaTypeJson()
        {
            var Formatter = new JsonMediaTypeFormatter();
            var ResultJson = Formatter.SerializerSettings;

            ResultJson.DateFormatHandling = Newtonsoft.Json.DateFormatHandling.IsoDateFormat;
            ResultJson.NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore;
            ResultJson.Formatting = Newtonsoft.Json.Formatting.Indented;
            ResultJson.ContractResolver = new CamelCasePropertyNamesContractResolver();

            return Formatter;
        }
    }
}
