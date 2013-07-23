using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewQuestionsData
    {
        [DataMember(IsRequired = true)] public Question[] questions { get; set; }
    }
}
