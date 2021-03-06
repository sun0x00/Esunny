//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace QTapTradeWrapperApi {

public class TapAPINewOrder : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPINewOrder(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPINewOrder obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPINewOrder() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          QTapTradeApiPINVOKE.delete_TapAPINewOrder(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string AccountNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_AccountNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_AccountNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_ExchangeNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_ExchangeNo_get(swigCPtr);
      return ret;
    } 
  }

  public char CommodityType {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_CommodityType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_CommodityType_get(swigCPtr);
      return ret;
    } 
  }

  public string CommodityNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_CommodityNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_CommodityNo_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_ContractNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_ContractNo_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_StrikePrice_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_StrikePrice_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_CallOrPutFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_CallOrPutFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string ContractNo2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_ContractNo2_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_ContractNo2_get(swigCPtr);
      return ret;
    } 
  }

  public string StrikePrice2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_StrikePrice2_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_StrikePrice2_get(swigCPtr);
      return ret;
    } 
  }

  public char CallOrPutFlag2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_CallOrPutFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_CallOrPutFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeInForce {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_TimeInForce_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_TimeInForce_get(swigCPtr);
      return ret;
    } 
  }

  public string ExpireTime {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_ExpireTime_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_ExpireTime_get(swigCPtr);
      return ret;
    } 
  }

  public char IsRiskOrder {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_IsRiskOrder_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_IsRiskOrder_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSide {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderSide_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderSide_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_PositionEffect_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_PositionEffect_get(swigCPtr);
      return ret;
    } 
  }

  public char PositionEffect2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_PositionEffect2_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_PositionEffect2_get(swigCPtr);
      return ret;
    } 
  }

  public string InquiryNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_InquiryNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_InquiryNo_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderPrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double OrderPrice2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = QTapTradeApiPINVOKE.TapAPINewOrder_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderQty_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderMinQty {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderMinQty_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderMinQty_get(swigCPtr);
      return ret;
    } 
  }

  public uint MinClipSize {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_MinClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPINewOrder_MinClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public uint MaxClipSize {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_MaxClipSize_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPINewOrder_MaxClipSize_get(swigCPtr);
      return ret;
    } 
  }

  public int RefInt {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_RefInt_set(swigCPtr, value);
    } 
    get {
      int ret = QTapTradeApiPINVOKE.TapAPINewOrder_RefInt_get(swigCPtr);
      return ret;
    } 
  }

  public string RefString {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_RefString_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_RefString_get(swigCPtr);
      return ret;
    } 
  }

  public char TacticsType {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_TacticsType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_TacticsType_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerCondition {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_TriggerCondition_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_TriggerCondition_get(swigCPtr);
      return ret;
    } 
  }

  public char TriggerPriceType {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_TriggerPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_TriggerPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char AddOneIsValid {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_AddOneIsValid_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_AddOneIsValid_get(swigCPtr);
      return ret;
    } 
  }

  public uint OrderQty2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_OrderQty2_set(swigCPtr, value);
    } 
    get {
      uint ret = QTapTradeApiPINVOKE.TapAPINewOrder_OrderQty2_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag2 {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_HedgeFlag2_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_HedgeFlag2_get(swigCPtr);
      return ret;
    } 
  }

  public byte MarketLevel {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_MarketLevel_set(swigCPtr, value);
    } 
    get {
      byte ret = QTapTradeApiPINVOKE.TapAPINewOrder_MarketLevel_get(swigCPtr);
      return ret;
    } 
  }

  public char FutureAutoCloseFlag {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_FutureAutoCloseFlag_set(swigCPtr, value);
    } 
    get {
      char ret = QTapTradeApiPINVOKE.TapAPINewOrder_FutureAutoCloseFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string UpperChannelNo {
    set {
      QTapTradeApiPINVOKE.TapAPINewOrder_UpperChannelNo_set(swigCPtr, value);
    } 
    get {
      string ret = QTapTradeApiPINVOKE.TapAPINewOrder_UpperChannelNo_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPINewOrder() : this(QTapTradeApiPINVOKE.new_TapAPINewOrder(), true) {
  }

}

}
