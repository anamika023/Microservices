using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AggregatorService.Modal
{
    public class OrderDetails: IOrderDetails
    {
        private WebClient _webClient;
        public OrderDetails()
        {
            this._webClient = new WebClient();
        }

        public string GetOrderDetails(int id)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                //var userurl = Environment.GetEnvironmentVariable("UserURL")??
                sb.Append("{\"userDetails\"");
                sb.Append(_webClient.DownloadString("http://10.47.244.129/api/User/" + id));
                sb.Append(",{\"orders\"");
                sb.Append(_webClient.DownloadString("http://10.47.240.145/api/Orders/" + id));
                sb.Append("}");
                return sb.ToString();
            }
            catch(Exception e)
            {
                return e.Message;
            }

            
        }

       




    }
}

