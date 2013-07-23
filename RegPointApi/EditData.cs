using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class EditData<T> : IStatus
    {
        [DataMember] public string status { get; set; }
        [DataMember] public string message { get; set; }
        [DataMember(IsRequired = true)] public T data { get; set; }
    }
}
