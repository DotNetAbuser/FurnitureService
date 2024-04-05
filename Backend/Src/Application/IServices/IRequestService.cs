namespace Application.IServices;

public interface IRequestService
{
    Task<Result<IEnumerable<FurnitureResponse>>> GetAllAsync();
    Task<Result> CreateRequestAsync(FurnitureRequest request);
}