using Fast.Domain.Avatars;
using MediatR;

namespace Fast.Application.Features.Avatars.Commands.Create;

public class CreateAvatarCommandHandler : IRequestHandler<CreateAvatarCommand>
{
    private readonly IAvatarRepository _avatarRepository;

    public CreateAvatarCommandHandler(IAvatarRepository avatarRepository)
    {
        _avatarRepository = avatarRepository;
    }

    public async Task Handle(CreateAvatarCommand request, CancellationToken cancellationToken)
    {
        var entity = new Avatar
        {
            Name = request.Name,
        };

        await _avatarRepository.InsertAsync(entity);
    }
}
