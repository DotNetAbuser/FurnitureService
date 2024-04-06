namespace Client.Infrastructure.Managers;

public interface IRequestManager
{
    Task<IResult> CreateAsync(FurnitureRequest request);
    Task<IResult<IEnumerable<FurnitureResponse>>> GetAllAsync();
}

public class RequestManager(IHttpClientFactory factory)
    : IRequestManager
{
    private readonly IHttpClientFactory _factory = factory;


    public async Task<IResult> CreateAsync(FurnitureRequest request)
    {
        var response = await _factory
            .CreateClient("client")
            .PostAsJsonAsync(RequestRoutes.CreateRequest, request);
        var result = await response.ToResult();
        return result;
    }

    public async Task<IResult<IEnumerable<FurnitureResponse>>> GetAllAsync()
    {
        var response = await _factory
            .CreateClient("client")
            .GetAsync(RequestRoutes.GetAll);
        var result = await response.ToResult<IEnumerable<FurnitureResponse>>();
        return result;
    }
}