//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperAPI {

public class TapAPITradeContractInfo : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPITradeContractInfo(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPITradeContractInfo obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPITradeContractInfo() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperAPIPINVOKE.delete_TapAPITradeContractInfo(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo1 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractNo1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractNo1_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice1 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_StrikePrice1_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_StrikePrice1_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag1 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CallOrPutFlag1_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CallOrPutFlag1_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char ContractType {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractType_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteUnderlyingContract {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_QuoteUnderlyingContract_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_QuoteUnderlyingContract_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractName {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractName_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractName_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractExpDate {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractExpDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_ContractExpDate_get(swigCPtr);
      return ret;
    } 
  }

  public string LastTradeDate {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_LastTradeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_LastTradeDate_get(swigCPtr);
      return ret;
    } 
  }

  public string FirstNoticeDate {
    set {
      TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_FirstNoticeDate_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperAPIPINVOKE.TapAPITradeContractInfo_FirstNoticeDate_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPITradeContractInfo() : this(TapTradeWrapperAPIPINVOKE.new_TapAPITradeContractInfo(), true) {
  }

}

}