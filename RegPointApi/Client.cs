using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using RestSharp;

namespace RegPointApi
{
    public class Client : IClient
    {
        // url structure
        // GET: https://regpointsecure.com/api/<function>/<api_key>/{<row_id>}{?<filterkey>=<filtervalue>{&<filterkey>=<filtervalue>}}
        // POST: https://regpointsecure.com/api/<function>/ api key must be in header "apikey" or post variable "apikey"

        private readonly int? noId = null;
        private const string responseFormat = @"application/json";
        private const string apiUrl = @"https://regpointsecure.com/api/";

        private readonly string postUrlFormat;
        private readonly string getUrlFormat;
        private readonly string apiKey;

        public const string SandboxApiKey = @"sandboxAPIKey";

        public Client(string apiKey)
        {
            this.apiKey = apiKey;
            this.postUrlFormat = apiUrl + "{0}/";
            this.getUrlFormat = apiUrl + "{0}/" + apiKey + "/{1}";
        }

        public Response<AddAddOnData<AddOn>> AddAddOn(AddOn entity)
        {
            return ExecutePostRequest<AddAddOnData<AddOn>>("addAddOn", entity, ignoreIds: true);
        }

        public Response<ViewAddOnsData> ViewAddOns(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewAddOnsData>("viewAddOns", filters);
        }

        public Response<EditData<AddOn>> EditAddOn(AddOn entity)
        {
            return ExecutePostRequest<EditData<AddOn>>("editAddOn", entity);
        }

        public Response<StatusMessage> DeleteAddOn(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteAddOn", new { id });
        }

        public Response<AddAddOnData<AddOnPurchase>> AddAddOnPurchase(AddOnPurchase entity)
        {
            return ExecutePostRequest<AddAddOnData<AddOnPurchase>>("addAddOnPurchased", entity, ignoreIds: true);
        }

        public Response<ViewAddOnsPurchasedData> ViewAddOnsPurchased(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewAddOnsPurchasedData>("viewAddOnsPurchased", filters);
        }

        public Response<EditData<AddOnPurchase>> EditAddOnPurchased(AddOnPurchase entity)
        {
            return ExecutePostRequest<EditData<AddOnPurchase>>("editAddOnPurchased", entity);
        }

        public Response<StatusMessage> DeleteAddOnPurchased(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteAddOnPurchased", new { id });
        }

        public Response<AddData<Answer>> AddAnswer(Answer entity)
        {
            return ExecutePostRequest<AddData<Answer>>("addAnswer", entity, ignoreIds: true);
        }

        public Response<ViewAnswersData> ViewAnswers(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewAnswersData>("viewAnswers", filters);
        }

        public Response<EditData<Answer>> EditAnswer(Answer entity)
        {
            return ExecutePostRequest<EditData<Answer>>("editAnswer", entity);
        }

        public Response<StatusMessage> DeleteAnswer(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteAnswer", new { id });
        }

        public Response<AddData<MasterAccount>> AddMasterAccount(MasterAccount entity)
        {
            return ExecutePostRequest<AddData<MasterAccount>>("addMasterAccount", entity, ignoreIds: true);
        }

        public Response<ViewMasterAccountsData> ViewMasterAccounts(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewMasterAccountsData>("viewMasterAccounts", filters);
        }

        public Response<EditData<MasterAccount>> EditMasterAccount(MasterAccount entity)
        {
            return ExecutePostRequest<EditData<MasterAccount>>("editMasterAccount", entity);
        }

        public Response<StatusMessage> DeleteMasterAccount(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteMasterAccount", new { id });
        }

        public Response<AddData<Participant>> AddParticipant(Participant entity)
        {
            return ExecutePostRequest<AddData<Participant>>("addParticipant", entity, ignoreIds: true);
        }

        public Response<ViewParticipantsData> ViewParticipants(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewParticipantsData>("viewParticipants", filters);
        }

        public Response<EditData<Participant>> EditParticipant(Participant entity)
        {
            return ExecutePostRequest<EditData<Participant>>("editParticipant", entity);
        }

        public Response<StatusMessage> DeleteParticipant(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteParticipant", new { id });
        }

        public Response<AddData<Payment>> AddPayment(Payment entity)
        {
            return ExecutePostRequest<AddData<Payment>>("addPayment", entity, ignoreIds: true);
        }

        public Response<ViewPaymentsData> ViewPayments(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewPaymentsData>("viewPayments", filters);
        }

        public Response<EditData<Payment>> EditPayment(Payment entity)
        {
            return ExecutePostRequest<EditData<Payment>>("editPayment", entity);
        }

        public Response<StatusMessage> DeletePayment(int id)
        {
            return ExecutePostRequest<StatusMessage>("deletePayment", new { id });
        }

        public Response<AddData<Program>> AddProgram(Program entity)
        {
            return ExecutePostRequest<AddData<Program>>("addProgram", entity, ignoreIds: true);
        }

        public Response<ViewProgramsData> ViewPrograms(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewProgramsData>("viewPrograms", filters);
        }

        public Response<EditData<Program>> EditProgram(Program entity)
        {
            return ExecutePostRequest<EditData<Program>>("editProgram", entity);
        }

        public Response<StatusMessage> DeleteProgram(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteProgram", new { id });
        }

        public Response<AddData<PromoCode>> AddPromoCode(PromoCode entity)
        {
            return ExecutePostRequest<AddData<PromoCode>>("addPromoCode", entity, ignoreIds: true);
        }

        public Response<ViewPromoCodesData> ViewPromoCodes(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewPromoCodesData>("viewPromoCodes", filters);
        }

