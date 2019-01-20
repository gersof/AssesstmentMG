using MasGlobal.Assessment.DataAccess.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobal.Assessment.DataAccess.Repositories
{
   public class MasGlobalEmployees: IMasGlobalEmployees
    {
        private HttpClient ClientHttp;
    private string URL { get; set; }

    public MasGlobalEmployees()
    {
        ClientHttp = new HttpClient();
        URL = ConfigurationManager.AppSettings["BaseUrlEmployees"];
        ClientHttp.BaseAddress = new Uri(URL);
        ClientHttp.DefaultRequestHeaders.Accept.Clear();
        ClientHttp.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public async Task<T> GetEntityAsync<T>(string path)
    {
        HttpResponseMessage response = await ClientHttp.GetAsync(URL + path);
        var result = await response.Content.ReadAsStringAsync();

        if (response.IsSuccessStatusCode)
        {
            return JsonConvert.DeserializeObject<T>(result);
        }
        else
        {
            throw new Exception("Somthing was wrong trying to get employees");        
        }
    }


}
}
