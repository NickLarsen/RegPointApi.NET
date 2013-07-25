namespace RegPointApi.ClassicAsp
{
    public class AddAddOnPurchaseResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddAddOnPurchaseData Data { get; set; }

        public AddAddOnPurchaseResponse() { }
        public AddAddOnPurchaseResponse(Response<AddAddOnData<AddOnPurchase>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddAddOnPurchaseData()
                {
                    add_on_id = values.Data.add_on_id,
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

    public class AddAddOnPurchaseData
    {
        public string status { get; set; }
        public int add_on_id { get; set; }
        public AddOnPurchase data_submitted { get; set; }
        public AddOnPurchase data_saved { get; set; }
    }

    public class EditAddOnPurchasedResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditAddOnPurchasedData Data { get; set; }

        public EditAddOnPurchasedResponse() { }
        public EditAddOnPurchasedResponse(Response<EditData<AddOnPurchase>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditAddOnPurchasedData()
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

    public class EditAddOnPurchasedData
    {
        public string status { get; set; }
        public string message { get; set; }
        public AddOnPurchase data { get; set; }
    }

    public class ViewAddOnsPurchasedResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewAddOnsPurchasedData Data { get; set; }

        public ViewAddOnsPurchasedResponse() { }
        public ViewAddOnsPurchasedResponse(Response<ViewAddOnsPurchasedData> values)
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
