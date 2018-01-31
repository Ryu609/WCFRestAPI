using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfRestfulApi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdventureWorkService" in both code and config file together.
    [ServiceContract]
    public interface IAdventureWorkService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "xml/{id}")]
        string GetPerson(string Id);
    }
}
