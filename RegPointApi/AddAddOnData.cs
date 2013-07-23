using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class AddAddOnData<T> : IStatus
    {
        [DataMember] public string status { get; set; }
        [DataMember] public int add_on_id { get; set; }

        [DataMember(Name = "data-submitted", IsRequired = true)]
        public T data_submitted { get; set; }
        [DataMember(Name = "data-saved", IsRequired = true)]
        public T data_saved { get; set; }
    }
}
