using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    [ComVisible(false)]
    public class AddData<T> : IStatus
    {
        [DataMember] public string status { get; set; }
        [DataMember] public int id { get; set; }

        [DataMember(Name = "data-submitted", IsRequired = true)]
        public T data_submitted { get; set; }
        [DataMember(Name = "data-saved", IsRequired = true)]
        public T data_saved { get; set; }
    }
}
