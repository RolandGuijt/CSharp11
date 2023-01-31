var someString = @"abc\d";

var language = "en";
var htmlTag = $"""<html lang="{language}"/>""";
Console.WriteLine(htmlTag);

//{
//  "Logging": {
//      "LogLevel": {
//          "Default": "Information"
//      }
//  }
//}

var logLevel = "Information";
var json = $$"""
    {
      "Logging": {
          "LogLevel": {
              "Default": "{{logLevel
                .ToLower()}}"
          }
      }
    }
    """;
Console.WriteLine(json);

var temp = 44;

var message = $"The temperature is {temp switch
{
    > 77 => "Hot",
    > 50 => "Mild",
    < 51 => "Cold"
}}";

var utf8 = "header: "u8;

