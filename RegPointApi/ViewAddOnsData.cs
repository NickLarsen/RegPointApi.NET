using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewAddOnsData
    {
        [DataMember(IsRequired = true)] public AddOn[] add_ons { get; set; }
    }
}
