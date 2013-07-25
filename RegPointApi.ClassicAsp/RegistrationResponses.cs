namespace RegPointApi.ClassicAsp
{
    public class AddRegistrationResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddRegistrationData Data { get; set; }

        public AddRegistrationResponse() { }
        public AddRegistrationResponse(Response<AddData<Registration>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddRegistrationData()
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

    public class AddRegistrationData
    {
        public string status { get; set; }
        public int id { get; set; }
        public Registration data_submitted { get; set; }
        public Registration data_saved { get; set; }
    }

    public class EditRegistrationResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditRegistrationData Data { get; set; }

        public EditRegistrationResponse() { }
        public EditRegistrationResponse(Response<EditData<Registration>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditRegistrationData()
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

    public class EditRegistrationData
    {
        public string status { get; set; }
        public string message { get; set; }
        public Registration data { get; set; }
    }

    public class ViewRegistrationsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewRegistrationsData Data { get; set; }

        public ViewRegistrationsResponse() { }
        public ViewRegistrationsResponse(Response<ViewRegistrationsData> values)
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
