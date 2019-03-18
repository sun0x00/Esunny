//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace TapTradeWrapperApi {

public class TapAPIAccountMarginRentQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPIAccountMarginRentQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPIAccountMarginRentQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPIAccountMarginRentQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeWrapperPINVOKE.delete_TapAPIAccountMarginRentQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char CalculateMode {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CalculateMode_set(swigCPtr, value);
    } 
    get {
      char ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CalculateMode_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyGroupNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CurrencyGroupNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CurrencyGroupNo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyNo {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CurrencyNo_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_CurrencyNo_get(swigCPtr);
      return ret;
    } 
  }

  public double InitialMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_InitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_InitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double MaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_MaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_MaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellInitialMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_SellInitialMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_SellInitialMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double SellMaintenanceMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_SellMaintenanceMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_SellMaintenanceMargin_get(swigCPtr);
      return ret;
    } 
  }

  public double LockMargin {
    set {
      TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_LockMargin_set(swigCPtr, value);
    } 
    get {
      double ret = TapTradeWrapperPINVOKE.TapAPIAccountMarginRentQryRsp_LockMargin_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPIAccountMarginRentQryRsp() : this(TapTradeWrapperPINVOKE.new_TapAPIAccountMarginRentQryRsp(), true) {
  }

}

}
