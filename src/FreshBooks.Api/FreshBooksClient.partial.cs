using System;
using System.Threading;
using System.Threading.Tasks;

namespace FreshBooks.Api
{
    public partial class FreshBooksClient
    {
		
        public async Task<CallbackCreate.response> CallbackCreate(CallbackCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackDelete.response> CallbackDelete(CallbackDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackList.response> CallbackList(CallbackList.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackResendToken.response> CallbackResendToken(CallbackResendToken.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackResendToken.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CallbackVerify.response> CallbackVerify(CallbackVerify.request request, CancellationToken? token = null)
        {
            return await SendAsync<CallbackVerify.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryCreate.response> CategoryCreate(CategoryCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryDelete.response> CategoryDelete(CategoryDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryGet.response> CategoryGet(CategoryGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryListHierarchy.response> CategoryListHierarchy(CategoryListHierarchy.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryListHierarchy.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryList.response> CategoryList(CategoryList.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CategoryUpdate.response> CategoryUpdate(CategoryUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<CategoryUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ClientCreate.response> ClientCreate(ClientCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ClientCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ClientDelete.response> ClientDelete(ClientDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ClientDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ClientGet.response> ClientGet(ClientGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<ClientGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ClientList.response> ClientList(ClientList.request request, CancellationToken? token = null)
        {
            return await SendAsync<ClientList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ClientUpdate.response> ClientUpdate(ClientUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ClientUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ContractorCreate.response> ContractorCreate(ContractorCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ContractorCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ContractorDelete.response> ContractorDelete(ContractorDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ContractorDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ContractorGet.response> ContractorGet(ContractorGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<ContractorGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ContractorList.response> ContractorList(ContractorList.request request, CancellationToken? token = null)
        {
            return await SendAsync<ContractorList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ContractorUpdate.response> ContractorUpdate(ContractorUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ContractorUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<CurrencyList.response> CurrencyList(CurrencyList.request request, CancellationToken? token = null)
        {
            return await SendAsync<CurrencyList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<DefaultTermsGet.response> DefaultTermsGet(DefaultTermsGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<DefaultTermsGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<DefaultTermsList.response> DefaultTermsList(DefaultTermsList.request request, CancellationToken? token = null)
        {
            return await SendAsync<DefaultTermsList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<DefaultTermsUpdate.response> DefaultTermsUpdate(DefaultTermsUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<DefaultTermsUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EmailTemplateGet.response> EmailTemplateGet(EmailTemplateGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<EmailTemplateGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EmailTemplateList.response> EmailTemplateList(EmailTemplateList.request request, CancellationToken? token = null)
        {
            return await SendAsync<EmailTemplateList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EmailTemplateUpdate.response> EmailTemplateUpdate(EmailTemplateUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<EmailTemplateUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateAccept.response> EstimateAccept(EstimateAccept.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateAccept.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateCreate.response> EstimateCreate(EstimateCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateDelete.response> EstimateDelete(EstimateDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateGet.response> EstimateGet(EstimateGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> EstimateGetPDF(EstimateGetPDF.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateList.response> EstimateList(EstimateList.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateMarkAsSent.response> EstimateMarkAsSent(EstimateMarkAsSent.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateMarkAsSent.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> EstimateSendByEmailCustomEmail(EstimateSendByEmailCustomEmail.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> EstimateSendByEmail(EstimateSendByEmail.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<EstimateUpdate.response> EstimateUpdate(EstimateUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<EstimateUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ExpenseCreate.response> ExpenseCreate(ExpenseCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ExpenseCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ExpenseDelete.response> ExpenseDelete(ExpenseDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ExpenseDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ExpenseGet.response> ExpenseGet(ExpenseGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<ExpenseGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ExpenseList.response> ExpenseList(ExpenseList.request request, CancellationToken? token = null)
        {
            return await SendAsync<ExpenseList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ExpenseUpdate.response> ExpenseUpdate(ExpenseUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ExpenseUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<GatewayList.response> GatewayList(GatewayList.request request, CancellationToken? token = null)
        {
            return await SendAsync<GatewayList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceCreate.response> InvoiceCreate(InvoiceCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> InvoiceDelete(InvoiceDelete.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceGet.response> InvoiceGet(InvoiceGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> InvoiceGetPDF(InvoiceGetPDF.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceLinesAdd.response> InvoiceLinesAdd(InvoiceLinesAdd.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceLinesAdd.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceLinesDelete.response> InvoiceLinesDelete(InvoiceLinesDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceLinesDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceLinesUpdate.response> InvoiceLinesUpdate(InvoiceLinesUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceLinesUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceList.response> InvoiceList(InvoiceList.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceSendByEmailCustomEmail.response> InvoiceSendByEmailCustomEmail(InvoiceSendByEmailCustomEmail.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceSendByEmailCustomEmail.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceSendByEmail.response> InvoiceSendByEmail(InvoiceSendByEmail.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceSendByEmail.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceSendBySnailMail.response> InvoiceSendBySnailMail(InvoiceSendBySnailMail.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceSendBySnailMail.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<InvoiceUpdate.response> InvoiceUpdate(InvoiceUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<InvoiceUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ItemCreate.response> ItemCreate(ItemCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ItemCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ItemDelete.response> ItemDelete(ItemDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ItemDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ItemGet.response> ItemGet(ItemGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<ItemGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ItemList.response> ItemList(ItemList.request request, CancellationToken? token = null)
        {
            return await SendAsync<ItemList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ItemUpdate.response> ItemUpdate(ItemUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ItemUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<LanguageList.response> LanguageList(LanguageList.request request, CancellationToken? token = null)
        {
            return await SendAsync<LanguageList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<PaymentCreate.response> PaymentCreate(PaymentCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<PaymentCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<PaymentDelete.response> PaymentDelete(PaymentDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<PaymentDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<PaymentGet.response> PaymentGet(PaymentGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<PaymentGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<PaymentList.response> PaymentList(PaymentList.request request, CancellationToken? token = null)
        {
            return await SendAsync<PaymentList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<PaymentUpdate.response> PaymentUpdate(PaymentUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<PaymentUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ProjectCreate.response> ProjectCreate(ProjectCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ProjectCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ProjectDelete.response> ProjectDelete(ProjectDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ProjectDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ProjectGet.response> ProjectGet(ProjectGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<ProjectGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ProjectList.response> ProjectList(ProjectList.request request, CancellationToken? token = null)
        {
            return await SendAsync<ProjectList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ProjectUpdate.response> ProjectUpdate(ProjectUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ProjectUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReceiptCreate.response> ReceiptCreate(ReceiptCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReceiptCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReceiptDelete.response> ReceiptDelete(ReceiptDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReceiptDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<byte[]> ReceiptGet(ReceiptGet.request request, CancellationToken? token = null)
        {
            return await GetBytesAsync(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReceiptUpdate.response> ReceiptUpdate(ReceiptUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReceiptUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringCreate.response> RecurringCreate(RecurringCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringDelete.response> RecurringDelete(RecurringDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringGet.response> RecurringGet(RecurringGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringLinesAdd.response> RecurringLinesAdd(RecurringLinesAdd.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringLinesAdd.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringLinesDelete.response> RecurringLinesDelete(RecurringLinesDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringLinesDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringLinesUpdate.response> RecurringLinesUpdate(RecurringLinesUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringLinesUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringList.response> RecurringList(RecurringList.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<RecurringUpdate.response> RecurringUpdate(RecurringUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<RecurringUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReportGetClientDetails.response> ReportGetClientDetails(ReportGetClientDetails.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReportGetClientDetails.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReportGetEstimateDetails.response> ReportGetEstimateDetails(ReportGetEstimateDetails.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReportGetEstimateDetails.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReportGetExpenseDetails.response> ReportGetExpenseDetails(ReportGetExpenseDetails.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReportGetExpenseDetails.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReportGetInvoiceDetails.response> ReportGetInvoiceDetails(ReportGetInvoiceDetails.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReportGetInvoiceDetails.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<ReportGetProfitDetails.response> ReportGetProfitDetails(ReportGetProfitDetails.request request, CancellationToken? token = null)
        {
            return await SendAsync<ReportGetProfitDetails.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffCreate.response> StaffCreate(StaffCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffCurrent.response> StaffCurrent(StaffCurrent.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffCurrent.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffDelete.response> StaffDelete(StaffDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffGet.response> StaffGet(StaffGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffList.response> StaffList(StaffList.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<StaffUpdate.response> StaffUpdate(StaffUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<StaffUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<SystemCurrent.response> SystemCurrent(SystemCurrent.request request, CancellationToken? token = null)
        {
            return await SendAsync<SystemCurrent.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaskCreate.response> TaskCreate(TaskCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaskCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaskDelete.response> TaskDelete(TaskDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaskDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaskGet.response> TaskGet(TaskGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaskGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaskList.response> TaskList(TaskList.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaskList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaskUpdate.response> TaskUpdate(TaskUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaskUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaxCreate.response> TaxCreate(TaxCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaxCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaxDelete.response> TaxDelete(TaxDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaxDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaxGet.response> TaxGet(TaxGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaxGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaxList.response> TaxList(TaxList.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaxList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TaxUpdate.response> TaxUpdate(TaxUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TaxUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TimeEntryCreate.response> TimeEntryCreate(TimeEntryCreate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TimeEntryCreate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TimeEntryDelete.response> TimeEntryDelete(TimeEntryDelete.request request, CancellationToken? token = null)
        {
            return await SendAsync<TimeEntryDelete.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TimeEntryGet.response> TimeEntryGet(TimeEntryGet.request request, CancellationToken? token = null)
        {
            return await SendAsync<TimeEntryGet.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TimeEntryList.response> TimeEntryList(TimeEntryList.request request, CancellationToken? token = null)
        {
            return await SendAsync<TimeEntryList.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
		
        public async Task<TimeEntryUpdate.response> TimeEntryUpdate(TimeEntryUpdate.request request, CancellationToken? token = null)
        {
            return await SendAsync<TimeEntryUpdate.response>(request.ToXmlString(), token.GetValueOrDefault(CancellationToken.None));
        }
	}
}
