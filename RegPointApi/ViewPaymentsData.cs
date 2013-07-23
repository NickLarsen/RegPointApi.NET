using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewPaymentsData
    {
        [DataMember(IsRequired = true)] public Payment[] payments { get; set; }
    }
}
