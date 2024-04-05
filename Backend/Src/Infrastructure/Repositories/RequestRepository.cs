namespace Infrastructure.Repositories;

public class RequestRepository(ApplicationDbContext dbContext)
    : IRequestRepository
{
    private readonly ApplicationDbContext _dbContext = dbContext;

    public async Task<IEnumerable<RequestEntity>> GetAllAsync()
    {
        return await _dbContext.Requests
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task CreateAsync(RequestEntity entity)
    {
        await _dbContext.Requests.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}