
using Microsoft.AspNetCore.Mvc;
using SleeDigital.LabelStore.Library.Models;

namespace SleeDigital.LabelStore.Api.Customers.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<User> Get()
    {
        var user = new User()
        {
            AzureObjectId = Guid.NewGuid().ToString(),
            EmailAddress = "stevejowens@icloud.com",
            FirstName = "Steve",
            LastName = "Owens"
        };
        user.Roles.Add(Guid.NewGuid().ToString());
        user.Roles.Add(Guid.NewGuid().ToString());
        user.Roles.Add(Guid.NewGuid().ToString());
        var users = new List<User>();
        users.Add(user);
        return users;

    }
}

