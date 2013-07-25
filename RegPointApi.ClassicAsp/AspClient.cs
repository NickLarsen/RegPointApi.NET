using System.Collections.Generic;
using System.Linq;

namespace RegPointApi.ClassicAsp
{
    public class AspClient : IAspClient
    {
        private IClient client;

        public void SetApiKey(string apiKey)
        {
            client = new Client(apiKey);
        }

        public string GetApiKey()
        {
            return "GetApiKey()";
        }




        public AddAddOnResponse AddAddOn(AddOn entity)
        {
            var response = client.AddAddOn(entity);
            return new AddAddOnResponse(response);
        }

        public ViewAddOnsResponse ViewAddOns(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewAddOns(filtersDictionary);
            return new ViewAddOnsResponse(response);
        }

        public EditAddOnResponse EditAddOn(AddOn entity)
        {
            var response = client.EditAddOn(entity);
            return new EditAddOnResponse(response);
        }




        public AddAddOnPurchaseResponse AddAddOnPurchase(AddOnPurchase entity)
        {
            var response = client.AddAddOnPurchase(entity);
            return new AddAddOnPurchaseResponse(response);
        }

        public ViewAddOnsPurchasedResponse ViewAddOnsPurchased(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewAddOnsPurchased(filtersDictionary);
            return new ViewAddOnsPurchasedResponse(response);
        }

        public EditAddOnPurchasedResponse EditAddOnPurchased(AddOnPurchase entity)
        {
            var response = client.EditAddOnPurchased(entity);
            return new EditAddOnPurchasedResponse(response);
        } 




        public AddAnswerResponse AddAnswer(Answer entity)
        {
            var response = client.AddAnswer(entity);
            return new AddAnswerResponse(response);
        }

        public ViewAnswersResponse ViewAnswers(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewAnswers(filtersDictionary);
            return new ViewAnswersResponse(response);
        }

        public EditAnswerResponse EditAnswer(Answer entity)
        {
            var response = client.EditAnswer(entity);
            return new EditAnswerResponse(response);
        }




        public AddMasterAccountResponse AddMasterAccount(MasterAccount entity)
        {
            var response = client.AddMasterAccount(entity);
            return new AddMasterAccountResponse(response);
        }

        public ViewMasterAccountsResponse ViewMasterAccounts(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewMasterAccounts(filtersDictionary);
            return new ViewMasterAccountsResponse(response);
        }

        public EditMasterAccountResponse EditMasterAccount(MasterAccount entity)
        {
            var response = client.EditMasterAccount(entity);
            return new EditMasterAccountResponse(response);
        }




        public AddParticipantResponse AddParticipant(Participant entity)
        {
            var response = client.AddParticipant(entity);
            return new AddParticipantResponse(response);
        }

        public ViewParticipantsResponse ViewParticipants(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewParticipants(filtersDictionary);
            return new ViewParticipantsResponse(response);
        }

        public EditParticipantResponse EditParticipant(Participant entity)
        {
            var response = client.EditParticipant(entity);
            return new EditParticipantResponse(response);
        }




        public AddPaymentResponse AddPayment(Payment entity)
        {
            var response = client.AddPayment(entity);
            return new AddPaymentResponse(response);
        }

        public ViewPaymentsResponse ViewPayments(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewPayments(filtersDictionary);
            return new ViewPaymentsResponse(response);
        }

        public EditPaymentResponse EditPayment(Payment entity)
        {
            var response = client.EditPayment(entity);
            return new EditPaymentResponse(response);
        }




        public AddProgramResponse AddProgram(Program entity)
        {
            var response = client.AddProgram(entity);
            return new AddProgramResponse(response);
        }

        public ViewProgramsResponse ViewPrograms(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewPrograms(filtersDictionary);
            return new ViewProgramsResponse(response);
        }

        public EditProgramResponse EditProgram(Program entity)
        {
            var response = client.EditProgram(entity);
            return new EditProgramResponse(response);
        }




        public AddPromoCodeResponse AddPromoCode(PromoCode entity)
        {
            var response = client.AddPromoCode(entity);
            return new AddPromoCodeResponse(response);
        }

        public ViewPromoCodesResponse ViewPromoCodes(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewPromoCodes(filtersDictionary);
            return new ViewPromoCodesResponse(response);
        }

        public EditPromoCodeResponse EditPromoCode(PromoCode entity)
        {
            var response = client.EditPromoCode(entity);
            return new EditPromoCodeResponse(response);
        }




        public AddQuestionResponse AddQuestion(Question entity)
        {
            var response = client.AddQuestion(entity);
            return new AddQuestionResponse(response);
        }

        public ViewQuestionsResponse ViewQuestions(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewQuestions(filtersDictionary);
            return new ViewQuestionsResponse(response);
        }

        public EditQuestionResponse EditQuestion(Question entity)
        {
            var response = client.EditQuestion(entity);
            return new EditQuestionResponse(response);
        }




        public AddRegistrationResponse AddRegistration(Registration entity)
        {
            var response = client.AddRegistration(entity);
            return new AddRegistrationResponse(response);
        }

        public ViewRegistrationsResponse ViewRegistrations(string filters)
        {
            var filtersDictionary = GetFilters(filters);
            var response = client.ViewRegistrations(filtersDictionary);
            return new ViewRegistrationsResponse(response);
        }

        public EditRegistrationResponse EditRegistration(Registration entity)
        {
            var response = client.EditRegistration(entity);
            return new EditRegistrationResponse(response);
        }




        private IDictionary<string, object> GetFilters(string filtersString)
        {
            return filtersString.Split(';')
                .Select(m => m.Split('='))
                .ToDictionary(m => m[0], m => (object)m[1]);
        }
    }
}
