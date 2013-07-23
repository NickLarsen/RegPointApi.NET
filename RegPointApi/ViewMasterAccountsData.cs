using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewMasterAccountsData
    {
        [DataMember(IsRequired = true)] public MasterAccount[] master_accounts { get; set; }
    }
}
