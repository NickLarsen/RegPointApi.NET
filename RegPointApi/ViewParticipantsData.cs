using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewParticipantsData
    {
        [DataMember(IsRequired = true)] public Participant[] participants { get; set; }
    }
}
