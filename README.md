Weather Underground .Net API Wrapper (Also Weather.com)
=====================================================

This library implements most features of the Wunderground.com Weather API.

http://www.wunderground.com/weather/api/d/docs

NuGet Package:
-------------------
https://nuget.org/packages/WUnderground.Net

Currently Supported Features:
* Alerts
* Almanac
* Astronomy
* Conditions
* Forecast
* Forecast10day
* GeoLookup
* Hourly
* CurrentHurricane (in progress)

Usage:

```csharp
string key = "{Your API Key Here}";
WeatherClient client = new WeatherClient(key);

//Gets data by Airport Code
client.GetForecast(QueryType.AirportCode, new QueryOptions() { AirportCode = "DFW" });  

//Gets data by the detected IP address of the calling client
client.GetForecast(QueryType.AutoIp);  

//Gets data by country and city
client.GetForecast(QueryType.GlobalCity, new QueryOptions() { Country = "France", City = "Paris" }); 

//Gets data by GPS coordinates
client.GetForecast(QueryType.GPS, new QueryOptions() { Latitude = "37.776289", Longitude = "-122.395234" });

//Gets data by Weather Underground Link ID
client.GetForecast(QueryType.LinkId, new QueryOptions() { LinkId = "00000.1.16172" }); 

//Gets data from a personal weather station by ID
client.GetForecast(QueryType.PWSId, new QueryOptions() { PWSId = "KMNCHASK10" }); 

//Gets data for a US City
client.GetForecast(QueryType.USCity, new QueryOptions() { City = "Los Angeles", State = "CA" }); 

//Gets data by US Zip Code
client.GetForecast(QueryType.ZipCode, new QueryOptions() { ZipCode = "90210" }); 

//Gets Alerts by US City Asynchronously
await client.GetAlertsAsync(QueryType.USCity, new QueryOptions() { City = "Los Angeles", State = "CA" });
```
All methods have both Synchronous and Asynchronous versions

Optional Settings:

Optional settings can be used on any method call and multiple settings can be used together

```csharp
//Gets a forecast in the specifid language
client.GetForecast(QueryType.AutoIp, new QueryOptions() { Language = "FR" };

//Gets a forecast setting the Use Personal Weather Stations for conditions setting (default is true)
client.GetForecast(QueryType.AutoIp, new QueryOptions() { UsePWS = false };

//Gets a forecast setting the Use Weather Underground Best Forecast for forecast
client.GetForecast(QueryType.AutoIp, new QueryOptions() { UseBestFct = false };
```
[WUnderground Optional Settings Documentation](https://www.wunderground.com/weather/api/d/docs?d=data/index)

[Supported Languages](https://www.wunderground.com/weather/api/d/docs?d=language-support&MR=1)

[Best Forecast Documentation](https://www.wunderground.com/about/data)
