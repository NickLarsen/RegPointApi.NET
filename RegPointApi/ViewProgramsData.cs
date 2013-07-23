using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewProgramsData
    {
        [DataMember(IsRequired = true)] public Program[] programs { get; set; }
    }
}
