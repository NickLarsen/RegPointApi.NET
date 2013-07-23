using System.Runtime.Serialization;

namespace RegPointApi
{
    [DataContract]
    public class ViewPromoCodesData
    {
        [DataMember(IsRequired = true)] public PromoCode[] promo_codes { get; set; }
    }
}
