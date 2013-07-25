namespace RegPointApi.ClassicAsp
{
    public class AddAddOnResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddAddOnData Data { get; set; }

        public AddAddOnResponse() { }
        public AddAddOnResponse(Response<AddAddOnData<AddOn>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddAddOnData()
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

    public class AddAddOnData
    {
        public string status { get; set; }
        public int add_on_id { get; set; }
        public AddOn data_submitted { get; set; }
        public AddOn data_saved { get; set; }
    }

    public class EditAddOnResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditAddOnData Data { get; set; }

        public EditAddOnResponse() { }
        public EditAddOnResponse(Response<EditData<AddOn>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditAddOnData()
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

    public class EditAddOnData
    {
        public string status { get; set; }
        public string message { get; set; }
        public AddOn data { get; set; }
    }

    public class ViewAddOnsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewAddOnsData Data { get; set; }

        public ViewAddOnsResponse() { }
        public ViewAddOnsResponse(Response<ViewAddOnsData> values)
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
