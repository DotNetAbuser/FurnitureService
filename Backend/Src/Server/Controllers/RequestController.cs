namespace Server.Controllers;

[ApiController]
[Route("api/request")]
public class RequestController(
    IRequestService requestService)
    : ControllerBase
{
    private readonly IRequestService _requestService = requestService;
    
    [HttpPost]
    public async Task<IActionResult> CreateRequestAsync(FurnitureRequest request)
    {
        return Ok(await _requestService.CreateRequestAsync(request));
    }

    [HttpGet]
    public async Task<IActionResult> GetRequests()
    {
        var response = await _requestService.GetAllAsync();
        return Ok(response);
    }
}