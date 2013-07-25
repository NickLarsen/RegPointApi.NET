namespace RegPointApi.ClassicAsp
{
    public class AddPaymentResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddPaymentData Data { get; set; }

        public AddPaymentResponse() { }
        public AddPaymentResponse(Response<AddData<Payment>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddPaymentData()
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

    public class AddPaymentData
    {
        public string status { get; set; }
        public int id { get; set; }
        public Payment data_submitted { get; set; }
        public Payment data_saved { get; set; }
    }

    public class EditPaymentResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditPaymentData Data { get; set; }

        public EditPaymentResponse() { }
        public EditPaymentResponse(Response<EditData<Payment>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditPaymentData()
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

    public class EditPaymentData
    {
        public string status { get; set; }
        public string message { get; set; }
        public Payment data { get; set; }
    }

    public class ViewPaymentsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewPaymentsData Data { get; set; }

        public ViewPaymentsResponse() { }
        public ViewPaymentsResponse(Response<ViewPaymentsData> values)
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
