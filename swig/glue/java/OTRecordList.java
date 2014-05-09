/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.0
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.opentransactions.otapi;

public class OTRecordList {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected OTRecordList(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(OTRecordList obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        otapiJNI.delete_OTRecordList(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public static boolean setAddrBookCaller(OTLookupCaller theCaller) {
    return otapiJNI.OTRecordList_setAddrBookCaller(OTLookupCaller.getCPtr(theCaller), theCaller);
  }

  public static OTLookupCaller getAddrBookCaller() {
    long cPtr = otapiJNI.OTRecordList_getAddrBookCaller();
    return (cPtr == 0) ? null : new OTLookupCaller(cPtr, false);
  }

  public OTRecordList() {
    this(otapiJNI.new_OTRecordList__SWIG_0(), true);
  }

  public OTRecordList(OTNameLookup theLookup) {
    this(otapiJNI.new_OTRecordList__SWIG_1(OTNameLookup.getCPtr(theLookup), theLookup), true);
  }

  public static String textTo() {
    return otapiJNI.OTRecordList_textTo();
  }

  public static String textFrom() {
    return otapiJNI.OTRecordList_textFrom();
  }

  public static void setTextTo(String text) {
    otapiJNI.OTRecordList_setTextTo(text);
  }

  public static void setTextFrom(String text) {
    otapiJNI.OTRecordList_setTextFrom(text);
  }

  public void SetFastMode() {
    otapiJNI.OTRecordList_SetFastMode(swigCPtr, this);
  }

  public void SetServerID(String str_id) {
    otapiJNI.OTRecordList_SetServerID(swigCPtr, this, str_id);
  }

  public void AddServerID(String str_id) {
    otapiJNI.OTRecordList_AddServerID(swigCPtr, this, str_id);
  }

  public void ClearServers() {
    otapiJNI.OTRecordList_ClearServers(swigCPtr, this);
  }

  public void SetAssetID(String str_id) {
    otapiJNI.OTRecordList_SetAssetID(swigCPtr, this, str_id);
  }

  public void AddAssetID(String str_id) {
    otapiJNI.OTRecordList_AddAssetID(swigCPtr, this, str_id);
  }

  public void ClearAssets() {
    otapiJNI.OTRecordList_ClearAssets(swigCPtr, this);
  }

  public void SetNymID(String str_id) {
    otapiJNI.OTRecordList_SetNymID(swigCPtr, this, str_id);
  }

  public void AddNymID(String str_id) {
    otapiJNI.OTRecordList_AddNymID(swigCPtr, this, str_id);
  }

  public void ClearNyms() {
    otapiJNI.OTRecordList_ClearNyms(swigCPtr, this);
  }

  public void SetAccountID(String str_id) {
    otapiJNI.OTRecordList_SetAccountID(swigCPtr, this, str_id);
  }

  public void AddAccountID(String str_id) {
    otapiJNI.OTRecordList_AddAccountID(swigCPtr, this, str_id);
  }

  public void ClearAccounts() {
    otapiJNI.OTRecordList_ClearAccounts(swigCPtr, this);
  }

  public void AcceptChequesAutomatically(boolean bVal) {
    otapiJNI.OTRecordList_AcceptChequesAutomatically__SWIG_0(swigCPtr, this, bVal);
  }

  public void AcceptChequesAutomatically() {
    otapiJNI.OTRecordList_AcceptChequesAutomatically__SWIG_1(swigCPtr, this);
  }

  public void AcceptReceiptsAutomatically(boolean bVal) {
    otapiJNI.OTRecordList_AcceptReceiptsAutomatically__SWIG_0(swigCPtr, this, bVal);
  }

  public void AcceptReceiptsAutomatically() {
    otapiJNI.OTRecordList_AcceptReceiptsAutomatically__SWIG_1(swigCPtr, this);
  }

  public void AcceptTransfersAutomatically(boolean bVal) {
    otapiJNI.OTRecordList_AcceptTransfersAutomatically__SWIG_0(swigCPtr, this, bVal);
  }

  public void AcceptTransfersAutomatically() {
    otapiJNI.OTRecordList_AcceptTransfersAutomatically__SWIG_1(swigCPtr, this);
  }

  public void AcceptCashAutomatically(boolean bVal) {
    otapiJNI.OTRecordList_AcceptCashAutomatically__SWIG_0(swigCPtr, this, bVal);
  }

  public void AcceptCashAutomatically() {
    otapiJNI.OTRecordList_AcceptCashAutomatically__SWIG_1(swigCPtr, this);
  }

  public boolean DoesAcceptChequesAutomatically() {
    return otapiJNI.OTRecordList_DoesAcceptChequesAutomatically(swigCPtr, this);
  }

  public boolean DoesAcceptReceiptsAutomatically() {
    return otapiJNI.OTRecordList_DoesAcceptReceiptsAutomatically(swigCPtr, this);
  }

  public boolean DoesAcceptTransfersAutomatically() {
    return otapiJNI.OTRecordList_DoesAcceptTransfersAutomatically(swigCPtr, this);
  }

  public boolean DoesAcceptCashAutomatically() {
    return otapiJNI.OTRecordList_DoesAcceptCashAutomatically(swigCPtr, this);
  }

  public boolean PerformAutoAccept() {
    return otapiJNI.OTRecordList_PerformAutoAccept(swigCPtr, this);
  }

  public boolean Populate() {
    return otapiJNI.OTRecordList_Populate(swigCPtr, this);
  }

  public void ClearContents() {
    otapiJNI.OTRecordList_ClearContents(swigCPtr, this);
  }

  public int size() {
    return otapiJNI.OTRecordList_size(swigCPtr, this);
  }

  public SWIGTYPE_p__SharedPtrT_OTRecord_t GetRecord(int nIndex) {
    return new SWIGTYPE_p__SharedPtrT_OTRecord_t(otapiJNI.OTRecordList_GetRecord(swigCPtr, this, nIndex), true);
  }

  public boolean RemoveRecord(int nIndex) {
    return otapiJNI.OTRecordList_RemoveRecord(swigCPtr, this, nIndex);
  }

}
