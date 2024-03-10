using AirlineWeb.Data;
using AirlineWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirlineWeb.Controllers;
[Route("api/[controller]")]
[ApiController]
public class WebookSubscriptionController : ControllerBase
{
    private readonly AirlineDbContext _context;
    public WebookSubscriptionController(AirlineDbContext context)
    {
        _context = context;
    }

    public IActionResult<WebhookSubscription> CreateSubscription(WebhookSubscription webhookSubscription)
    {

    }
}
