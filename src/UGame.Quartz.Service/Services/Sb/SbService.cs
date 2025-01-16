using Microsoft.IdentityModel.Tokens;
using MySqlX.XDevAPI;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyFx.Data.SqlSugar;
using TinyFx.Net;
using Xxyy.DAL;

namespace UGame.Quartz.Service.Services.Sb
{
    public class SbService
    {
        protected HttpClientEx Client { get; set; }
        public string vendor_id { get; set; }

        public SbService()
        {
            var providerModel = DbUtil.GetRepository<S_providerPO>().AsQueryable().Where(a => a.ProviderID == "sb").First();
            JObject jo = JObject.Parse(providerModel.ProviderConfig);

            string url = jo["BaseAddress"].Value<string>();
            vendor_id = jo["vendor_id"].Value<string>();


            var config = new HttpClientConfig()
            {
                Name = $"provider.{providerModel.ProviderID}",
                BaseAddress = $"{url.TrimEnd('/')}/",
            };
            Client = HttpClientExFactory.CreateClientEx(config);
        }

       

        public async Task Exec(DateTime? date)
        {
            ReachLimitTransIpo req=new ReachLimitTransIpo();
            req.vendor_id = vendor_id;

            req.start_Time = date.HasValue?date.Value.ToString("yyyy/MM/dd"):DateTime.UtcNow.AddHours(-4).AddDays(-1).ToString("yyyy/MM/dd");
            var rsp = await PostJson<ReachLimitTransDto, ReachLimitTransDto>("/api/getreachlimittrans", req);
            if (rsp.Success && rsp.SuccessResult.error_code == 0)
            {
                var operId= rsp.SuccessResult.Data.Txns.Select(a=>a.transHistory.Select(c=>c.operationId).ToList()).ToList();
                foreach (var o in operId)
                {
                    foreach (var p in o)
                    {
                        var r = await PostJson<ReachLimitTransDto, ReachLimitTransDto>("/api/retryoperation", new RetryOperationIpo(){operationId=p,vendor_id=vendor_id});
                        if (r.SuccessResult.error_code != 0)
                        {
                            await PostJson<ReachLimitTransDto, ReachLimitTransDto>("/api/retryoperation", new RetryOperationIpo() { operationId = p, vendor_id = vendor_id });
                        }
                    }
                }
            }

        }

        private async Task<HttpResponseResult<TSuccess, TError>> PostJson<TSuccess, TError>(string url, object req = null)
        {
            var agent = Client.CreateAgent().AddUrl(url);
            if (req != null)
                agent = agent.AddParameter(req);
            //var rsp = await Client.CreateAgent()
            //.AddUrl(url)
            //.AddParameter(req)
            //.BuildFormUrlEncodedContent()
            //.PostAsync<TSuccess, TError>();
            var rsp = await agent
                .BuildFormUrlEncodedContent()
                .PostAsync<TSuccess, TError>();
            return rsp;
        }
    }
}
