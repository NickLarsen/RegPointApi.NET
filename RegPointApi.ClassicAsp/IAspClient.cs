namespace RegPointApi.ClassicAsp
{
    public interface IAspClient
    {
        AddAddOnResponse AddAddOn(AddOn entity);
        ViewAddOnsResponse ViewAddOns(string filters);
        EditAddOnResponse EditAddOn(AddOn entity);
        
        AddAddOnPurchaseResponse AddAddOnPurchase(AddOnPurchase entity);
        ViewAddOnsPurchasedResponse ViewAddOnsPurchased(string filters);
        EditAddOnPurchasedResponse EditAddOnPurchased(AddOnPurchase entity);
        
        AddAnswerResponse AddAnswer(Answer entity);
        ViewAnswersResponse ViewAnswers(string filters);
        EditAnswerResponse EditAnswer(Answer entity);
        
        AddMasterAccountResponse AddMasterAccount(MasterAccount entity);
        ViewMasterAccountsResponse ViewMasterAccounts(string filters);
        EditMasterAccountResponse EditMasterAccount(MasterAccount entity);
        
        AddParticipantResponse AddParticipant(Participant entity);
        ViewParticipantsResponse ViewParticipants(string filters);
        EditParticipantResponse EditParticipant(Participant entity);
        
        AddPaymentResponse AddPayment(Payment entity);
        ViewPaymentsResponse ViewPayments(string filters);
        EditPaymentResponse EditPayment(Payment entity);
        
        AddProgramResponse AddProgram(Program entity);
        ViewProgramsResponse ViewPrograms(string filters);
        EditProgramResponse EditProgram(Program entity);
        
        AddPromoCodeResponse AddPromoCode(PromoCode entity);
        ViewPromoCodesResponse ViewPromoCodes(string filters);
        EditPromoCodeResponse EditPromoCode(PromoCode entity);
        
        AddQuestionResponse AddQuestion(Question entity);
        ViewQuestionsResponse ViewQuestions(string filters);
        EditQuestionResponse EditQuestion(Question entity);
        
        AddRegistrationResponse AddRegistration(Registration entity);
        ViewRegistrationsResponse ViewRegistrations(string filters);
        EditRegistrationResponse EditRegistration(Registration entity);
    }
}
