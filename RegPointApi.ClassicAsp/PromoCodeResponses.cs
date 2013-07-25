namespace RegPointApi.ClassicAsp
{
    public class AddPromoCodeResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddPromoCodeData Data { get; set; }

        public AddPromoCodeResponse() { }
        public AddPromoCodeResponse(Response<AddData<PromoCode>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddPromoCodeData()
                {
                    id = values.Data.id,
                    status = values.Data.status,
                    data_submitted = values.Data.data_submitted,
                    data_saved = values.Data.data_saved,
                };
            }
            else
            {
                ErrorMessage = values.Exception.GetMessage();
            }
        }
    }

    public class AddPromoCodeData
    {
        public string status { get; set; }
        public int id { get; set; }
        public PromoCode data_submitted { get; set; }
        public PromoCode data_saved { get; set; }
    }

    public class EditPromoCodeResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditPromoCodeData Data { get; set; }

        public EditPromoCodeResponse() { }
        public EditPromoCodeResponse(Response<EditData<PromoCode>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditPromoCodeData()
                {
                    message = values.Data.message,
                    status = values.Data.status,
                    data = values.Data.data,
                };
            }
            else
            {
                ErrorMessage = values.Exception.GetMessage();
            }
        }
    }

    public class EditPromoCodeData
    {
        public string status { get; set; }
        public string message { get; set; }
        public PromoCode data { get; set; }
    }

    public class ViewPromoCodesResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewPromoCodesData Data { get; set; }

        public ViewPromoCodesResponse() { }
        public ViewPromoCodesResponse(Response<ViewPromoCodesData> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = values.Data;
            }
            else
            {
                ErrorMessage = values.Exception.GetMessage();
            }
        }
    }
}
