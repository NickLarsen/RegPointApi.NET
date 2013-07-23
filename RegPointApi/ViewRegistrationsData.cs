using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewRegistrationsData
    {
        [DataMember(IsRequired = true)] public Registration[] registrations { get; set; }
    }
}
