using MediatR;

namespace Fast.Application.Features.Avatars.Commands.Create;

public class CreateAvatarCommand : IRequest
{
    public required string Name { get; init; }
}
