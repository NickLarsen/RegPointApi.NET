namespace RegPointApi.ClassicAsp
{
    public class AddQuestionResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddQuestionData Data { get; set; }

        public AddQuestionResponse() { }
        public AddQuestionResponse(Response<AddData<Question>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddQuestionData()
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

    public class AddQuestionData
    {
        public string status { get; set; }
        public int id { get; set; }
        public Question data_submitted { get; set; }
        public Question data_saved { get; set; }
    }

    public class EditQuestionResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditQuestionData Data { get; set; }

        public EditQuestionResponse() { }
        public EditQuestionResponse(Response<EditData<Question>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditQuestionData()
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

    public class EditQuestionData
    {
        public string status { get; set; }
        public string message { get; set; }
        public Question data { get; set; }
    }

    public class ViewQuestionsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewQuestionsData Data { get; set; }

        public ViewQuestionsResponse() { }
        public ViewQuestionsResponse(Response<ViewQuestionsData> values)
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
