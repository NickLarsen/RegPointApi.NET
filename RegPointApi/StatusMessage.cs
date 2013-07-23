using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class StatusMessage : IStatus
    {
        [DataMember] public string status { get; set; }
        [DataMember] public string message { get; set; }
        [DataMember] public string[] error_messages { get; set; }
    }
}
