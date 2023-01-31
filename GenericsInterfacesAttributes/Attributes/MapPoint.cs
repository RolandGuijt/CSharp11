namespace m3GenericsInterfacesAttributes.Attributes;
public class MapPoint
{
    [Validate<CityValidator>]
    public string NearestCity { get; set; }

    [Validate<CoordinateValidator>]
    public string GpsCoordinates { get; set; }

    [ValidateParameter(nameof(startingPnt))]
    public int CalculateDistance(string startingPnt)
    {
        throw new NotImplementedException();
    }

}

