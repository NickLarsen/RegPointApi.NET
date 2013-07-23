using System.Collections.Generic;

namespace RegPointApi
{
    public interface IClient
    {
        Response<AddAddOnData<AddOn>> AddAddOn(AddOn entity);
        Response<ViewAddOnsData> ViewAddOns(IDictionary<string, object> filters = null);
        Response<EditData<AddOn>> EditAddOn(AddOn entity);
        Response<StatusMessage> DeleteAddOn(int id);

        Response<AddAddOnData<AddOnPurchase>> AddAddOnPurchase(AddOnPurchase entity);
        Response<ViewAddOnsPurchasedData> ViewAddOnsPurchased(IDictionary<string, object> filters = null);
        Response<EditData<AddOnPurchase>> EditAddOnPurchased(AddOnPurchase entity);
        Response<StatusMessage> DeleteAddOnPurchased(int id);

        Response<AddData<Answer>> AddAnswer(Answer entity);
        Response<ViewAnswersData> ViewAnswers(IDictionary<string, object> filters = null);
        Response<EditData<Answer>> EditAnswer(Answer entity);
        Response<StatusMessage> DeleteAnswer(int id);

        Response<AddData<MasterAccount>> AddMasterAccount(MasterAccount entity);
        Response<ViewMasterAccountsData> ViewMasterAccounts(IDictionary<string, object> filters = null);
        Response<EditData<MasterAccount>> EditMasterAccount(MasterAccount entity);
        Response<StatusMessage> DeleteMasterAccount(int id);

        Response<AddData<Participant>> AddParticipant(Participant entity);
        Response<ViewParticipantsData> ViewParticipants(IDictionary<string, object> filters = null);
        Response<EditData<Participant>> EditParticipant(Participant entity);
        Response<StatusMessage> DeleteParticipant(int id);

        Response<AddData<Payment>> AddPayment(Payment entity);
        Response<ViewPaymentsData> ViewPayments(IDictionary<string, object> filters = null);
        Response<EditData<Payment>> EditPayment(Payment entity);
        Response<StatusMessage> DeletePayment(int id);

        Response<AddData<Program>> AddProgram(Program entity);
        Response<ViewProgramsData> ViewPrograms(IDictionary<string, object> filters = null);
        Response<EditData<Program>> EditProgram(Program entity);
        Response<StatusMessage> DeleteProgram(int id);

        Response<AddData<PromoCode>> AddPromoCode(PromoCode entity);
        Response<ViewPromoCodesData> ViewPromoCodes(IDictionary<string, object> filters = null);
        Response<EditData<PromoCode>> EditPromoCode(PromoCode entity);
        Response<StatusMessage> DeletePromoCode(int id);

        Response<AddData<Question>> AddQuestion(Question entity);
        Response<ViewQuestionsData> ViewQuestions(IDictionary<string, object> filters = null);
        Response<EditData<Question>> EditQuestion(Question entity);
        Response<StatusMessage> DeleteQuestion(int id);

        Response<AddData<Registration>> AddRegistration(Registration entity);
        Response<ViewRegistrationsData> ViewRegistrations(IDictionary<string, object> filters = null);
        Response<EditData<Registration>> EditRegistration(Registration entity);
        Response<StatusMessage> DeleteRegistration(int id);
    }
}
