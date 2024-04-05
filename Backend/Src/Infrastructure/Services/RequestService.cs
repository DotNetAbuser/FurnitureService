namespace Infrastructure.Services;

public class RequestService(IRequestRepository requestRepository)
    : IRequestService
{
    private readonly IRequestRepository _requestRepository = requestRepository;
    public async Task<Result> CreateRequestAsync(FurnitureRequest request)
    {
        var requestEntity = new RequestEntity
        {
            ID = new Guid(),
            Furniture = request.Furniture,
            Description = request.Description,
            Status = "В ожидание"
        };
        await _requestRepository.CreateAsync(requestEntity);
        return await Result<string>
            .SuccessAsync("Заявка успешно создана.");
    }

    public async Task<Result<IEnumerable<FurnitureResponse>>> GetAllAsync()
    {
        var requestsEntity = await _requestRepository.GetAllAsync();
        var requestsResponse = requestsEntity
            .Select(requestEntity => new FurnitureResponse
            {
                Furniture = requestEntity.Furniture,
                Description = requestEntity.Description, 
                Status = requestEntity.Status
            }).ToList();

        return await Result<IEnumerable<FurnitureResponse>>
            .SuccessAsync(requestsResponse, "Заявки успешно получены.");
    }
}