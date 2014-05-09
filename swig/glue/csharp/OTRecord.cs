/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class OTRecord : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OTRecord(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OTRecord obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OTRecord() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_OTRecord(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public bool IsPending() {
    bool ret = otapiPINVOKE.OTRecord_IsPending(swigCPtr);
    return ret;
  }

  public bool IsOutgoing() {
    bool ret = otapiPINVOKE.OTRecord_IsOutgoing(swigCPtr);
    return ret;
  }

  public bool IsRecord() {
    bool ret = otapiPINVOKE.OTRecord_IsRecord(swigCPtr);
    return ret;
  }

  public bool IsReceipt() {
    bool ret = otapiPINVOKE.OTRecord_IsReceipt(swigCPtr);
    return ret;
  }

  public bool IsMail() {
    bool ret = otapiPINVOKE.OTRecord_IsMail(swigCPtr);
    return ret;
  }

  public bool IsTransfer() {
    bool ret = otapiPINVOKE.OTRecord_IsTransfer(swigCPtr);
    return ret;
  }

  public bool IsCheque() {
    bool ret = otapiPINVOKE.OTRecord_IsCheque(swigCPtr);
    return ret;
  }

  public bool IsInvoice() {
    bool ret = otapiPINVOKE.OTRecord_IsInvoice(swigCPtr);
    return ret;
  }

  public bool IsVoucher() {
    bool ret = otapiPINVOKE.OTRecord_IsVoucher(swigCPtr);
    return ret;
  }

  public bool IsContract() {
    bool ret = otapiPINVOKE.OTRecord_IsContract(swigCPtr);
    return ret;
  }

  public bool IsPaymentPlan() {
    bool ret = otapiPINVOKE.OTRecord_IsPaymentPlan(swigCPtr);
    return ret;
  }

  public bool IsCash() {
    bool ret = otapiPINVOKE.OTRecord_IsCash(swigCPtr);
    return ret;
  }

  public bool HasContents() {
    bool ret = otapiPINVOKE.OTRecord_HasContents(swigCPtr);
    return ret;
  }

  public bool HasMemo() {
    bool ret = otapiPINVOKE.OTRecord_HasMemo(swigCPtr);
    return ret;
  }

  public bool IsExpired() {
    bool ret = otapiPINVOKE.OTRecord_IsExpired(swigCPtr);
    return ret;
  }

  public bool IsCanceled() {
    bool ret = otapiPINVOKE.OTRecord_IsCanceled(swigCPtr);
    return ret;
  }

  public void SetExpired() {
    otapiPINVOKE.OTRecord_SetExpired(swigCPtr);
  }

  public void SetCanceled() {
    otapiPINVOKE.OTRecord_SetCanceled(swigCPtr);
  }

  public SWIGTYPE_p_time64_t GetValidFrom() {
    SWIGTYPE_p_time64_t ret = new SWIGTYPE_p_time64_t(otapiPINVOKE.OTRecord_GetValidFrom(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_time64_t GetValidTo() {
    SWIGTYPE_p_time64_t ret = new SWIGTYPE_p_time64_t(otapiPINVOKE.OTRecord_GetValidTo(swigCPtr), true);
    return ret;
  }

  public void SetDateRange(SWIGTYPE_p_time64_t tValidFrom, SWIGTYPE_p_time64_t tValidTo) {
    otapiPINVOKE.OTRecord_SetDateRange(swigCPtr, SWIGTYPE_p_time64_t.getCPtr(tValidFrom), SWIGTYPE_p_time64_t.getCPtr(tValidTo));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool CanDeleteRecord() {
    bool ret = otapiPINVOKE.OTRecord_CanDeleteRecord(swigCPtr);
    return ret;
  }

  public bool CanAcceptIncoming() {
    bool ret = otapiPINVOKE.OTRecord_CanAcceptIncoming(swigCPtr);
    return ret;
  }

  public bool CanDiscardIncoming() {
    bool ret = otapiPINVOKE.OTRecord_CanDiscardIncoming(swigCPtr);
    return ret;
  }

  public bool CanCancelOutgoing() {
    bool ret = otapiPINVOKE.OTRecord_CanCancelOutgoing(swigCPtr);
    return ret;
  }

  public bool CanDiscardOutgoingCash() {
    bool ret = otapiPINVOKE.OTRecord_CanDiscardOutgoingCash(swigCPtr);
    return ret;
  }

  public bool CancelOutgoing(string str_via_acct) {
    bool ret = otapiPINVOKE.OTRecord_CancelOutgoing(swigCPtr, str_via_acct);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AcceptIncomingInstrument(string str_into_acct) {
    bool ret = otapiPINVOKE.OTRecord_AcceptIncomingInstrument(swigCPtr, str_into_acct);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool AcceptIncomingTransfer() {
    bool ret = otapiPINVOKE.OTRecord_AcceptIncomingTransfer(swigCPtr);
    return ret;
  }

  public bool AcceptIncomingReceipt() {
    bool ret = otapiPINVOKE.OTRecord_AcceptIncomingReceipt(swigCPtr);
    return ret;
  }

  public bool DiscardIncoming() {
    bool ret = otapiPINVOKE.OTRecord_DiscardIncoming(swigCPtr);
    return ret;
  }

  public bool DeleteRecord() {
    bool ret = otapiPINVOKE.OTRecord_DeleteRecord(swigCPtr);
    return ret;
  }

  public bool DiscardOutgoingCash() {
    bool ret = otapiPINVOKE.OTRecord_DiscardOutgoingCash(swigCPtr);
    return ret;
  }

  public int GetBoxIndex() {
    int ret = otapiPINVOKE.OTRecord_GetBoxIndex(swigCPtr);
    return ret;
  }

  public void SetBoxIndex(int nBoxIndex) {
    otapiPINVOKE.OTRecord_SetBoxIndex(swigCPtr, nBoxIndex);
  }

  public long GetTransactionNum() {
    long ret = otapiPINVOKE.OTRecord_GetTransactionNum(swigCPtr);
    return ret;
  }

  public void SetTransactionNum(long lTransNum) {
    otapiPINVOKE.OTRecord_SetTransactionNum(swigCPtr, lTransNum);
  }

  public long GetTransNumForDisplay() {
    long ret = otapiPINVOKE.OTRecord_GetTransNumForDisplay(swigCPtr);
    return ret;
  }

  public void SetTransNumForDisplay(long lTransNum) {
    otapiPINVOKE.OTRecord_SetTransNumForDisplay(swigCPtr, lTransNum);
  }

  public OTRecord.OTRecordType GetRecordType() {
    OTRecord.OTRecordType ret = (OTRecord.OTRecordType)otapiPINVOKE.OTRecord_GetRecordType(swigCPtr);
    return ret;
  }

  public string GetServerID() {
    string ret = otapiPINVOKE.OTRecord_GetServerID(swigCPtr);
    return ret;
  }

  public string GetAssetID() {
    string ret = otapiPINVOKE.OTRecord_GetAssetID(swigCPtr);
    return ret;
  }

  public string GetCurrencyTLA() {
    string ret = otapiPINVOKE.OTRecord_GetCurrencyTLA(swigCPtr);
    return ret;
  }

  public string GetNymID() {
    string ret = otapiPINVOKE.OTRecord_GetNymID(swigCPtr);
    return ret;
  }

  public string GetAccountID() {
    string ret = otapiPINVOKE.OTRecord_GetAccountID(swigCPtr);
    return ret;
  }

  public string GetOtherNymID() {
    string ret = otapiPINVOKE.OTRecord_GetOtherNymID(swigCPtr);
    return ret;
  }

  public string GetOtherAccountID() {
    string ret = otapiPINVOKE.OTRecord_GetOtherAccountID(swigCPtr);
    return ret;
  }

  public string GetName() {
    string ret = otapiPINVOKE.OTRecord_GetName(swigCPtr);
    return ret;
  }

  public string GetDate() {
    string ret = otapiPINVOKE.OTRecord_GetDate(swigCPtr);
    return ret;
  }

  public string GetAmount() {
    string ret = otapiPINVOKE.OTRecord_GetAmount(swigCPtr);
    return ret;
  }

  public string GetInstrumentType() {
    string ret = otapiPINVOKE.OTRecord_GetInstrumentType(swigCPtr);
    return ret;
  }

  public string GetMemo() {
    string ret = otapiPINVOKE.OTRecord_GetMemo(swigCPtr);
    return ret;
  }

  public string GetContents() {
    string ret = otapiPINVOKE.OTRecord_GetContents(swigCPtr);
    return ret;
  }

  public void SetOtherNymID(string str_ID) {
    otapiPINVOKE.OTRecord_SetOtherNymID(swigCPtr, str_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetOtherAccountID(string str_ID) {
    otapiPINVOKE.OTRecord_SetOtherAccountID(swigCPtr, str_ID);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMemo(string str_memo) {
    otapiPINVOKE.OTRecord_SetMemo(swigCPtr, str_memo);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetContents(string str_contents) {
    otapiPINVOKE.OTRecord_SetContents(swigCPtr, str_contents);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasInitialPayment() {
    bool ret = otapiPINVOKE.OTRecord_HasInitialPayment(swigCPtr);
    return ret;
  }

  public bool HasPaymentPlan() {
    bool ret = otapiPINVOKE.OTRecord_HasPaymentPlan(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_time64_t GetInitialPaymentDate() {
    SWIGTYPE_p_time64_t ret = new SWIGTYPE_p_time64_t(otapiPINVOKE.OTRecord_GetInitialPaymentDate(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_time64_t GetPaymentPlanStartDate() {
    SWIGTYPE_p_time64_t ret = new SWIGTYPE_p_time64_t(otapiPINVOKE.OTRecord_GetPaymentPlanStartDate(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_time64_t GetTimeBetweenPayments() {
    SWIGTYPE_p_time64_t ret = new SWIGTYPE_p_time64_t(otapiPINVOKE.OTRecord_GetTimeBetweenPayments(swigCPtr), true);
    return ret;
  }

  public long GetInitialPaymentAmount() {
    long ret = otapiPINVOKE.OTRecord_GetInitialPaymentAmount(swigCPtr);
    return ret;
  }

  public long GetPaymentPlanAmount() {
    long ret = otapiPINVOKE.OTRecord_GetPaymentPlanAmount(swigCPtr);
    return ret;
  }

  public int GetMaximumNoPayments() {
    int ret = otapiPINVOKE.OTRecord_GetMaximumNoPayments(swigCPtr);
    return ret;
  }

  public bool FormatAmount(SWIGTYPE_p_std__string str_output) {
    bool ret = otapiPINVOKE.OTRecord_FormatAmount(swigCPtr, SWIGTYPE_p_std__string.getCPtr(str_output));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FormatDescription(SWIGTYPE_p_std__string str_output) {
    bool ret = otapiPINVOKE.OTRecord_FormatDescription(swigCPtr, SWIGTYPE_p_std__string.getCPtr(str_output));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FormatShortMailDescription(SWIGTYPE_p_std__string str_output) {
    bool ret = otapiPINVOKE.OTRecord_FormatShortMailDescription(swigCPtr, SWIGTYPE_p_std__string.getCPtr(str_output));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool FormatMailSubject(SWIGTYPE_p_std__string str_output) {
    bool ret = otapiPINVOKE.OTRecord_FormatMailSubject(swigCPtr, SWIGTYPE_p_std__string.getCPtr(str_output));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public OTRecord(string str_server_id, string str_asset_id, string str_currency_tla, string str_nym_id, string str_account_id, string str_name, string str_date, string str_amount, string str_type, bool bIsPending, bool bIsOutgoing, bool bIsRecord, bool bIsReceipt, OTRecord.OTRecordType eRecordType) : this(otapiPINVOKE.new_OTRecord(str_server_id, str_asset_id, str_currency_tla, str_nym_id, str_account_id, str_name, str_date, str_amount, str_type, bIsPending, bIsOutgoing, bIsRecord, bIsReceipt, (int)eRecordType), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public enum OTRecordType {
    Mail = 0,
    Transfer,
    Receipt,
    Instrument,
    ErrorState
  }

}

}
