namespace Fast.Domain.Avatars;

public interface IAvatarRepository
{
    public Task InsertAsync(Avatar entity);
}