namespace m3GenericsInterfacesAttributes.StaticAbstractsInInterfaces;
public class GetRequestToSomeUrl : IRequestConfig
{
    public static string Url => "https://someurl.com";
    public static HttpMethod Method => HttpMethod.Get;
}
