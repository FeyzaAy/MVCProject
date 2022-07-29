
using ServiceReference1;

namespace BusinessDAL
{
    public class ServiceHelper
    {
        public async Task<TumArizaGetirResponse> ArizaGetir()
        {
            ServiceReference1.AuthHeader ah = new ServiceReference1.AuthHeader();



            ah.UserName = "stajer";

            ah.Password = "Stajer2022$$";

            var Sclient =
           new WebServiceKatodikSoapClient(WebServiceKatodikSoapClient.EndpointConfiguration.WebServiceKatodikSoap);


            Task<ServiceReference1.TumArizaGetirResponse> result =  Sclient.TumArizaGetirAsync(ah);


            return await result.Result;
        }
     
     

    }
}