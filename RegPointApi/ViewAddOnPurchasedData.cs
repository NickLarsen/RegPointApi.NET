using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewAddOnsPurchasedData
    {
        [DataMember(IsRequired = true)] public AddOnPurchase[] add_ons { get; set; }
    }
}
