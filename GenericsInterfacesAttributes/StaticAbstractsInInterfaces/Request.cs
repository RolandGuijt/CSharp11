namespace m3GenericsInterfacesAttributes.StaticAbstractsInInterfaces;
public class Request
{
    public void DoRequest<T>()
        where T : IRequestConfig
    {
        var url = T.Url;
        var method = T.Method;
        //do request
    }
}

