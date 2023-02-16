using lambdaMinimalApi.Queries.GetTweets;
using Microsoft.AspNetCore.Mvc;

namespace lambdaMinimalAPI.Controllers;

[ApiController]
[Route("")]
public class BigBossController : ControllerBase
{
    private readonly ILogger<BigBossController> _logger;
    private readonly IGetTweetsQueryHandler _tweetsQueryHandler;

    public BigBossController(
        ILogger<BigBossController> logger,
        IGetTweetsQueryHandler tweetsQueryHandler)
    {
        _logger = logger;
        _tweetsQueryHandler = tweetsQueryHandler;
    }

    [HttpPost("create-user")]
    public int CreateUser(string userId)
    {
        return -1;
    }


    [HttpPost("tweet")]
    public int Tweet(string userId)
    {
        return -2;
    }


    [HttpGet("user")]
    public IActionResult UserItem(string userId)
    {
        return Ok(-3);
    }

    [HttpGet("ping")]
    public IActionResult Ping(string userId)
    {
        return Ok();
    }



    [HttpGet("tweets")]
    public async Task<IActionResult> Tweets(string userId)
    {
        var result = (await this._tweetsQueryHandler.Handle(new GetTweetsQuery { }));
        return Ok(result);
    }
}


