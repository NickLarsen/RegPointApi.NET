namespace RegPointApi.ClassicAsp
{
    public class AddAnswerResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddAnswerData Data { get; set; }

        public AddAnswerResponse() { }
        public AddAnswerResponse(Response<AddData<Answer>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddAnswerData()
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

    public class AddAnswerData
    {
        public string status { get; set; }
        public int id { get; set; }
        public Answer data_submitted { get; set; }
        public Answer data_saved { get; set; }
    }

    public class EditAnswerResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditAnswerData Data { get; set; }

        public EditAnswerResponse() { }
        public EditAnswerResponse(Response<EditData<Answer>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditAnswerData()
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

    public class EditAnswerData
    {
        public string status { get; set; }
        public string message { get; set; }
        public Answer data { get; set; }
    }

    public class ViewAnswersResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewAnswersData Data { get; set; }

        public ViewAnswersResponse() { }
        public ViewAnswersResponse(Response<ViewAnswersData> values)
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
