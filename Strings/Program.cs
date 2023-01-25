
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
              "Default": "{{logLevel}}"
          }
      }
    }
    """;
Console.WriteLine(json);