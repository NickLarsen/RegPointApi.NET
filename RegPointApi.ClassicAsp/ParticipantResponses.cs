namespace RegPointApi.ClassicAsp
{
    public class AddParticipantResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public AddParticipantData Data { get; set; }

        public AddParticipantResponse() { }
        public AddParticipantResponse(Response<AddData<Participant>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new AddParticipantData()
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

    public class AddParticipantData
    {
        public string status { get; set; }
        public int id { get; set; }
        public Participant data_submitted { get; set; }
        public Participant data_saved { get; set; }
    }

    public class EditParticipantResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public EditParticipantData Data { get; set; }

        public EditParticipantResponse() { }
        public EditParticipantResponse(Response<EditData<Participant>> values)
        {
            WasSuccessful = values.WasSuccessful;
            OriginalContent = values.OriginalContent;
            RequestUrl = values.RequestUrl;

            if (WasSuccessful)
            {
                Data = new EditParticipantData()
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

    public class EditParticipantData
    {
        public string status { get; set; }
        public string message { get; set; }
        public Participant data { get; set; }
    }

    public class ViewParticipantsResponse
    {
        public bool WasSuccessful { get; set; }
        public string ErrorMessage { get; set; }
        public string OriginalContent { get; set; }
        public string RequestUrl { get; set; }
        public ViewParticipantsData Data { get; set; }

        public ViewParticipantsResponse() { }
        public ViewParticipantsResponse(Response<ViewParticipantsData> values)
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
