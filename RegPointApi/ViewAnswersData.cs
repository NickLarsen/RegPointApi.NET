using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewAnswersData
    {
        [DataMember(IsRequired = true)] public Answer[] answers { get; set; }
    }
}
