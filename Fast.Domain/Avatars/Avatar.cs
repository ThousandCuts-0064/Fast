using Fast.Domain.Bases;

namespace Fast.Domain.Avatars;

public class Avatar : NamedEntity
{
    public int HeadId { get; set; }
    public int LeftEyeId { get; set; }
    public int RightEyeId { get; set; }
    public int MouthId { get; set; }
    public int NoseId { get; set; }
    public int HatIt { get; set; }
}