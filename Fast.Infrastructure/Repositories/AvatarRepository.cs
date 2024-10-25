using Fast.Domain.Avatars;

namespace Fast.Infrastructure.Repositories;

internal class AvatarRepository : IAvatarRepository
{
    public Task InsertAsync(Avatar entity)
    {
        Console.WriteLine("Inserted");
    }
}
