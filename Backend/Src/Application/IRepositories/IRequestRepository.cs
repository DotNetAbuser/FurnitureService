namespace Application.IRepositories;

public interface IRequestRepository
{
    Task<IEnumerable<RequestEntity>> GetAllAsync();
    Task CreateAsync(RequestEntity entity);
}