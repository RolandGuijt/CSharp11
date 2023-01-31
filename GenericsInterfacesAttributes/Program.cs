﻿using m3GenericsInterfacesAttributes.Attributes;
using m3GenericsInterfacesAttributes.StaticAbstractsInInterfaces;
using System.Numerics;
using System.Reflection;

var request = new Request();
request.DoRequest<GetRequestToSomeUrl>();

double[] doubles = new[] { 1.5, 2.1, 3.7, 4.1 };
var doubleSum = AddAll(doubles);
int[] integers = new[] { 1, 2, 3, 4, 5 };
var sum = AddAll(integers);
//Console.WriteLine(sum);

T AddAll<T>(T[] values)
    where T : INumber<T>
{
    T result = T.Zero;
    T one = T.One;
    T max = T.Max(result, one);
    T abs = T.Abs(result);

    foreach (var value in values)
        result += value;

    return result;
}


var mapPoint = new MapPoint
{
    NearestCity = "STOCKHOLM",
    GpsCoordinates = "59° 20' 4.5276'' N 18° 3' 47.6640'' E"
};

var result = ValidateMapPoint(mapPoint);

bool ValidateMapPoint(MapPoint mapPoint)
{
    var cityValidator =
        GetValidator<MapPoint>(nameof(mapPoint.NearestCity));
    var nearestCityResult =
        cityValidator.Validate(mapPoint.NearestCity);

    var coordinateValidator =
        GetValidator<MapPoint>(nameof(mapPoint.GpsCoordinates));
    var coordinateResult =
        coordinateValidator.Validate(mapPoint.GpsCoordinates);

    return nearestCityResult && coordinateResult;
}

IValidator GetValidator<T>(string property)
{
    var validatorType = typeof(T)
        .GetProperty(property)
        .GetCustomAttribute(typeof(ValidateAttribute<>))
        .GetType()
        .GenericTypeArguments.First();

    return Activator.CreateInstance(validatorType)
            as IValidator;
}

