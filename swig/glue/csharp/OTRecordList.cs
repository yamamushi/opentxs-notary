/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace OpenTransactions.OTAPI {

public class OTRecordList : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal OTRecordList(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(OTRecordList obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~OTRecordList() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          otapiPINVOKE.delete_OTRecordList(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static bool setAddrBookCaller(OTLookupCaller theCaller) {
    bool ret = otapiPINVOKE.OTRecordList_setAddrBookCaller(OTLookupCaller.getCPtr(theCaller));
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static OTLookupCaller getAddrBookCaller() {
    global::System.IntPtr cPtr = otapiPINVOKE.OTRecordList_getAddrBookCaller();
    OTLookupCaller ret = (cPtr == global::System.IntPtr.Zero) ? null : new OTLookupCaller(cPtr, false);
    return ret;
  }

  public OTRecordList() : this(otapiPINVOKE.new_OTRecordList__SWIG_0(), true) {
  }

  public OTRecordList(OTNameLookup theLookup) : this(otapiPINVOKE.new_OTRecordList__SWIG_1(OTNameLookup.getCPtr(theLookup)), true) {
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static string textTo() {
    string ret = otapiPINVOKE.OTRecordList_textTo();
    return ret;
  }

  public static string textFrom() {
    string ret = otapiPINVOKE.OTRecordList_textFrom();
    return ret;
  }

  public static void setTextTo(string text) {
    otapiPINVOKE.OTRecordList_setTextTo(text);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public static void setTextFrom(string text) {
    otapiPINVOKE.OTRecordList_setTextFrom(text);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetFastMode() {
    otapiPINVOKE.OTRecordList_SetFastMode(swigCPtr);
  }

  public void SetServerID(string str_id) {
    otapiPINVOKE.OTRecordList_SetServerID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddServerID(string str_id) {
    otapiPINVOKE.OTRecordList_AddServerID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearServers() {
    otapiPINVOKE.OTRecordList_ClearServers(swigCPtr);
  }

  public void SetAssetID(string str_id) {
    otapiPINVOKE.OTRecordList_SetAssetID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddAssetID(string str_id) {
    otapiPINVOKE.OTRecordList_AddAssetID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearAssets() {
    otapiPINVOKE.OTRecordList_ClearAssets(swigCPtr);
  }

  public void SetNymID(string str_id) {
    otapiPINVOKE.OTRecordList_SetNymID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddNymID(string str_id) {
    otapiPINVOKE.OTRecordList_AddNymID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearNyms() {
    otapiPINVOKE.OTRecordList_ClearNyms(swigCPtr);
  }

  public void SetAccountID(string str_id) {
    otapiPINVOKE.OTRecordList_SetAccountID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddAccountID(string str_id) {
    otapiPINVOKE.OTRecordList_AddAccountID(swigCPtr, str_id);
    if (otapiPINVOKE.SWIGPendingException.Pending) throw otapiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ClearAccounts() {
    otapiPINVOKE.OTRecordList_ClearAccounts(swigCPtr);
  }

  public void AcceptChequesAutomatically(bool bVal) {
    otapiPINVOKE.OTRecordList_AcceptChequesAutomatically__SWIG_0(swigCPtr, bVal);
  }

  public void AcceptChequesAutomatically() {
    otapiPINVOKE.OTRecordList_AcceptChequesAutomatically__SWIG_1(swigCPtr);
  }

  public void AcceptReceiptsAutomatically(bool bVal) {
    otapiPINVOKE.OTRecordList_AcceptReceiptsAutomatically__SWIG_0(swigCPtr, bVal);
  }

  public void AcceptReceiptsAutomatically() {
    otapiPINVOKE.OTRecordList_AcceptReceiptsAutomatically__SWIG_1(swigCPtr);
  }

  public void AcceptTransfersAutomatically(bool bVal) {
    otapiPINVOKE.OTRecordList_AcceptTransfersAutomatically__SWIG_0(swigCPtr, bVal);
  }

  public void AcceptTransfersAutomatically() {
    otapiPINVOKE.OTRecordList_AcceptTransfersAutomatically__SWIG_1(swigCPtr);
  }

  public void AcceptCashAutomatically(bool bVal) {
    otapiPINVOKE.OTRecordList_AcceptCashAutomatically__SWIG_0(swigCPtr, bVal);
  }

  public void AcceptCashAutomatically() {
    otapiPINVOKE.OTRecordList_AcceptCashAutomatically__SWIG_1(swigCPtr);
  }

  public bool DoesAcceptChequesAutomatically() {
    bool ret = otapiPINVOKE.OTRecordList_DoesAcceptChequesAutomatically(swigCPtr);
    return ret;
  }

  public bool DoesAcceptReceiptsAutomatically() {
    bool ret = otapiPINVOKE.OTRecordList_DoesAcceptReceiptsAutomatically(swigCPtr);
    return ret;
  }

  public bool DoesAcceptTransfersAutomatically() {
    bool ret = otapiPINVOKE.OTRecordList_DoesAcceptTransfersAutomatically(swigCPtr);
    return ret;
  }

  public bool DoesAcceptCashAutomatically() {
    bool ret = otapiPINVOKE.OTRecordList_DoesAcceptCashAutomatically(swigCPtr);
    return ret;
  }

  public bool PerformAutoAccept() {
    bool ret = otapiPINVOKE.OTRecordList_PerformAutoAccept(swigCPtr);
    return ret;
  }

  public bool Populate() {
    bool ret = otapiPINVOKE.OTRecordList_Populate(swigCPtr);
    return ret;
  }

  public void ClearContents() {
    otapiPINVOKE.OTRecordList_ClearContents(swigCPtr);
  }

  public int size() {
    int ret = otapiPINVOKE.OTRecordList_size(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p__SharedPtrT_OTRecord_t GetRecord(int nIndex) {
    SWIGTYPE_p__SharedPtrT_OTRecord_t ret = new SWIGTYPE_p__SharedPtrT_OTRecord_t(otapiPINVOKE.OTRecordList_GetRecord(swigCPtr, nIndex), true);
    return ret;
  }

  public bool RemoveRecord(int nIndex) {
    bool ret = otapiPINVOKE.OTRecordList_RemoveRecord(swigCPtr, nIndex);
    return ret;
  }

}

}
