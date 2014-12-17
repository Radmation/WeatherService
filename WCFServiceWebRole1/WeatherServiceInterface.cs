using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface WeatherServiceInterface
    {

        [OperationContract]
        string GetWeather();
        [OperationContract]
        string GetSunrise();
        [OperationContract]
        string GetSunset();
        [OperationContract]
        string GetAvgHi();
        [OperationContract]
        string GetAvgLo();
        // TODO: Add your service operations here
    }

}
