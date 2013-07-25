namespace RegPointApi.ClassicAsp
{
    public class AddMasterAccountResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddMasterAccountData Data { get; set; }

        public AddMasterAccountResponse() { }
        public AddMasterAccountResponse(Response<AddData<MasterAccount>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddMasterAccountData()
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

    public class AddMasterAccountData
    {
        public string status { get; set; }
        public int id { get; set; }
        public MasterAccount data_submitted { get; set; }
        public MasterAccount data_saved { get; set; }
    }

    public class EditMasterAccountResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditMasterAccountData Data { get; set; }

        public EditMasterAccountResponse() { }
        public EditMasterAccountResponse(Response<EditData<MasterAccount>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditMasterAccountData()
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

    public class EditMasterAccountData
    {
        public string status { get; set; }
        public string message { get; set; }
        public MasterAccount data { get; set; }
    }

    public class ViewMasterAccountsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewMasterAccountsData Data { get; set; }

        public ViewMasterAccountsResponse() { }
        public ViewMasterAccountsResponse(Response<ViewMasterAccountsData> values)
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
