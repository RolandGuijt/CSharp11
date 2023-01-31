namespace m3GenericsInterfacesAttributes.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class ValidateParameterAttribute : Attribute
{
    private readonly string _ParamName;

    public ValidateParameterAttribute(string paramName)
    {
        _ParamName = paramName;
    }
}