        public Response<EditData<PromoCode>> EditPromoCode(PromoCode entity)
        {
            return ExecutePostRequest<EditData<PromoCode>>("editPromoCode", entity);
        }

        public Response<StatusMessage> DeletePromoCode(int id)
        {
            return ExecutePostRequest<StatusMessage>("deletePromoCode", new { id });
        }

        public Response<AddData<Question>> AddQuestion(Question entity)
        {
            return ExecutePostRequest<AddData<Question>>("addQuestion", entity, ignoreIds: true);
        }

        public Response<ViewQuestionsData> ViewQuestions(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewQuestionsData>("viewQuestions", filters);
        }

        public Response<EditData<Question>> EditQuestion(Question entity)
        {
            return ExecutePostRequest<EditData<Question>>("editQuestion", entity);
        }

        public Response<StatusMessage> DeleteQuestion(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteQuestion", new { id });
        }

        public Response<AddData<Registration>> AddRegistration(Registration entity)
        {
            return ExecutePostRequest<AddData<Registration>>("addRegistration", entity, ignoreIds: true);
        }

        public Response<ViewRegistrationsData> ViewRegistrations(IDictionary<string, object> filters = null)
        {
            return ExecuteViewRequest<ViewRegistrationsData>("viewRegistrations", filters);
        }

        public Response<EditData<Registration>> EditRegistration(Registration entity)
        {
            return ExecutePostRequest<EditData<Registration>>("editRegistration", entity);
        }

        public Response<StatusMessage> DeleteRegistration(int id)
        {
            return ExecutePostRequest<StatusMessage>("deleteRegistration", new { id });
        }


        private Response<TData> ExecuteViewRequest<TData>(string functionName, IDictionary<string, object> filters)
        {
            var request = CreateGetRequest(functionName, noId, filters);
            var apiClient = new RestClient();
            var apiResponse = apiClient.Execute(request);
            var response = BuildResponse<TData>(apiResponse);
            return response;
        }

        private RestRequest CreateGetRequest(string functionName, int? id, IDictionary<string, object> filters)
        {
            var idParam = id.HasValue ? id.ToString() : "ALL";
            var url = string.Format(getUrlFormat, functionName, idParam);
            if (filters != null && filters.Any())
            {
                var queryParts = filters.Select(m => string.Format("{0}={1}", m.Key, m.Value));
                url += "?" + string.Join("&", queryParts);
            }
            var request = new RestRequest(url, Method.GET);
            request.AddHeader("Accept", responseFormat);
            return request;
        }

        private Response<TData> ExecutePostRequest<TData>(string functionName, object valuesSubmitted, bool ignoreIds = false)
        {
            var request = CreatePostRequest(functionName);
            var apiClient = new RestClient();
            var properties = valuesSubmitted.GetType().GetProperties();
            foreach (var property in properties)
            {
                if (ignoreIds && (property.Name == "id" || property.Name == "add_on_id"))
                {
                    continue;
                }
                var value = property.GetValue(valuesSubmitted);
                request.AddParameter(property.Name, value);
            }
            var apiResponse = apiClient.Execute(request);
            var response = BuildResponse<TData>(apiResponse);
            return response;
        }

        private RestRequest CreatePostRequest(string functionName)
        {
            var url = string.Format(postUrlFormat, functionName);
            var request = new RestRequest(url, Method.POST);
            request.AddHeader("apikey", apiKey);
            request.AddHeader("Accept", responseFormat);
            return request;
        }

        private Response<TData> BuildResponse<TData>(IRestResponse apiResponse)
        {
            var response = new Response<TData>();
            response.Exception = apiResponse.ErrorException;
            response.OriginalContent = apiResponse.Content;
            response.RequestUrl = apiResponse.ResponseUri.AbsoluteUri;
            response.WasSuccessful = apiResponse.ResponseStatus == ResponseStatus.Completed;

            if (response.WasSuccessful)
            {
                try
                {
                    response.Data = Deserialize<TData>(response.OriginalContent);
                }
                catch (Exception exception)
                {
                    HandleException(response, exception);
                }

                EnsureSuccessful(response);
            }

            return response;
        }

        private TData Deserialize<TData>(string originalContent)
        {
            using (var deserlizableContent = new MemoryStream(Encoding.UTF8.GetBytes(originalContent)))
            {
                var json = new DataContractJsonSerializer(typeof(TData));
                var readObject = json.ReadObject(deserlizableContent);
                var result = (TData)readObject;
                return result;
            }
        }

        // this is really ugly but the serializer is overly lenient and will successfully serialize empty objects
        private void EnsureSuccessful<TData>(Response<TData> response)
        {
            if (response.WasSuccessful == false)
            {
                return;
            }
            if (response.Data == null)
            {
                var messageException = new Exception("The data value serialized incorrectly.");
                HandleException(response, messageException);
            }
            var statusMessage = response.Data as IStatus;
            if (statusMessage != null && statusMessage.status != "true")
            {
                HandleException(response, null);
            }
        }

        private void HandleException<TData>(Response<TData> response, Exception exception)
        {
            var statusMessage = GetStatusMessage(response.OriginalContent);
            if (statusMessage != null)
            {
                var errorMessage = statusMessage.message;
                if (statusMessage.error_messages != null && statusMessage.error_messages.Any())
                {
                    errorMessage = string.Join(Environment.NewLine, statusMessage.error_messages);
                }
                response.Exception = new Exception(errorMessage, exception);
            }
            else
            {
                response.Exception = exception;
            }
            response.WasSuccessful = false;
        }

        private StatusMessage GetStatusMessage(string responseContent)
        {
            try
            {
                return Deserialize<StatusMessage>(responseContent);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
