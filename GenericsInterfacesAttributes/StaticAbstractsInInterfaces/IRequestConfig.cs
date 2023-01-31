namespace m3GenericsInterfacesAttributes.StaticAbstractsInInterfaces;
public interface IRequestConfig
{
    static abstract string Url { get; }
    static abstract HttpMethod Method { get; }
}

